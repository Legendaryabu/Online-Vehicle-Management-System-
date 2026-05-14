//file name : Controls/ServiceCardControl.cs

using Microsoft.EntityFrameworkCore;
using OVSMS_Desktop.Data;
using OVSMS_Desktop.Forms;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;

namespace OVSMS_Desktop.Controls
{
    public partial class ServiceCardControl : UserControl
    {
        private readonly Service _service;
        private readonly User _currentUser;
        private readonly NumberFormatInfo _lkrFormat;

        public event EventHandler? BookingMade;

        public ServiceCardControl(Service service, User currentUser, NumberFormatInfo lkrFormat)
        {
            InitializeComponent();
            _service = service ?? throw new ArgumentNullException(nameof(service));
            _currentUser = currentUser ?? throw new ArgumentNullException(nameof(currentUser));
            _lkrFormat = lkrFormat;

            lblServiceName.Text = _service.Name;
            lblDescription.Text = _service.Description;
            lblPrice.Text = $"Starting at {_service.BasePrice.ToString("C", _lkrFormat)}";
        }

        private void btnBookNow_Click(object? sender, EventArgs e)
        {
            List<User> availableProviders;

            // --- Find Providers ---
            try
            {
                using (var context = new AppDbContext())
                {
                    // Find User IDs of providers offering the service
                    var providerIdsOfferingService = context.ProviderServices
                        .Where(ps => ps.ServiceId == _service.ServiceId)
                        .Select(ps => ps.ProviderId)
                        .ToList();

                    if (!providerIdsOfferingService.Any())
                    {
                        MessageBox.Show($"Sorry, no providers currently offer '{_service.Name}'.", "Service Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    // Filter by approved status and role
                    availableProviders = context.Users
                        .Where(u => u.Role == UserRole.Provider &&
                                     u.IsApproved &&
                                     providerIdsOfferingService.Contains(u.UserId))
                        .OrderBy(u => u.Name)
                        .ToList();

                    if (!availableProviders.Any())
                    {
                        MessageBox.Show($"Sorry, no *approved* providers currently offer '{_service.Name}'. Please check back later.", "Providers Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finding providers: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- Show Provider Selection Form ---
            User? chosenProvider = null;
            using (SelectProviderForm selectForm = new SelectProviderForm(_service, availableProviders))
            {
                if (selectForm.ShowDialog(this) == DialogResult.OK)
                {
                    chosenProvider = selectForm.SelectedProvider;
                }
            }

            // --- Open Booking Form ---
            if (chosenProvider != null)
            {

                using (BookingForm bookingForm = new BookingForm(_currentUser, _service, chosenProvider, _lkrFormat))
                {
                    bookingForm.BookingMade += (s, args) => {
                        BookingMade?.Invoke(this, EventArgs.Empty);
                    };
                    bookingForm.ShowDialog(this);
                }
            }
        }
    }
}