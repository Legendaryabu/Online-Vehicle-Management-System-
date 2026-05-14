using OVSMS_Desktop.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace OVSMS_Desktop.Forms
{
    public partial class BookingForm : Form
    {
        private readonly User _currentUser;
        private readonly Service _selectedService;
        private readonly User _selectedProvider;
        private readonly NumberFormatInfo _lkrFormat;
        private AppDbContext _context;

        public event EventHandler? BookingMade;

        public BookingForm(User currentUser, Service selectedService, User chosenProvider, NumberFormatInfo lkrFormat)
        {
            InitializeComponent();
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            _selectedService = selectedService ?? throw new ArgumentNullException(nameof(selectedService));
            _selectedProvider = chosenProvider ?? throw new ArgumentNullException(nameof(chosenProvider));
            _lkrFormat = lkrFormat;
            _context = new AppDbContext();
        }

        private void BookingForm_Load(object? sender, EventArgs e)
        {
            lblServiceName.Text = _selectedService.Name;
            lblServicePrice.Text = $"Price: {_selectedService.BasePrice.ToString("C", _lkrFormat)}";
            lblProviderInfo.Text = $"Provider: {_selectedProvider.Name ?? "N/A"}";
            // Set minimum booking date to today
            datePicker.MinDate = DateTime.Today;

            try { LoadUserVehicles(); }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadUserVehicles()
        {
            var vehicles = _context.Vehicles.Where(v => v.UserId == _currentUser.UserId).ToList();
            if (vehicles.Count == 0)
            { MessageBox.Show("Please add a vehicle on the 'My Vehicles' tab first.", "No Vehicles Found", MessageBoxButtons.OK, MessageBoxIcon.Warning); this.Close(); return; }
            comboVehicles.DataSource = vehicles;
            comboVehicles.DisplayMember = "DisplayName"; comboVehicles.ValueMember = "VehicleId"; comboVehicles.SelectedIndex = -1;
        }

        private void btnConfirm_Click(object? sender, EventArgs e)
        {
            // --- Booking Confirmation Logic ---

            // Check for null on SelectedItem
            if (comboVehicles.SelectedItem == null)
            { MessageBox.Show("Please select a vehicle.", "Vehicle Required", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // Use as Vehicle to safely cast
            if (!(comboVehicles.SelectedItem is Vehicle selectedVehicle))
            { MessageBox.Show("Invalid vehicle selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            var newBooking = new Booking
            {
                UserId = _currentUser.UserId,
                VehicleId = selectedVehicle.VehicleId,
                ServiceId = _selectedService.ServiceId,
                BookingDate = datePicker.Value,
                // Assigning the Enum value directly
                Status = BookingStatus.Pending,
                Price = _selectedService.BasePrice,
                ProviderId = _selectedProvider.UserId
            };

            try
            {
                _context.Bookings.Add(newBooking);
                _context.SaveChanges();

                MessageBox.Show($"Booking for '{_selectedService.Name}' with provider '{_selectedProvider.Name}' confirmed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BookingMade?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error confirming booking: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BookingForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _context?.Dispose();
        }
    }
}