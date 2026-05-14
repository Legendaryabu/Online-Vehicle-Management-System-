using Microsoft.EntityFrameworkCore;
using OVSMS_Desktop.Data;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace OVSMS_Desktop.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private readonly User _currentAdmin;
        private readonly AppDbContext _context;
        private readonly NumberFormatInfo LkrFormat;


        public AdminDashboardForm(User admin)
        {
            InitializeComponent();
            _currentAdmin = admin ?? throw new ArgumentNullException(nameof(admin));
            _context = new AppDbContext();
            lblWelcomeAdmin.Text = $"Welcome, Admin ({_currentAdmin.Name ?? "Admin"})!";

            // Initialize LKR formatting
            LkrFormat = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            LkrFormat.CurrencySymbol = "Rs."; 
            LkrFormat.CurrencyGroupSeparator = ","; 
            LkrFormat.CurrencyDecimalSeparator = "."; 
            LkrFormat.CurrencyDecimalDigits = 2; 

            PopulateRoleComboBox();
            ClearEditUserPanel();
            PopulateBookingStatusFilter();
        }

        private void AdminDashboardForm_Load(object? sender, EventArgs e)
        {
            // Load stats for the first tab
            LoadOverviewStats();
        }

        private void tabControlAdmin_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedTab == tabOverview)
            {
                LoadOverviewStats();
            }
            else if (tabControlAdmin.SelectedTab == tabAllBookings)
            {
                LoadAllBookings();
            }
            // Logic for Transactions Tab
            else if (tabControlAdmin.SelectedTab == tabTransactions)
            {
                LoadPayments();
            }
            else if (tabControlAdmin.SelectedTab == tabUserManagement)
            {
                LoadAllUsers();
                ClearEditUserPanel();
            }
            else if (tabControlAdmin.SelectedTab == tabProviderApproval)
            {
                LoadPendingProviders();
            }
            else if (tabControlAdmin.SelectedTab == tabServiceManagement)
            {
                LoadServices();
            }
        }

        // --- Overview Tab ---
        private void LoadOverviewStats()
        {
            try
            {
                var today = DateTime.Now;
                // Using Enums for queries
                var totalCustomers = _context.Users.Count(u => u.Role == UserRole.Customer);
                var totalProviders = _context.Users.Count(u => u.Role == UserRole.Provider && u.IsApproved);
                var pendingApprovals = _context.Users.Count(u => u.Role == UserRole.Provider && !u.IsApproved);

                var bookingsThisMonth = _context.Bookings
                    .Count(b => b.BookingDate.Year == today.Year && b.BookingDate.Month == today.Month);

                // Using Enums for payment status check
                var totalRevenue = _context.Bookings
                    .Where(b => b.Status == BookingStatus.Completed && b.PaymentStatus == PaymentStatus.Paid)
                    .Sum(b => (decimal?)b.Price) ?? 0;

                lblTotalCustomersValue.Text = totalCustomers.ToString();
                lblTotalProvidersValue.Text = totalProviders.ToString();
                lblPendingApprovalsValue.Text = pendingApprovals.ToString();
                lblBookingsMonthValue.Text = bookingsThisMonth.ToString();

              
                lblTotalRevenueValue.Text = totalRevenue.ToString("C", LkrFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard stats: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- All Bookings Tab ---
        private void PopulateBookingStatusFilter()
        {
            comboBookingStatusFilter.Items.Clear();
            comboBookingStatusFilter.Items.Add("All");

            // Populating filter combobox using Enum values
            foreach (BookingStatus status in Enum.GetValues(typeof(BookingStatus)))
            {
                comboBookingStatusFilter.Items.Add(status.ToString());
            }
            comboBookingStatusFilter.SelectedIndex = 0;
        }

        private void LoadAllBookings()
        {
            try
            {
                string? filterStatusString = comboBookingStatusFilter.SelectedItem?.ToString();
                IQueryable<Booking> query = _context.Bookings
                                                    .Include(b => b.User)
                                                    .Include(b => b.Provider)
                                                    .Include(b => b.Service)
                                                    .OrderByDescending(b => b.BookingDate);

                // Filtering by Enum value
                if (filterStatusString != "All" && Enum.TryParse<BookingStatus>(filterStatusString, out BookingStatus filterStatus))
                {
                    query = query.Where(b => b.Status == filterStatus);
                }

                var allBookings = query.Select(b => new
                {
                    b.BookingId,
                    Date = b.BookingDate.ToString("yyyy-MM-dd"),
                    Customer = b.User!.Name ?? "",
                    Provider = b.Provider!.Name ?? "Unassigned",
                    Service = b.Service!.Name ?? "",
                    // Displaying the Enum name as a string
                    Status = b.Status.ToString(),
                    PaymentStatus = b.PaymentStatus.ToString()
                }).ToList();

                dgvAllBookings.DataSource = allBookings;

                if (dgvAllBookings.Columns["BookingId"] != null) { dgvAllBookings.Columns["BookingId"].Visible = false; }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bookings: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefreshBookings_Click(object? sender, EventArgs e)
        {
            LoadAllBookings();
        }

        private void btnCancelBookingAdmin_Click(object? sender, EventArgs e)
        {
            // Start of safety checks
            if (dgvAllBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvAllBookings.SelectedRows[0];

            if (!(selectedRow.Cells["BookingId"]?.Value is int bookingId))
            {
                MessageBox.Show("Could not find Booking ID in selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var booking = _context.Bookings.Find(bookingId);
                if (booking != null)
                {
                    // Using Enums for status check
                    if (booking.Status == BookingStatus.Completed || booking.Status == BookingStatus.Cancelled)
                    {
                        MessageBox.Show("This booking is already completed or cancelled and cannot be changed.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    var confirm = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        // Setting status using Enum value
                        booking.Status = BookingStatus.Cancelled;
                        _context.SaveChanges();
                        MessageBox.Show("Booking has been cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllBookings();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cancelling booking: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMarkAsPaidAdmin_Click(object? sender, EventArgs e)
        {
            // Start of safety checks
            if (dgvAllBookings.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a booking to mark as paid.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvAllBookings.SelectedRows[0];

            if (!(selectedRow.Cells["BookingId"]?.Value is int bookingId))
            {
                MessageBox.Show("Could not find Booking ID in selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var booking = _context.Bookings.Find(bookingId);
                if (booking != null)
                {
                    // Using Enums for payment status check
                    if (booking.PaymentStatus == PaymentStatus.Paid)
                    {
                        MessageBox.Show("This booking is already marked as paid.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Setting payment status using Enum value
                    booking.PaymentStatus = PaymentStatus.Paid;

                    var payment = new Payment
                    {
                        Amount = booking.Price,
                        PaymentDate = DateTime.UtcNow,
                        PaymentMethod = PaymentMethod.ManualOverride,
                        TransactionId = $"ADMIN_MANUAL_{_currentAdmin.UserId}_{DateTime.UtcNow.Ticks}",
                        BookingId = booking.BookingId
                    };
                    _context.Payments.Add(payment);
                    _context.SaveChanges();
                    MessageBox.Show("Booking has been marked as paid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllBookings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating payment status: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAllBookings_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (sender is not DataGridView dgv)
                return;

            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgv.Columns == null || e.CellStyle == null)//nl see
                return;

            DataGridViewColumn? column = dgv.Columns[e.ColumnIndex];
            if (column == null)
                return;

            // Use safe values
            string columnName = column.Name ?? string.Empty;
            string cellValue = e.Value?.ToString() ?? string.Empty;

            // Booking Status
            if (columnName.Equals("Status", StringComparison.OrdinalIgnoreCase))
            {
                // Using Enum.ToString() for case-insensitive comparison
                if (cellValue.Equals(BookingStatus.Completed.ToString(), StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.BackColor = Color.LightGreen;
                else if (cellValue.Equals(BookingStatus.Cancelled.ToString(), StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.BackColor = Color.LightGray;
                else if (cellValue.Equals(BookingStatus.Pending.ToString(), StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.BackColor = Color.LightGoldenrodYellow;
            }
            // Payment Status
            else if (columnName.Equals("PaymentStatus", StringComparison.OrdinalIgnoreCase))
            {
                // Using Enum.ToString() for comparison
                if (cellValue.Equals(PaymentStatus.Paid.ToString(), StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.BackColor = Color.LightGreen;
                else if (cellValue.Equals(PaymentStatus.Unpaid.ToString(), StringComparison.OrdinalIgnoreCase))
                    e.CellStyle.BackColor = Color.MistyRose;
            }
        }

        // --- Transactions Tab Methods ---
        private void LoadPayments()
        {
            try
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date.AddDays(1).AddTicks(-1);

                var payments = _context.Payments
                    .Include(p => p.Booking)
                    .ThenInclude(b => b!.User)
                    .Where(p => p.PaymentDate >= startDate && p.PaymentDate <= endDate)
                    .OrderByDescending(p => p.PaymentDate)
                    .Select(p => new
                    {
                        p.PaymentId,
                        Date = p.PaymentDate,
                        Customer = p.Booking!.User!.Name ?? "",
                        Amount = p.Amount,
                        Method = p.PaymentMethod.ToString(), // Converting Enum to display string
                        TransactionID = p.TransactionId,
                        BookingID = p.BookingId
                    }).ToList();

                dgvPayments.DataSource = payments;

                // Configure Columns
                if (dgvPayments.Columns["PaymentId"] != null) { dgvPayments.Columns["PaymentId"].HeaderText = "Payment ID"; }
                if (dgvPayments.Columns["Amount"] != null)
                {
                    // UPDATED: Apply LKR format for currency display
                    dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "C";
                    dgvPayments.Columns["Amount"].DefaultCellStyle.FormatProvider = LkrFormat;
                }
                if (dgvPayments.Columns["TransactionID"] != null) { dgvPayments.Columns["TransactionID"].FillWeight = 200; }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading payments: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFilterPayments_Click(object? sender, EventArgs e)
        {
            LoadPayments();
        }


        // --- User Management Tab ---

        private void PopulateRoleComboBox()
        {
            comboNewRole.Items.Clear();
            // Populating using Enum values
            foreach (UserRole role in Enum.GetValues(typeof(UserRole)))
            {
                comboNewRole.Items.Add(role.ToString().ToLower());
            }
            comboNewRole.SelectedIndex = -1;
        }

        private void LoadPendingProviders()
        {
            try
            {
                // Querying using Enum value
                var pendingProviders = _context.Users
                    .Where(u => u.Role == UserRole.Provider && !u.IsApproved)
                    .OrderBy(u => u.Name)
                    .Select(u => new { u.UserId, u.Name, u.Email, u.Phone })
                    .ToList();

                dgvPendingProviders.DataSource = null;
                dgvPendingProviders.DataSource = pendingProviders;

                if (dgvPendingProviders.Columns["UserId"] != null) { dgvPendingProviders.Columns["UserId"].Visible = false; }
                if (dgvPendingProviders.Columns["Name"] != null) dgvPendingProviders.Columns["Name"].FillWeight = 150;
                if (dgvPendingProviders.Columns["Email"] != null) dgvPendingProviders.Columns["Email"].FillWeight = 200;
                if (dgvPendingProviders.Columns["Phone"] != null) dgvPendingProviders.Columns["Phone"].FillWeight = 100;

                if (dgvPendingProviders.Rows.Count > 0) { dgvPendingProviders.ClearSelection(); }
            }
            catch (Exception ex) { MessageBox.Show($"Error loading pending providers: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnApproveProvider_Click(object? sender, EventArgs e)
        {
            UpdateProviderApproval(true);
        }

        private void btnRejectProvider_Click(object? sender, EventArgs e)
        {
            if (dgvPendingProviders.SelectedRows.Count == 0) { MessageBox.Show("Please select a provider to reject.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!(dgvPendingProviders.SelectedRows[0].Cells["UserId"]?.Value is int userId)) return;
            string providerName = dgvPendingProviders.SelectedRows[0].Cells["Name"]?.Value?.ToString() ?? "Selected Provider";

            if (userId == _currentAdmin.UserId) { MessageBox.Show("You cannot reject your own admin account.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var confirm = MessageBox.Show($"Reject and DELETE provider account '{providerName}'?\nThis cannot be undone.", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var provider = _context.Users.Find(userId);
                    // Querying using Enum value
                    if (provider != null && provider.Role == UserRole.Provider && !provider.IsApproved)
                    {
                        _context.Users.Remove(provider);
                        _context.SaveChanges();
                        MessageBox.Show($"Provider '{providerName}' rejected and deleted.", "Provider Rejected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPendingProviders();
                    }
                    else { MessageBox.Show("Could not find provider or invalid state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); LoadPendingProviders(); }
                }
                catch (Exception ex) { MessageBox.Show($"Error rejecting provider: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void UpdateProviderApproval(bool approve)
        {
            if (dgvPendingProviders.SelectedRows.Count == 0) { MessageBox.Show("Please select a provider to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!(dgvPendingProviders.SelectedRows[0].Cells["UserId"]?.Value is int userId)) return;
            string providerName = dgvPendingProviders.SelectedRows[0].Cells["Name"]?.Value?.ToString() ?? "Selected Provider";

            try
            {
                var provider = _context.Users.Find(userId);
                // Querying using Enum value
                if (provider != null && provider.Role == UserRole.Provider && !provider.IsApproved)
                {
                    provider.IsApproved = approve;
                    _context.SaveChanges();
                    MessageBox.Show($"Provider '{providerName}' approved successfully!", "Approval Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPendingProviders();
                }
                // Querying using Enum value
                else if (provider != null && provider.IsApproved) { MessageBox.Show($"Provider '{providerName}' is already approved.", "Already Approved", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else { MessageBox.Show("Could not find provider or invalid state.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); LoadPendingProviders(); }
            }
            catch (Exception ex) { MessageBox.Show($"Error updating provider approval: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void LoadAllUsers()
        {
            try
            {
                var allUsers = _context.Users
                    .OrderBy(u => u.Role).ThenBy(u => u.Name)
                    .Select(u => new {
                        u.UserId,
                        u.Name,
                        u.Email,
                        u.Phone,
                        // Displaying Enum Role: TitleCase for presentation, internal role for logic
                        Role = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(u.Role.ToString()),
                        RoleInternal = u.Role.ToString().ToLower(),
                        // Using Enum for comparison
                        Approved = u.IsApproved ? "Yes" : (u.Role == UserRole.Provider ? "No" : "N/A")
                    })
                    .ToList();

                dgvAllUsers.DataSource = null;
                dgvAllUsers.DataSource = allUsers;

                if (dgvAllUsers.Columns["UserId"] != null) { dgvAllUsers.Columns["UserId"].Visible = false; }
                if (dgvAllUsers.Columns["RoleInternal"] != null) { dgvAllUsers.Columns["RoleInternal"].Visible = false; }

                if (dgvAllUsers.Columns["Name"] != null) dgvAllUsers.Columns["Name"].FillWeight = 150;
                if (dgvAllUsers.Columns["Email"] != null) dgvAllUsers.Columns["Email"].FillWeight = 200;
                if (dgvAllUsers.Columns["Phone"] != null) dgvAllUsers.Columns["Phone"].FillWeight = 100;
                if (dgvAllUsers.Columns["Role"] != null) dgvAllUsers.Columns["Role"].FillWeight = 80;
                if (dgvAllUsers.Columns["Approved"] != null) dgvAllUsers.Columns["Approved"].FillWeight = 70;


                if (dgvAllUsers.Rows.Count > 0)
                {
                    dgvAllUsers.ClearSelection();
                }

                ClearEditUserPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteUser_Click(object? sender, EventArgs e)
        {
            // Start of safety checks
            if (dgvAllUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvAllUsers.SelectedRows[0];

            if (!(selectedRow.Cells["UserId"]?.Value is int userId))
            {
                MessageBox.Show("Could not find User ID in selected row.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Getting user details for confirmation message
            string userName = selectedRow.Cells["Name"]?.Value?.ToString() ?? "Selected User";
            string userRoleString = selectedRow.Cells["RoleInternal"]?.Value?.ToString()?.ToLower() ?? "";

            if (userId == _currentAdmin.UserId)
            {
                MessageBox.Show("You cannot delete your own admin account.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string warningMessage = $"Are you sure you want to permanently DELETE the user '{userName}'?\nThis cannot be undone.";
            if (userRoleString == UserRole.Provider.ToString().ToLower() || userRoleString == UserRole.Customer.ToString().ToLower())
            {
                warningMessage += "\nDeleting users with active bookings may cause issues.";
            }

            var confirm = MessageBox.Show(warningMessage, "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var userToDelete = _context.Users.Find(userId);
                    if (userToDelete != null)
                    {
                        _context.Users.Remove(userToDelete);
                        _context.SaveChanges();
                        MessageBox.Show($"User '{userName}' deleted successfully.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllUsers();
                    }
                    else
                    {
                        MessageBox.Show("Could not find the selected user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadAllUsers();
                    }
                }
                catch (DbUpdateException dbEx)
                {
                    MessageBox.Show($"Could not delete user '{userName}'. They may have related records (like bookings) that prevent deletion.\n\nDetails: {dbEx.InnerException?.Message ?? dbEx.Message}", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoadAllUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnChangeRole_Click(object? sender, EventArgs e)
        {
            if (dgvAllUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to change their role.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dgvAllUsers.SelectedRows[0];

            if (!(selectedRow.Cells["UserId"]?.Value is int userId)) return;

            if (comboNewRole.SelectedItem == null)
            {
                MessageBox.Show("Please select the new role from the dropdown.", "Role Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieving selected role string and converting it to Enum
            string newRoleString = comboNewRole.SelectedItem.ToString() ?? "";

            if (!Enum.TryParse<UserRole>(newRoleString, true, out UserRole newRole))
            {
                MessageBox.Show("Invalid role selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userName = selectedRow.Cells["Name"]?.Value?.ToString() ?? "Selected User";
            string currentRoleString = selectedRow.Cells["RoleInternal"]?.Value?.ToString()?.ToLower() ?? "";

            if (!Enum.TryParse<UserRole>(currentRoleString, true, out UserRole currentRole))
            {
                MessageBox.Show("Could not determine current user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (userId == _currentAdmin.UserId)
            {
                MessageBox.Show("You cannot change your own role.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Using Enum for comparison
            if (currentRole == UserRole.Admin)
            {
                int adminCount = _context.Users.Count(u => u.Role == UserRole.Admin);
                if (adminCount <= 1 && newRole != UserRole.Admin)
                {
                    MessageBox.Show("Cannot change the role of the last remaining admin.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            var confirm = MessageBox.Show($"Are you sure you want to change the role of '{userName}' to '{newRoleString}'?", "Confirm Role Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var userToUpdate = _context.Users.Find(userId);
                    if (userToUpdate != null)
                    {
                        // Setting role using Enum value
                        userToUpdate.Role = newRole;

                        if (newRole == UserRole.Provider)
                        {
                            userToUpdate.IsApproved = false;
                        }
                        // Using Enum for comparison
                        if (currentRole == UserRole.Provider && newRole != UserRole.Provider)
                        {
                            var providerServices = _context.ProviderServices.Where(ps => ps.ProviderId == userId);
                            _context.ProviderServices.RemoveRange(providerServices);
                        }

                        _context.SaveChanges();
                        MessageBox.Show($"Role for user '{userName}' changed to '{newRoleString}'.", "Role Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllUsers();
                        comboNewRole.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Could not find the selected user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadAllUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error changing user role: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearEditUserPanel()
        {
            lblSelectedUserId.Text = "0";
            txtEditUserName.Clear();
            txtEditUserPhone.Clear();
            txtNewPassword.Clear();
            btnSaveUserDetails.Enabled = false;
            btnResetPassword.Enabled = false;
        }

        private void btnLoadUserDetails_Click(object? sender, EventArgs e)
        {
            if (dgvAllUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user from the grid first.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearEditUserPanel();
                return;
            }
            if (!(dgvAllUsers.SelectedRows[0].Cells["UserId"]?.Value is int userId))
            {
                ClearEditUserPanel();
                return;
            }

            try
            {
                var userToEdit = _context.Users.Find(userId);
                if (userToEdit != null)
                {
                    lblSelectedUserId.Text = userToEdit.UserId.ToString();
                    userToEdit.Name ??= string.Empty;
                    txtEditUserName.Text = userToEdit.Name;
                    userToEdit.Phone ??= string.Empty;
                    txtEditUserPhone.Text = userToEdit.Phone;
                    txtNewPassword.Clear();

                    btnSaveUserDetails.Enabled = true;
                    btnResetPassword.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Could not find the selected user details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearEditUserPanel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearEditUserPanel();
            }
        }

        private void btnSaveUserDetails_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(lblSelectedUserId.Text, out int userId) || userId <= 0)
            {
                MessageBox.Show("Please load a user's details first using the 'Load Details' button.", "No User Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEditUserName.Text) || string.IsNullOrWhiteSpace(txtEditUserPhone.Text))
            {
                MessageBox.Show("Name and Phone Number cannot be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var userToUpdate = _context.Users.Find(userId);
                if (userToUpdate != null)
                {
                    bool changed = false;
                    if (userToUpdate.Name != txtEditUserName.Text.Trim())
                    {
                        userToUpdate.Name = txtEditUserName.Text.Trim();
                        changed = true;
                    }
                    if (userToUpdate.Phone != txtEditUserPhone.Text.Trim())
                    {
                        userToUpdate.Phone = txtEditUserPhone.Text.Trim();
                        changed = true;
                    }

                    if (changed)
                    {
                        _context.SaveChanges();
                        MessageBox.Show($"Details for user '{userToUpdate.Name}' updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAllUsers();
                    }
                    else
                    {
                        MessageBox.Show("No changes detected in Name or Phone.", "No Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Could not find the user to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearEditUserPanel();
                    LoadAllUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnResetPassword_Click(object? sender, EventArgs e)
        {
            if (!int.TryParse(lblSelectedUserId.Text, out int userId) || userId <= 0)
            {
                MessageBox.Show("Please load a user's details first using the 'Load Details' button.", "No User Loaded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter the new password in the 'Reset Password To' field.", "New Password Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userId == _currentAdmin.UserId)
            {
                MessageBox.Show("You cannot reset your own password using this function.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPassword = txtNewPassword.Text;
            string? userName = txtEditUserName.Text;

            var confirm = MessageBox.Show($"Are you sure you want to reset the password for '{userName}'?", "Confirm Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var userToUpdate = _context.Users.Find(userId);
                    if (userToUpdate != null)
                    {
                        userToUpdate.Password = newPassword;
                        _context.SaveChanges();
                        MessageBox.Show($"Password for user '{userName}' has been reset successfully.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNewPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Could not find the user to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearEditUserPanel();
                        LoadAllUsers();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error resetting password: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadServices()
        {
            try
            {
                var services = _context.Services
                    .OrderBy(s => s.Name)
                    .Select(s => new {
                        s.ServiceId,
                        s.Name,
                        s.Category,
                        Price = s.BasePrice,
                        s.Description
                    })
                    .ToList();

                dgvServices.DataSource = null;
                dgvServices.DataSource = services;

                if (dgvServices.Columns["ServiceId"] != null) { dgvServices.Columns["ServiceId"].Visible = false; }
                if (dgvServices.Columns["Name"] != null) dgvServices.Columns["Name"].FillWeight = 150;
                if (dgvServices.Columns["Category"] != null) dgvServices.Columns["Category"].FillWeight = 100;
                if (dgvServices.Columns["Price"] != null)
                {
                    dgvServices.Columns["Price"].HeaderText = "Base Price";
                    dgvServices.Columns["Price"].DefaultCellStyle.Format = "N0";
                    dgvServices.Columns["Price"].FillWeight = 80;
                }
                if (dgvServices.Columns["Description"] != null) dgvServices.Columns["Description"].FillWeight = 250;

                dgvServices.ClearSelection();
                ClearServiceForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading services: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvServices_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count > 0)
            {
                var selectedRow = dgvServices.SelectedRows[0];
                lblEditingServiceId.Text = selectedRow.Cells["ServiceId"]?.Value?.ToString() ?? "0";
                txtServiceName.Text = selectedRow.Cells["Name"]?.Value?.ToString() ?? "";
                txtServiceDescription.Text = selectedRow.Cells["Description"]?.Value?.ToString() ?? "";
                txtServiceCategory.Text = selectedRow.Cells["Category"]?.Value?.ToString() ?? "";

                if (selectedRow.Cells["Price"]?.Value is decimal price)
                {
                    txtServicePrice.Text = price.ToString("F2");
                }
                else
                {
                    txtServicePrice.Text = "";
                }

                btnSaveUpdateService.Text = "Update Service";
            }
        }

        private void ClearServiceForm()
        {
            txtServiceName.Clear();
            txtServiceDescription.Clear();
            txtServiceCategory.Clear();
            txtServicePrice.Clear();
            lblEditingServiceId.Text = "0";
            btnSaveUpdateService.Text = "Save New Service";
            if (dgvServices.Rows.Count > 0 && dgvServices.SelectedRows.Count > 0)
            {
                dgvServices.ClearSelection();
            }
        }

        private void btnClearServiceForm_Click(object? sender, EventArgs e)
        {
            ClearServiceForm();
        }

        private void btnSaveUpdateService_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServiceName.Text) ||
                string.IsNullOrWhiteSpace(txtServicePrice.Text))
            {
                MessageBox.Show("Service Name and Base Price are required.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtServicePrice.Text, NumberStyles.Currency, CultureInfo.InvariantCulture, out decimal basePrice) || basePrice < 0)
            {
                if (!decimal.TryParse(txtServicePrice.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out basePrice) || basePrice < 0)
                {
                    MessageBox.Show("Please enter a valid non-negative Base Price.", "Invalid Price", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!int.TryParse(lblEditingServiceId.Text, out int editingServiceId))
            {
                MessageBox.Show("Invalid service selection state.", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEditing = editingServiceId > 0;

            try
            {
                if (isEditing)
                {
                    var serviceToUpdate = _context.Services.Find(editingServiceId);
                    if (serviceToUpdate != null)
                    {
                        serviceToUpdate.Name = txtServiceName.Text.Trim();
                        serviceToUpdate.Description = txtServiceDescription.Text.Trim();
                        serviceToUpdate.Category = txtServiceCategory.Text.Trim();
                        serviceToUpdate.BasePrice = basePrice;

                        _context.SaveChanges();
                        MessageBox.Show($"Service '{serviceToUpdate.Name}' updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadServices();
                    }
                    else
                    {
                        MessageBox.Show("Could not find the service to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        LoadServices();
                    }
                }
                else
                {
                    var newService = new Service
                    {
                        Name = txtServiceName.Text.Trim(),
                        Description = txtServiceDescription.Text.Trim(),
                        Category = txtServiceCategory.Text.Trim(),
                        BasePrice = basePrice
                    };
                    _context.Services.Add(newService);
                    _context.SaveChanges();
                    MessageBox.Show($"Service '{newService.Name}' added successfully!", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving the service: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteService_Click(object? sender, EventArgs e)
        {
            if (dgvServices.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a service to delete.", "No Service Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(dgvServices.SelectedRows[0].Cells["ServiceId"]?.Value is int serviceId))
            {
                MessageBox.Show("Could not determine the selected service ID.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var serviceToDelete = _context.Services.Find(serviceId);
                if (serviceToDelete == null)
                {
                    MessageBox.Show("Could not find the selected service.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    LoadServices();
                    return;
                }

                // Using Enum for status check
                bool hasActiveBookings = _context.Bookings.Any(b => b.ServiceId == serviceId &&
                                                               (b.Status == BookingStatus.Pending || b.Status == BookingStatus.InProgress));
                if (hasActiveBookings)
                {
                    MessageBox.Show($"Cannot delete service '{serviceToDelete.Name}' because it is associated with active or pending bookings.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show($"Are you sure you want to permanently delete the service '{serviceToDelete.Name}'?\nThis cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    string serviceName = serviceToDelete.Name ?? "Service";

                    var providerLinks = _context.ProviderServices.Where(ps => ps.ServiceId == serviceId);
                    _context.ProviderServices.RemoveRange(providerLinks);

                    _context.Services.Remove(serviceToDelete);
                    _context.SaveChanges();

                    MessageBox.Show($"Service '{serviceName}' deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadServices();
                }
            }
            catch (DbUpdateException dbEx)
            {
                MessageBox.Show($"Could not delete service. There might be other related records preventing deletion.\n\nDetails: {dbEx.InnerException?.Message ?? dbEx.Message}", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadServices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the service: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogoutAdmin_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDashboardForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _context?.Dispose();
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
        }
    }
}