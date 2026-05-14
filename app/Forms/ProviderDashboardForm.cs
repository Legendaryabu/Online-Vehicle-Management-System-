using Microsoft.EntityFrameworkCore;
using OVSMS_Desktop.Data;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace OVSMS_Desktop.Forms
{
    public partial class ProviderDashboardForm : Form
    {
        private readonly User _currentProvider;
        private readonly AppDbContext _context;
        private readonly NumberFormatInfo LkrFormat;

        // Status Colors 
        private readonly Color _pendingBackColor = Color.FromArgb(255, 253, 224);
        private readonly Color _pendingForeColor = Color.FromArgb(180, 130, 0);
        private readonly Color _inProgressBackColor = Color.FromArgb(220, 240, 255);
        private readonly Color _inProgressForeColor = Color.FromArgb(0, 0, 139);
        private readonly Color _completedBackColor = Color.FromArgb(220, 255, 220);
        private readonly Color _completedForeColor = Color.FromArgb(0, 100, 0);
        private readonly Color _cancelledBackColor = Color.FromArgb(240, 240, 240);
        private readonly Color _cancelledForeColor = Color.FromArgb(100, 100, 100);

        // Payment Status Colors
        private readonly Color _paidBackColor = Color.FromArgb(220, 255, 220);
        private readonly Color _paidForeColor = Color.FromArgb(0, 100, 0);
        private readonly Color _unpaidBackColor = Color.FromArgb(255, 240, 230);
        private readonly Color _unpaidForeColor = Color.FromArgb(192, 0, 0);


        public ProviderDashboardForm(User provider)
        {
            InitializeComponent();
            _currentProvider = provider ?? throw new ArgumentNullException(nameof(provider));
            _context = new AppDbContext();

            lblWelcomeProvider.Text = $"Welcome, {_currentProvider.Name ?? "Provider"}!";
            panelBookingDetails.Visible = false;

            LkrFormat = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            LkrFormat.CurrencySymbol = "Rs.";
            LkrFormat.CurrencyGroupSeparator = ",";
            LkrFormat.CurrencyDecimalSeparator = ".";
            LkrFormat.CurrencyDecimalDigits = 2;
        }

        private void ProviderDashboardForm_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadBookingRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tabControlProvider_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                if (tabControlProvider.SelectedTab == tabBookings)
                {
                    LoadBookingRequests();
                }
                else if (tabControlProvider.SelectedTab == tabMyServices)
                {
                    LoadMyServices();
                }
                else if (tabControlProvider.SelectedTab == tabSchedule)
                {
                    LoadSchedule();
                }
                // --- Completed Bookings Tab ---
                else if (tabControlProvider.SelectedTab == tabCompletedBookings)
                {
                    LoadCompletedBookings();
                }
                // --- Profile Tab ---
                else if (tabControlProvider.SelectedTab == tabProviderProfile)
                {
                    LoadProviderProfile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading tab data: {ex.Message}", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- Booking Requests Tab ---
        private void LoadBookingRequests()
        {
            try
            {
                var bookingRequests = _context.Bookings
                    .Where(b => b.ProviderId == _currentProvider.UserId &&
                                b.Status != BookingStatus.Completed &&
                                b.Status != BookingStatus.Cancelled)
                    .Include(b => b.User).Include(b => b.Vehicle).Include(b => b.Service)
                    .OrderBy(b => b.BookingDate)
                    .Select(b => new {
                        b.BookingId,
                        RequestDate = b.BookingDate.ToString("yyyy-MM-dd"),
                        Service = b.Service != null ? b.Service.Name : "N/A",
                        Vehicle = b.Vehicle != null ? b.Vehicle.DisplayName : "N/A",
                        Customer = b.User != null ? b.User.Name : "N/A",
                        CustomerPhone = b.User != null ? b.User.Phone : "N/A",
                        Status = b.Status.ToString(),
                        Payment = b.PaymentStatus.ToString()
                    }).ToList();
                dgvBookingRequests.DataSource = null; dgvBookingRequests.DataSource = bookingRequests;

                if (dgvBookingRequests.Columns["BookingId"] != null) { dgvBookingRequests.Columns["BookingId"].Visible = false; }
                if (dgvBookingRequests.Columns["RequestDate"] != null) dgvBookingRequests.Columns["RequestDate"].FillWeight = 100;
                if (dgvBookingRequests.Columns["Service"] != null) dgvBookingRequests.Columns["Service"].FillWeight = 150;
                if (dgvBookingRequests.Columns["Vehicle"] != null) dgvBookingRequests.Columns["Vehicle"].FillWeight = 150;
                if (dgvBookingRequests.Columns["Customer"] != null) dgvBookingRequests.Columns["Customer"].FillWeight = 120;
                if (dgvBookingRequests.Columns["CustomerPhone"] != null) dgvBookingRequests.Columns["CustomerPhone"].FillWeight = 100;
                if (dgvBookingRequests.Columns["Status"] != null) dgvBookingRequests.Columns["Status"].FillWeight = 80;

                if (dgvBookingRequests.Columns["Payment"] != null)
                {
                    dgvBookingRequests.Columns["Payment"].HeaderText = "Payment Status";
                    dgvBookingRequests.Columns["Payment"].FillWeight = 80;
                }

                if (dgvBookingRequests.Rows.Count > 0) { dgvBookingRequests.ClearSelection(); }
                panelBookingDetails.Visible = false;
            }
            catch (Exception ex) { MessageBox.Show($"Error loading booking requests: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvBookingRequests_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvBookingRequests.SelectedRows.Count > 0)
            {
                if (!(dgvBookingRequests.SelectedRows[0].Cells["BookingId"]?.Value is int bookingId))
                {
                    panelBookingDetails.Visible = false;
                    return;
                }

                try
                {
                    var selectedBooking = _context.Bookings
                        .Include(b => b.User)
                        .Include(b => b.Vehicle)
                        .Include(b => b.Service)
                        .FirstOrDefault(b => b.BookingId == bookingId);

                    if (selectedBooking != null)
                    {
                        lblDetailCustomerName.Text = selectedBooking.User?.Name ?? "N/A";
                        lblDetailCustomerPhone.Text = selectedBooking.User?.Phone ?? "N/A";
                        lblDetailVehicle.Text = selectedBooking.Vehicle?.DisplayName ?? "N/A";
                        lblDetailServiceDesc.Text = selectedBooking.Service?.Name ?? "N/A";
                        lblDetailBookingDate.Text = selectedBooking.BookingDate.ToString("yyyy-MM-dd");
                        lblDetailStatus.Text = selectedBooking.Status.ToString();
                        lblDetailPaymentStatus.Text = selectedBooking.PaymentStatus.ToString();

                        if (selectedBooking.PaymentStatus == PaymentStatus.Paid)
                        {
                            lblDetailPaymentStatus.ForeColor = _paidForeColor;
                        }
                        else
                        {
                            lblDetailPaymentStatus.ForeColor = _unpaidForeColor;
                        }

                        panelBookingDetails.Visible = true;
                    }
                    else
                    {
                        panelBookingDetails.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading booking details: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    panelBookingDetails.Visible = false;
                }
            }
            else
            {
                panelBookingDetails.Visible = false;
            }
        }

        private void btnAcceptBooking_Click(object? sender, EventArgs e)
        {
            if (dgvBookingRequests.SelectedRows.Count == 0 || !(dgvBookingRequests.SelectedRows[0].Cells["BookingId"]?.Value is int bookingId))
            { MessageBox.Show("Please select a pending booking to accept.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string currentStatusString = dgvBookingRequests.SelectedRows[0].Cells["Status"]?.Value?.ToString() ?? "";

            if (!currentStatusString.Equals(BookingStatus.Pending.ToString(), StringComparison.OrdinalIgnoreCase))
            { MessageBox.Show("Only 'Pending' bookings can be accepted.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            try
            {
                var booking = _context.Bookings.Find(bookingId);
                if (booking != null && booking.ProviderId == _currentProvider.UserId)
                {
                    booking.Status = BookingStatus.InProgress; _context.SaveChanges();
                    MessageBox.Show("Booking status set to 'In Progress'.", "Booking Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadBookingRequests();
                }
                else { MessageBox.Show("Booking not found or not assigned to you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); LoadBookingRequests(); }
            }
            catch (Exception ex) { MessageBox.Show($"Error accepting booking: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnCompleteBooking_Click(object? sender, EventArgs e)
        {
            if (dgvBookingRequests.SelectedRows.Count == 0 || !(dgvBookingRequests.SelectedRows[0].Cells["BookingId"]?.Value is int bookingId))
            { MessageBox.Show("Please select a booking to complete.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            string currentStatusString = dgvBookingRequests.SelectedRows[0].Cells["Status"]?.Value?.ToString() ?? "";
            string paymentStatusString = dgvBookingRequests.SelectedRows[0].Cells["Payment"]?.Value?.ToString() ?? "";

            if (!currentStatusString.Equals(BookingStatus.InProgress.ToString(), StringComparison.OrdinalIgnoreCase))
            { MessageBox.Show("Only bookings 'In Progress' can be completed.", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (paymentStatusString.Equals(PaymentStatus.Unpaid.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                var confirm = MessageBox.Show("This booking is still marked 'Unpaid'.\nAre you sure you want to mark it as completed?\n(This is usually done after receiving cash payment.)", "Confirm Completion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.No)
                {
                    return; // Stop execution
                }
            }

            try
            {
                var booking = _context.Bookings.Find(bookingId);
                if (booking != null && booking.ProviderId == _currentProvider.UserId)
                {
                    booking.Status = BookingStatus.Completed;

                    // Update payment status and create payment record if previously Unpaid
                    if (booking.PaymentStatus == PaymentStatus.Unpaid)
                    {
                        booking.PaymentStatus = PaymentStatus.Paid;
                        _context.Payments.Add(new Payment
                        {
                            Amount = booking.Price,
                            PaymentDate = DateTime.UtcNow,
                            PaymentMethod = PaymentMethod.Cash,
                            TransactionId = $"CASH_BY_{_currentProvider.Name}",
                            BookingId = booking.BookingId
                        });
                    }
                    _context.SaveChanges();
                    MessageBox.Show("Booking marked as completed!", "Booking Completed", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadBookingRequests();
                }
                else { MessageBox.Show("Booking not found or not assigned to you.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); LoadBookingRequests(); }
            }
            catch (Exception ex) { MessageBox.Show($"Error completing booking: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvBookingRequests_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            Font? baseFont = e.CellStyle?.Font ?? dgvBookingRequests.Font ?? SystemFonts.DefaultFont;

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvBookingRequests.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";
                if (e.CellStyle == null) return; e.CellStyle.Font = new Font(baseFont, FontStyle.Regular);

                if (status.Equals(BookingStatus.Pending.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _pendingBackColor; e.CellStyle.ForeColor = _pendingForeColor; e.CellStyle.Font = new Font(baseFont, FontStyle.Bold); }
                else if (status.Equals(BookingStatus.InProgress.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _inProgressBackColor; e.CellStyle.ForeColor = _inProgressForeColor; e.CellStyle.Font = new Font(baseFont, FontStyle.Bold); }
                else if (status.Equals(BookingStatus.Completed.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _completedBackColor; e.CellStyle.ForeColor = _completedForeColor; }
                else if (status.Equals(BookingStatus.Cancelled.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _cancelledBackColor; e.CellStyle.ForeColor = _cancelledForeColor; e.CellStyle.Font = new Font(baseFont, FontStyle.Italic); }
                else
                { e.CellStyle.BackColor = dgvBookingRequests.DefaultCellStyle.BackColor; e.CellStyle.ForeColor = dgvBookingRequests.DefaultCellStyle.ForeColor; }

                e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                e.CellStyle.SelectionForeColor = SystemColors.HighlightText;
            }
            else if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvBookingRequests.Columns[e.ColumnIndex].Name == "Payment" && e.Value != null)
            {
                string paymentStatus = e.Value.ToString() ?? "";
                if (e.CellStyle == null) return;

                if (paymentStatus.Equals(PaymentStatus.Paid.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = _paidBackColor;
                    e.CellStyle.ForeColor = _paidForeColor;
                }
                else if (paymentStatus.Equals(PaymentStatus.Unpaid.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = _unpaidBackColor;
                    e.CellStyle.ForeColor = _unpaidForeColor;
                    e.CellStyle.Font = new Font(baseFont, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.BackColor = dgvBookingRequests.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = dgvBookingRequests.DefaultCellStyle.ForeColor;
                }
                e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                e.CellStyle.SelectionForeColor = SystemColors.HighlightText;
            }
        }

        // --- My Services Tab ---
        private void LoadMyServices() { try { var allServices = _context.Services.OrderBy(s => s.Name).ToList(); var offeredServiceIds = _context.ProviderServices.Where(ps => ps.ProviderId == _currentProvider.UserId).Select(ps => ps.ServiceId).ToHashSet(); clbServices.DataSource = null; clbServices.Items.Clear(); clbServices.DataSource = allServices; clbServices.DisplayMember = "Name"; clbServices.ValueMember = "ServiceId"; for (int i = 0; i < clbServices.Items.Count; i++) { var service = (Service?)clbServices.Items[i]; if (service != null && offeredServiceIds.Contains(service.ServiceId)) { clbServices.SetItemChecked(i, true); } } } catch (Exception ex) { MessageBox.Show($"Error loading offered services: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); } }
        private void btnSaveMyServices_Click(object? sender, EventArgs e)
        {
            try
            {
                var currentlyCheckedServiceIds = clbServices.CheckedItems
                                                            .OfType<Service>()
                                                            .Select(s => s.ServiceId)
                                                            .ToHashSet();

                var previouslyOfferedServiceIds = _context.ProviderServices
                                                          .Where(ps => ps.ProviderId == _currentProvider.UserId)
                                                          .Select(ps => ps.ServiceId)
                                                          .ToHashSet();

                var servicesToAdd = currentlyCheckedServiceIds.Except(previouslyOfferedServiceIds).ToList();
                var servicesToRemoveIds = previouslyOfferedServiceIds.Except(currentlyCheckedServiceIds).ToList();

                var providerServicesToRemove = _context.ProviderServices
                                                       .Where(ps => ps.ProviderId == _currentProvider.UserId &&
                                                                    servicesToRemoveIds.Contains(ps.ServiceId))
                                                       .ToList();

                // (CREATE)
                if (servicesToAdd.Any())
                {
                    foreach (var serviceId in servicesToAdd)
                    {
                        _context.ProviderServices.Add(new ProviderService
                        {
                            ProviderId = _currentProvider.UserId,
                            ServiceId = serviceId
                        });
                    }
                }

                // (DELETE)
                if (providerServicesToRemove.Any())
                {
                    _context.ProviderServices.RemoveRange(providerServicesToRemove);
                }

                // (SAVE)
                if (servicesToAdd.Any() || providerServicesToRemove.Any())
                {
                    _context.SaveChanges();
                    MessageBox.Show("Offered services updated!", "Services Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No changes were made.", "No Changes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving services: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Schedule Tab ---
        private void LoadSchedule()
        {
            try
            {
                // Filter requests that are Pending or In Progress
                var upcomingBookings = _context.Bookings
                    .Where(b => b.ProviderId == _currentProvider.UserId &&
                                 (b.Status == BookingStatus.Pending || b.Status == BookingStatus.InProgress))
                    .Include(b => b.User)
                    .Include(b => b.Vehicle)
                    .Include(b => b.Service)
                    .OrderBy(b => b.BookingDate)
                    .Select(b => new {
                        Date = b.BookingDate.ToString("yyyy-MM-dd"),
                        Service = b.Service != null ? b.Service.Name : "N/A",
                        Customer = b.User != null ? b.User.Name : "N/A",
                        Vehicle = b.Vehicle != null ? b.Vehicle.DisplayName : "N/A",
                        Status = b.Status.ToString(),
                        Payment = b.PaymentStatus.ToString()
                    })
                    .ToList();

                dgvSchedule.DataSource = null;
                dgvSchedule.DataSource = upcomingBookings;

                if (dgvSchedule.Columns["Date"] != null) dgvSchedule.Columns["Date"].FillWeight = 100;
                if (dgvSchedule.Columns["Service"] != null) dgvSchedule.Columns["Service"].FillWeight = 150;
                if (dgvSchedule.Columns["Customer"] != null) dgvSchedule.Columns["Customer"].FillWeight = 120;
                if (dgvSchedule.Columns["Vehicle"] != null) dgvSchedule.Columns["Vehicle"].FillWeight = 150;
                if (dgvSchedule.Columns["Status"] != null) dgvSchedule.Columns["Status"].FillWeight = 80;
                if (dgvSchedule.Columns["Payment"] != null)
                {
                    dgvSchedule.Columns["Payment"].HeaderText = "Payment Status";
                    dgvSchedule.Columns["Payment"].FillWeight = 80;
                }


                if (dgvSchedule.Rows.Count > 0)
                {
                    dgvSchedule.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading schedule: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSchedule_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            Font? baseFont = e.CellStyle?.Font ?? dgvSchedule.Font ?? SystemFonts.DefaultFont;

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSchedule.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";
                if (e.CellStyle == null) return; e.CellStyle.Font = new Font(baseFont, FontStyle.Regular);

                if (status.Equals(BookingStatus.Pending.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _pendingBackColor; e.CellStyle.ForeColor = _pendingForeColor; e.CellStyle.Font = new Font(baseFont, FontStyle.Bold); }
                else if (status.Equals(BookingStatus.InProgress.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _inProgressBackColor; e.CellStyle.ForeColor = _inProgressForeColor; e.CellStyle.Font = new Font(baseFont, FontStyle.Bold); }
                else
                { e.CellStyle.BackColor = dgvSchedule.DefaultCellStyle.BackColor; e.CellStyle.ForeColor = dgvSchedule.DefaultCellStyle.ForeColor; }

                e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                e.CellStyle.SelectionForeColor = SystemColors.HighlightText;
            }
            else if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvSchedule.Columns[e.ColumnIndex].Name == "Payment" && e.Value != null)
            {
                string paymentStatus = e.Value.ToString() ?? "";
                if (e.CellStyle == null) return;

                if (paymentStatus.Equals(PaymentStatus.Paid.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = _paidBackColor;
                    e.CellStyle.ForeColor = _paidForeColor;
                }
                else if (paymentStatus.Equals(PaymentStatus.Unpaid.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = _unpaidBackColor;
                    e.CellStyle.ForeColor = _unpaidForeColor;
                    e.CellStyle.Font = new Font(baseFont, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.BackColor = dgvSchedule.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = dgvSchedule.DefaultCellStyle.ForeColor;
                }
                e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                e.CellStyle.SelectionForeColor = SystemColors.HighlightText;
            }
        }

        // --- Completed Bookings Tab Section ---
        private void LoadCompletedBookings()
        {
            try
            {
                var completedBookings = _context.Bookings
                    .Where(b => b.ProviderId == _currentProvider.UserId && b.Status == BookingStatus.Completed)
                    .Include(b => b.User)
                    .Include(b => b.Vehicle)
                    .Include(b => b.Service)
                    .OrderByDescending(b => b.BookingDate) 
                    .Select(b => new {
                        b.BookingId,
                        CompletionDate = b.BookingDate.ToString("yyyy-MM-dd"),
                        Service = b.Service != null ? b.Service.Name : "N/A",
                        Vehicle = b.Vehicle != null ? b.Vehicle.DisplayName : "N/A",
                        Customer = b.User != null ? b.User.Name : "N/A",
                        Price = b.Price.ToString("C", LkrFormat),
                        Payment = b.PaymentStatus.ToString()
                    })
                    .ToList();

                dgvCompletedBookings.DataSource = null;
                dgvCompletedBookings.DataSource = completedBookings;

                if (dgvCompletedBookings.Columns["BookingId"] != null) { dgvCompletedBookings.Columns["BookingId"].Visible = false; }

                if (dgvCompletedBookings.Columns["CompletionDate"] != null) dgvCompletedBookings.Columns["CompletionDate"].HeaderText = "Date";
                if (dgvCompletedBookings.Columns["CompletionDate"] != null) dgvCompletedBookings.Columns["CompletionDate"].FillWeight = 100;
                if (dgvCompletedBookings.Columns["Service"] != null) dgvCompletedBookings.Columns["Service"].FillWeight = 150;
                if (dgvCompletedBookings.Columns["Vehicle"] != null) dgvCompletedBookings.Columns["Vehicle"].FillWeight = 150;
                if (dgvCompletedBookings.Columns["Customer"] != null) dgvCompletedBookings.Columns["Customer"].FillWeight = 120;
                if (dgvCompletedBookings.Columns["Price"] != null)
                {
                    dgvCompletedBookings.Columns["Price"].DefaultCellStyle.Format = "C";
                    dgvCompletedBookings.Columns["Price"].DefaultCellStyle.FormatProvider = LkrFormat;
                    dgvCompletedBookings.Columns["Price"].FillWeight = 80;
                }
                if (dgvCompletedBookings.Columns["Payment"] != null)
                {
                    dgvCompletedBookings.Columns["Payment"].HeaderText = "Payment Status";
                    dgvCompletedBookings.Columns["Payment"].FillWeight = 80;
                }

                if (dgvCompletedBookings.Rows.Count > 0)
                {
                    dgvCompletedBookings.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading completed bookings: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCompletedBookings_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            // Apply color coding for Payment Status in the completed bookings grid
            Font? baseFont = e.CellStyle?.Font ?? dgvCompletedBookings.Font ?? SystemFonts.DefaultFont;

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvCompletedBookings.Columns[e.ColumnIndex].Name == "Payment" && e.Value != null)
            {
                string paymentStatus = e.Value.ToString() ?? "";
                if (e.CellStyle == null) return;

                if (paymentStatus.Equals(PaymentStatus.Paid.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = _paidBackColor;
                    e.CellStyle.ForeColor = _paidForeColor;
                }
                else if (paymentStatus.Equals(PaymentStatus.Unpaid.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = _unpaidBackColor;
                    e.CellStyle.ForeColor = _unpaidForeColor;
                    e.CellStyle.Font = new Font(baseFont, FontStyle.Bold);
                }
                else
                {
                    e.CellStyle.BackColor = dgvCompletedBookings.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = dgvCompletedBookings.DefaultCellStyle.ForeColor;
                }
                e.CellStyle.SelectionBackColor = SystemColors.Highlight;
                e.CellStyle.SelectionForeColor = SystemColors.HighlightText;
            }
        }
        // --- End Completed Bookings Tab Section ---

        // --- Profile Tab ---
        private void LoadProviderProfile()
        {
            try
            {
                var provider = _context.Users.Find(_currentProvider.UserId);
                if (provider != null)
                {
                    txtProfileNameProvider.Text = provider.Name ?? "";
                    txtProfilePhoneProvider.Text = provider.Phone ?? "";
                }
                else {}
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading provider profile: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdateProviderProfile_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProfileNameProvider.Text) || string.IsNullOrWhiteSpace(txtProfilePhoneProvider.Text))
            { MessageBox.Show("Name and Phone Number cannot be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            try
            {
                var providerToUpdate = _context.Users.Find(_currentProvider.UserId);
                if (providerToUpdate != null)
                {
                    bool changed = false;
                    if (providerToUpdate.Name != txtProfileNameProvider.Text) { providerToUpdate.Name = txtProfileNameProvider.Text; changed = true; }
                    if (providerToUpdate.Phone != txtProfilePhoneProvider.Text) { providerToUpdate.Phone = txtProfilePhoneProvider.Text; changed = true; }

                    if (changed)
                    {
                        _context.SaveChanges();
                        _currentProvider.Name = providerToUpdate.Name;
                        _currentProvider.Phone = providerToUpdate.Phone;
                        lblWelcomeProvider.Text = $"Welcome, {_currentProvider.Name ?? "Provider"}!";
                        MessageBox.Show("Profile updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("No changes detected.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else {}
            }
            catch (Exception ex) { MessageBox.Show($"Error updating profile: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // --- General ---
        private void btnContactAdmin_Click(object? sender, EventArgs e)
        {
            using (var supportForm = new ContactSupportForm())
            {
                supportForm.ShowDialog(this);
            }
        }

        private void btnLogoutProvider_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ProviderDashboardForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _context?.Dispose();
            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
        }
    }
}