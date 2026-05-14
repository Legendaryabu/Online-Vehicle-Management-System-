using Microsoft.EntityFrameworkCore;
using OVSMS_Desktop.Data;
using System.Data;
using System.Windows.Forms;
using System;
using System.Linq;
using System.Globalization;

namespace OVSMS_Desktop.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly AppDbContext _context;
        private readonly Booking _bookingToPay;
        private readonly NumberFormatInfo LkrFormat; 

        public PaymentForm(Booking bookingToPay)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _bookingToPay = bookingToPay;

            LkrFormat = (NumberFormatInfo)CultureInfo.InvariantCulture.NumberFormat.Clone();
            LkrFormat.CurrencySymbol = "Rs.";
            LkrFormat.CurrencyGroupSeparator = ",";
            LkrFormat.CurrencyDecimalSeparator = ".";
            LkrFormat.CurrencyDecimalDigits = 2;

            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PaymentForm_FormClosed);
        }

        private void PaymentForm_Load(object? sender, EventArgs e)
        {
            if (_bookingToPay != null)
            {
                var bookingDetails = _context.Bookings
                    .Include(b => b.User)
                    .Include(b => b.Service)
                    .FirstOrDefault(b => b.BookingId == _bookingToPay.BookingId);

                if (bookingDetails != null)
                {
                    labelBookingForValue.Text = bookingDetails.User?.Name ?? "N/A";
                    labelServiceValue.Text = bookingDetails.Service?.Name ?? "N/A";
                    labelAmountValue.Text = bookingDetails.Price.ToString("C", LkrFormat);
                }
            }

            comboBoxPaymentMethod.Items.Clear();
            comboBoxPaymentMethod.Items.Add(PaymentMethod.CreditCard.ToString());
            comboBoxPaymentMethod.Items.Add(PaymentMethod.Cash.ToString());

            comboBoxPaymentMethod.SelectedIndex = 0; 
        }

        private void comboBoxPaymentMethod_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? selectedMethodString = comboBoxPaymentMethod.SelectedItem?.ToString();

            panelCardDetails.Visible = (selectedMethodString == PaymentMethod.CreditCard.ToString());
        }

        private async void btnConfirmPayment_Click(object? sender, EventArgs e)
        {
            string? selectedMethodString = comboBoxPaymentMethod.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedMethodString))
            {
                MessageBox.Show("Please select a payment method.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Enum.TryParse<PaymentMethod>(selectedMethodString, out PaymentMethod selectedMethod))
            {
                MessageBox.Show("Invalid payment method selected.", "Internal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedMethod == PaymentMethod.CreditCard)
            {
                if (string.IsNullOrWhiteSpace(textBoxCardNumber.Text) ||
                    string.IsNullOrWhiteSpace(textBoxExpiry.Text) ||
                    string.IsNullOrWhiteSpace(textBoxCVV.Text))
                {
                    MessageBox.Show("Please fill in all credit card details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                //  1. Create a new Payment record 
                var newPayment = new Payment
                {
                    Amount = _bookingToPay.Price,
                    PaymentDate = DateTime.UtcNow,
                    PaymentMethod = selectedMethod,
                    TransactionId = (selectedMethod == PaymentMethod.CreditCard) ? $"SIM_CC_{Guid.NewGuid()}" : $"SIM_CASH_{Guid.NewGuid()}",
                    BookingId = _bookingToPay.BookingId
                };

                _context.Payments.Add(newPayment);

                // 2. Update the Booking status 
                var bookingToUpdate = await _context.Bookings.FindAsync(_bookingToPay.BookingId);
                if (bookingToUpdate != null)
                {
                    bookingToUpdate.PaymentStatus = PaymentStatus.Paid;
                    _context.Bookings.Update(bookingToUpdate);
                }
                else
                {
                    MessageBox.Show("Error: Could not find the booking to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 3. Save changes to the database 
                await _context.SaveChangesAsync();

                MessageBox.Show("Payment Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; 
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the payment: {ex.Message}", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object? sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PaymentForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _context?.Dispose();
        }
    }
}