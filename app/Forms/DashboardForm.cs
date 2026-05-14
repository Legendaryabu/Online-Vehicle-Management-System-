using Microsoft.EntityFrameworkCore;
using OVSMS_Desktop.Data;
using OVSMS_Desktop.Controls;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace OVSMS_Desktop.Forms
{
    public partial class DashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly AppDbContext _context;
        private readonly NumberFormatInfo LkrFormat;

        // Status Colors
        private readonly Color _pendingBackColor = Color.FromArgb(255, 253, 224);
        private readonly Color _pendingForeColor = Color.FromArgb(180, 130, 0);
        private readonly Color _completedBackColor = Color.FromArgb(220, 255, 220);
        private readonly Color _completedForeColor = Color.FromArgb(0, 100, 0);
        private readonly Color _cancelledBackColor = Color.FromArgb(240, 240, 240);
        private readonly Color _cancelledForeColor = Color.FromArgb(100, 100, 100);

        // Payment Status Colors
        private readonly Color _paidBackColor = Color.FromArgb(220, 255, 220);
        private readonly Color _paidForeColor = Color.FromArgb(0, 100, 0);
        private readonly Color _unpaidBackColor = Color.FromArgb(255, 240, 230);
        private readonly Color _unpaidForeColor = Color.FromArgb(192, 0, 0);


        public DashboardForm(User user)
        {
            InitializeComponent();
            _currentUser = user ?? throw new ArgumentNullException(nameof(user));
            _context = new AppDbContext();
            lblWelcome.Text = $"Welcome back, {_currentUser.Name ?? "User"}!";
            lblEditingVehicleId.Text = "0";
            btnSaveUpdateVehicle.Text = "Save New Vehicle";

            LkrFormat = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            LkrFormat.CurrencySymbol = "Rs.";
            LkrFormat.CurrencyGroupSeparator = ",";
            LkrFormat.CurrencyDecimalSeparator = ".";
            LkrFormat.CurrencyDecimalDigits = 2;

            PopulateVehicleTypes();
        }

        private void DashboardForm_Load(object? sender, EventArgs e)
        {
            try
            {
                LoadServices();
                LoadVehicles();
                LoadBookings();
                LoadProfile();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateVehicleTypes()
        {
            var vehicleTypes = new[] { "Car", "Bike", "Three-Wheeler", "Van", "SUV", "Truck", "Other" };
            comboVehicleType.Items.AddRange(vehicleTypes);
            comboVehicleType.SelectedIndex = -1;
        }


        // --- Services Tab ---
        private void LoadServices()
        {
            try
            {
                servicesFlowPanel.Controls.Clear();
                var services = _context.Services.ToList();
                foreach (var service in services)
                {
                    var card = new ServiceCardControl(service, _currentUser, LkrFormat);
                    card.BookingMade += (s, args) => LoadBookings(); servicesFlowPanel.Controls.Add(card);
                }
            }
            catch (Exception ex) { MessageBox.Show($"Error loading services: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        // --- Vehicles Tab ---
        private void LoadVehicles()
        {
            try
            {
                var vehicles = _context.Vehicles
                    .Where(v => v.UserId == _currentUser.UserId)
                    .Select(v => new {
                        v.VehicleId,
                        v.Make,
                        v.Model,
                        v.Year,
                        Type = v.VehicleType,
                        RegistrationNumber = v.RegistrationNumber
                    })
                    .ToList();

                dgvVehicles.DataSource = null;
                dgvVehicles.DataSource = vehicles;

                if (dgvVehicles.Columns["VehicleId"] != null) { dgvVehicles.Columns["VehicleId"].Visible = false; }

                if (dgvVehicles.Columns["RegistrationNumber"] != null) { dgvVehicles.Columns["RegistrationNumber"].HeaderText = "Registration No"; }
                if (dgvVehicles.Columns["Type"] != null) { dgvVehicles.Columns["Type"].HeaderText = "Vehicle Type"; }

                dgvVehicles.ClearSelection();
                ClearVehicleForm();
            }
            catch (Exception ex) { MessageBox.Show($"Error loading vehicles: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void dgvVehicles_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count > 0)
            {
                var selectedRow = dgvVehicles.SelectedRows[0];
                lblEditingVehicleId.Text = selectedRow.Cells["VehicleId"]?.Value?.ToString() ?? "0";
                txtMake.Text = selectedRow.Cells["Make"]?.Value?.ToString() ?? "";
                txtModel.Text = selectedRow.Cells["Model"]?.Value?.ToString() ?? "";
                txtYear.Text = selectedRow.Cells["Year"]?.Value?.ToString() ?? "";
                txtRegNum.Text = selectedRow.Cells["RegistrationNumber"]?.Value?.ToString() ?? "";

                string vehicleType = selectedRow.Cells["Type"]?.Value?.ToString() ?? "";
                comboVehicleType.SelectedItem = vehicleType;

                btnSaveUpdateVehicle.Text = "Update Vehicle";
            }
        }

        private void ClearVehicleForm()
        {
            txtMake.Clear();
            txtModel.Clear();
            txtYear.Clear();
            txtRegNum.Clear();
            comboVehicleType.SelectedIndex = -1;
            lblEditingVehicleId.Text = "0";
            btnSaveUpdateVehicle.Text = "Save New Vehicle";
            if (dgvVehicles.Rows.Count > 0 && dgvVehicles.SelectedRows.Count > 0)
            {
                dgvVehicles.ClearSelection();
            }
        }

        private void btnClearVehicleForm_Click(object? sender, EventArgs e)
        {
            ClearVehicleForm();
        }

        private void btnSaveUpdateVehicle_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMake.Text) ||
                string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtYear.Text) ||
                string.IsNullOrWhiteSpace(txtRegNum.Text) ||
                comboVehicleType.SelectedItem == null)
            { MessageBox.Show("Please fill out all vehicle fields, including Vehicle Type.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!int.TryParse(txtYear.Text, out int year) || year < 1900 || year > DateTime.Now.Year + 1)
            { MessageBox.Show("Please enter a valid year.", "Invalid Year", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (!int.TryParse(lblEditingVehicleId.Text, out int editingVehicleId))
            { MessageBox.Show("Invalid vehicle selection state.", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            bool isEditing = editingVehicleId > 0;
            string selectedType = comboVehicleType.SelectedItem.ToString() ?? "Other";

            try
            {
                if (isEditing)
                {
                    var vehicleToUpdate = _context.Vehicles.Find(editingVehicleId);
                    if (vehicleToUpdate != null)
                    {
                        vehicleToUpdate.Make = txtMake.Text;
                        vehicleToUpdate.Model = txtModel.Text;
                        vehicleToUpdate.Year = year;
                        vehicleToUpdate.RegistrationNumber = txtRegNum.Text;
                        vehicleToUpdate.VehicleType = selectedType;
                        _context.SaveChanges();
                        MessageBox.Show($"Vehicle '{vehicleToUpdate.DisplayName}' updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadVehicles();
                    }
                    else { MessageBox.Show("Could not find the vehicle to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error); LoadVehicles(); }
                }
                else
                {
                    var newVehicle = new Vehicle
                    {
                        UserId = _currentUser.UserId,
                        Make = txtMake.Text,
                        Model = txtModel.Text,
                        Year = year,
                        RegistrationNumber = txtRegNum.Text,
                        VehicleType = selectedType
                    };
                    _context.Vehicles.Add(newVehicle); _context.SaveChanges();
                    MessageBox.Show($"Vehicle '{newVehicle.DisplayName}' added successfully!", "Add Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadVehicles();
                }
            }
            catch (Exception ex) { MessageBox.Show($"An error occurred while saving the vehicle: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnDeleteVehicle_Click(object? sender, EventArgs e)
        {
            if (dgvVehicles.SelectedRows.Count == 0 || dgvVehicles.SelectedRows[0].Cells["VehicleId"]?.Value == null)
            { MessageBox.Show("Please select a vehicle to delete.", "No Vehicle Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!(dgvVehicles.SelectedRows[0].Cells["VehicleId"]?.Value is int vehicleId))
            { MessageBox.Show("Could not determine the selected vehicle ID.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            try
            {
                var vehicle = _context.Vehicles.Find(vehicleId);
                if (vehicle == null) { MessageBox.Show("Could not find the selected vehicle.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning); LoadVehicles(); return; }

                bool hasBookings = _context.Bookings.Any(b => b.VehicleId == vehicleId &&
                                                             b.Status != BookingStatus.Cancelled &&
                                                             b.Status != BookingStatus.Completed);

                if (hasBookings) { MessageBox.Show($"Cannot delete '{vehicle.DisplayName}' because it has active/pending bookings.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                var confirm = MessageBox.Show($"Are you sure you want to delete '{vehicle.DisplayName}'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    string vehicleName = vehicle.DisplayName ?? "Vehicle"; _context.Vehicles.Remove(vehicle); _context.SaveChanges();
                    MessageBox.Show($"Vehicle '{vehicleName}' deleted successfully.", "Delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadVehicles();
                }
            }
            catch (Exception ex) { MessageBox.Show($"An error occurred while deleting the vehicle: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        // --- Bookings Tab ---
        private void LoadBookings()
        {
            try
            {
                var bookings = _context.Bookings.Where(b => b.UserId == _currentUser.UserId).OrderByDescending(b => b.BookingDate)
                    .Select(b => new {
                        b.BookingId,
                        Service = b.Service != null ? b.Service.Name : "N/A",
                        Vehicle = b.Vehicle != null ? b.Vehicle.DisplayName : "N/A",
                        Date = b.BookingDate.ToString("yyyy-MM-dd"),
                        Status = b.Status.ToString(),
                        Payment = b.PaymentStatus.ToString(),
                        Price = b.Price.ToString("C", LkrFormat)
                    }).ToList();
                dgvBookings.DataSource = null; dgvBookings.DataSource = bookings;

                if (dgvBookings.Columns["BookingId"] != null) { dgvBookings.Columns["BookingId"].Visible = false; }
                if (dgvBookings.Columns["Service"] != null) dgvBookings.Columns["Service"].FillWeight = 200;
                if (dgvBookings.Columns["Vehicle"] != null) dgvBookings.Columns["Vehicle"].FillWeight = 200;
                if (dgvBookings.Columns["Date"] != null) dgvBookings.Columns["Date"].FillWeight = 100;
                if (dgvBookings.Columns["Status"] != null) dgvBookings.Columns["Status"].FillWeight = 100;
                if (dgvBookings.Columns["Price"] != null)
                {
                    dgvBookings.Columns["Price"].DefaultCellStyle.Format = "C";
                    dgvBookings.Columns["Price"].DefaultCellStyle.FormatProvider = LkrFormat;
                    dgvBookings.Columns["Price"].FillWeight = 80;
                }
                if (dgvBookings.Columns["Payment"] != null) { dgvBookings.Columns["Payment"].FillWeight = 100; dgvBookings.Columns["Payment"].HeaderText = "Payment Status"; }

                if (dgvBookings.Rows.Count > 0) { dgvBookings.ClearSelection(); }
            }
            catch (Exception ex) { MessageBox.Show($"An error occurred while loading bookings: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void dgvBookings_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            Font? baseFont = e.CellStyle?.Font ?? dgvBookings.Font ?? SystemFonts.DefaultFont;

            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvBookings.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                string status = e.Value.ToString() ?? "";
                if (e.CellStyle == null) return;
                e.CellStyle.Font = new Font(baseFont, FontStyle.Regular);

                if (status.Equals(BookingStatus.Pending.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _pendingBackColor; e.CellStyle.ForeColor = _pendingForeColor; e.CellStyle.Font = new Font(baseFont, FontStyle.Bold); }
                else if (status.Equals(BookingStatus.InProgress.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = Color.LightBlue; e.CellStyle.ForeColor = Color.DarkBlue; e.CellStyle.Font = new Font(baseFont, FontStyle.Bold); }
                else if (status.Equals(BookingStatus.Completed.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _completedBackColor; e.CellStyle.ForeColor = _completedForeColor; }
                else if (status.Equals(BookingStatus.Cancelled.ToString(), StringComparison.OrdinalIgnoreCase))
                { e.CellStyle.BackColor = _cancelledBackColor; e.CellStyle.ForeColor = _cancelledForeColor; e.CellStyle.Font = new Font(baseFont, FontStyle.Italic); }
                else
                { e.CellStyle.BackColor = dgvBookings.DefaultCellStyle.BackColor; e.CellStyle.ForeColor = dgvBookings.DefaultCellStyle.ForeColor; }

                if (e.CellStyle.SelectionBackColor != SystemColors.Highlight) { e.CellStyle.SelectionBackColor = SystemColors.Highlight; }
                if (e.CellStyle.SelectionForeColor != SystemColors.HighlightText) { e.CellStyle.SelectionForeColor = SystemColors.HighlightText; }
            }
            else if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && dgvBookings.Columns[e.ColumnIndex].Name == "Payment" && e.Value != null)
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
                    e.CellStyle.BackColor = dgvBookings.DefaultCellStyle.BackColor;
                    e.CellStyle.ForeColor = dgvBookings.DefaultCellStyle.ForeColor;
                }
                if (e.CellStyle.SelectionBackColor != SystemColors.Highlight) { e.CellStyle.SelectionBackColor = SystemColors.Highlight; }
                if (e.CellStyle.SelectionForeColor != SystemColors.HighlightText) { e.CellStyle.SelectionForeColor = SystemColors.HighlightText; }
            }
        }

        private void btnCancelBooking_Click(object? sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0 || dgvBookings.SelectedRows[0].Cells["BookingId"]?.Value == null)
            { MessageBox.Show("Please select a booking to cancel.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!(dgvBookings.SelectedRows[0].Cells["BookingId"]?.Value is int bookingId))
            { MessageBox.Show("Could not determine the selected booking ID.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            string currentStatusString = dgvBookings.SelectedRows[0].Cells["Status"]?.Value?.ToString() ?? string.Empty;
            string serviceName = dgvBookings.SelectedRows[0].Cells["Service"]?.Value?.ToString() ?? "Unknown Service";
            string paymentStatusString = dgvBookings.SelectedRows[0].Cells["Payment"]?.Value?.ToString() ?? string.Empty;

            // Check current status 
            if (currentStatusString.Equals(BookingStatus.Completed.ToString(), StringComparison.OrdinalIgnoreCase) ||
                currentStatusString.Equals(BookingStatus.Cancelled.ToString(), StringComparison.OrdinalIgnoreCase))
            { MessageBox.Show($"Booking for '{serviceName}' cannot be cancelled (Status: {currentStatusString}).", "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            // Block cancellation if paid
            if (paymentStatusString.Equals(PaymentStatus.Paid.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"Cannot cancel a booking that has already been paid. Please contact support.", "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show($"Cancel booking for '{serviceName}'?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    var booking = _context.Bookings.Find(bookingId);
                    if (booking != null)
                    {
                        booking.Status = BookingStatus.Cancelled;
                        _context.SaveChanges();
                        MessageBox.Show($"Booking for '{serviceName}' cancelled.", "Cancel Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookings();
                    }
                    else
                    {
                        MessageBox.Show("Could not find the booking to cancel.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        LoadBookings();
                    }
                }
                catch (Exception ex) { MessageBox.Show($"Error cancelling booking: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnPayNow_Click(object? sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count == 0 || dgvBookings.SelectedRows[0].Cells["BookingId"]?.Value == null)
            { MessageBox.Show("Please select a booking to pay for.", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (!(dgvBookings.SelectedRows[0].Cells["BookingId"]?.Value is int bookingId))
            { MessageBox.Show("Could not determine the selected booking ID.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            string currentStatusString = dgvBookings.SelectedRows[0].Cells["Status"]?.Value?.ToString() ?? string.Empty;
            string paymentStatusString = dgvBookings.SelectedRows[0].Cells["Payment"]?.Value?.ToString() ?? string.Empty;
            string serviceName = dgvBookings.SelectedRows[0].Cells["Service"]?.Value?.ToString() ?? "Unknown Service";

                if (paymentStatusString.Equals(PaymentStatus.Paid.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"Booking for '{serviceName}' is already paid.", "Already Paid", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (currentStatusString.Equals(BookingStatus.Cancelled.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show($"Cannot pay for a booking that is already cancelled.", "Cannot Pay", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var bookingToPay = _context.Bookings.Find(bookingId);
                if (bookingToPay == null)
                {
                    MessageBox.Show("Could not find the booking details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (var paymentForm = new PaymentForm(bookingToPay))
                {
                    var result = paymentForm.ShowDialog(this);

                    if (result == DialogResult.OK)
                    {
                        LoadBookings();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening payment form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- Profile Tab ---
        private void btnContactAdmin_Click(object? sender, EventArgs e)
        {
            using (var supportForm = new ContactSupportForm())
            {
                supportForm.ShowDialog(this);
            }
        }


        // --- Profile Tab ---
        private void LoadProfile()
        {
            try
            {
                var user = _context.Users.Find(_currentUser.UserId);
                if (user != null)
                {
                    txtProfileName.Text = user.Name ?? "";
                    txtProfilePhone.Text = user.Phone ?? "";
                    txtProfileEmail.Text = user.Email ?? "";

                    string roleText = user.Role.ToString();
                    txtProfileRole.Text = CultureInfo.CurrentCulture?.TextInfo?.ToTitleCase(roleText) ?? roleText;
                }
                else { MessageBox.Show("Could not load profile. User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show($"Error loading profile: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnUpdateProfile_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProfileName.Text) || string.IsNullOrWhiteSpace(txtProfilePhone.Text)) { MessageBox.Show("Name and Phone Number cannot be empty.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            try
            {
                var userToUpdate = _context.Users.Find(_currentUser.UserId);
                if (userToUpdate != null)
                {
                    bool changed = false;
                    if (userToUpdate.Name != txtProfileName.Text) { userToUpdate.Name = txtProfileName.Text; changed = true; }
                    if (userToUpdate.Phone != txtProfilePhone.Text) { userToUpdate.Phone = txtProfilePhone.Text; changed = true; }
                    if (changed)
                    {
                        _context.SaveChanges();
                        _currentUser.Name = userToUpdate.Name;
                        _currentUser.Phone = userToUpdate.Phone;
                        lblWelcome.Text = $"Welcome back, {_currentUser.Name ?? "User"}!";
                        MessageBox.Show("Profile updated successfully!", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("No changes detected.", "Update Info", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                }
                else { MessageBox.Show("Could not find profile to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex) { MessageBox.Show($"Error updating profile: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }


        // --- General ---
        private void btnLogout_Click(object? sender, EventArgs e) { this.Close(); }
        private void DashboardForm_FormClosed(object? sender, FormClosedEventArgs e) { _context?.Dispose(); if (Application.OpenForms.Count == 0) { Application.ExitThread(); } }

    }
}