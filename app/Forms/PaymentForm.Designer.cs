namespace OVSMS_Desktop.Forms
{
    partial class PaymentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelService = new System.Windows.Forms.Label();
            this.labelServiceValue = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.labelAmountValue = new System.Windows.Forms.Label();
            this.labelPaymentMethod = new System.Windows.Forms.Label();
            this.comboBoxPaymentMethod = new System.Windows.Forms.ComboBox();
            this.labelCardNumber = new System.Windows.Forms.Label();
            this.textBoxCardNumber = new System.Windows.Forms.TextBox();
            this.labelExpiry = new System.Windows.Forms.Label();
            this.textBoxExpiry = new System.Windows.Forms.TextBox();
            this.labelCVV = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelCardDetails = new System.Windows.Forms.Panel();
            this.labelBookingFor = new System.Windows.Forms.Label();
            this.labelBookingForValue = new System.Windows.Forms.Label();
            this.panelCardDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(21, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(209, 32);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Confirm Payment";
            // 
            // labelService
            // 
            this.labelService.AutoSize = true;
            this.labelService.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelService.Location = new System.Drawing.Point(26, 114);
            this.labelService.Name = "labelService";
            this.labelService.Size = new System.Drawing.Size(57, 20);
            this.labelService.TabIndex = 1;
            this.labelService.Text = "Service:";
            // 
            // labelServiceValue
            // 
            this.labelServiceValue.AutoSize = true;
            this.labelServiceValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelServiceValue.Location = new System.Drawing.Point(170, 114);
            this.labelServiceValue.Name = "labelServiceValue";
            this.labelServiceValue.Size = new System.Drawing.Size(117, 20);
            this.labelServiceValue.TabIndex = 2;
            this.labelServiceValue.Text = "[Service Name]";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmount.Location = new System.Drawing.Point(26, 149);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(121, 20);
            this.labelAmount.TabIndex = 3;
            this.labelAmount.Text = "Amount to Pay: ";
            // 
            // labelAmountValue
            // 
            this.labelAmountValue.AutoSize = true;
            this.labelAmountValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAmountValue.Location = new System.Drawing.Point(170, 149);
            this.labelAmountValue.Name = "labelAmountValue";
            this.labelAmountValue.Size = new System.Drawing.Size(59, 20);
            this.labelAmountValue.TabIndex = 4;
            this.labelAmountValue.Text = "[00.00]";
            // 
            // labelPaymentMethod
            // 
            this.labelPaymentMethod.AutoSize = true;
            this.labelPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPaymentMethod.Location = new System.Drawing.Point(26, 196);
            this.labelPaymentMethod.Name = "labelPaymentMethod";
            this.labelPaymentMethod.Size = new System.Drawing.Size(126, 20);
            this.labelPaymentMethod.TabIndex = 5;
            this.labelPaymentMethod.Text = "Payment Method:";
            // 
            // comboBoxPaymentMethod
            // 
            this.comboBoxPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPaymentMethod.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxPaymentMethod.FormattingEnabled = true;
            this.comboBoxPaymentMethod.Items.AddRange(new object[] {
            "Credit Card",
            "Cash"});
            this.comboBoxPaymentMethod.Location = new System.Drawing.Point(170, 193);
            this.comboBoxPaymentMethod.Name = "comboBoxPaymentMethod";
            this.comboBoxPaymentMethod.Size = new System.Drawing.Size(225, 28);
            this.comboBoxPaymentMethod.TabIndex = 6;
            this.comboBoxPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaymentMethod_SelectedIndexChanged);
            // 
            // labelCardNumber
            // 
            this.labelCardNumber.AutoSize = true;
            this.labelCardNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCardNumber.Location = new System.Drawing.Point(3, 16);
            this.labelCardNumber.Name = "labelCardNumber";
            this.labelCardNumber.Size = new System.Drawing.Size(102, 20);
            this.labelCardNumber.TabIndex = 7;
            this.labelCardNumber.Text = "Card Number:";
            // 
            // textBoxCardNumber
            // 
            this.textBoxCardNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCardNumber.Location = new System.Drawing.Point(144, 13);
            this.textBoxCardNumber.Name = "textBoxCardNumber";
            this.textBoxCardNumber.Size = new System.Drawing.Size(225, 27);
            this.textBoxCardNumber.TabIndex = 8;
            // 
            // labelExpiry
            // 
            this.labelExpiry.AutoSize = true;
            this.labelExpiry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExpiry.Location = new System.Drawing.Point(3, 58);
            this.labelExpiry.Name = "labelExpiry";
            this.labelExpiry.Size = new System.Drawing.Size(101, 20);
            this.labelExpiry.TabIndex = 9;
            this.labelExpiry.Text = "Expiry (MM/YY):";
            // 
            // textBoxExpiry
            // 
            this.textBoxExpiry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxExpiry.Location = new System.Drawing.Point(144, 55);
            this.textBoxExpiry.Name = "textBoxExpiry";
            this.textBoxExpiry.Size = new System.Drawing.Size(100, 27);
            this.textBoxExpiry.TabIndex = 10;
            // 
            // labelCVV
            // 
            this.labelCVV.AutoSize = true;
            this.labelCVV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCVV.Location = new System.Drawing.Point(3, 100);
            this.labelCVV.Name = "labelCVV";
            this.labelCVV.Size = new System.Drawing.Size(38, 20);
            this.labelCVV.TabIndex = 11;
            this.labelCVV.Text = "CVV:";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCVV.Location = new System.Drawing.Point(144, 97);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(100, 27);
            this.textBoxCVV.TabIndex = 12;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(219, 411);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(176, 45);
            this.btnConfirmPayment.TabIndex = 13;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirmPayment_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(26, 411);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 45);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelCardDetails
            // 
            this.panelCardDetails.Controls.Add(this.labelCardNumber);
            this.panelCardDetails.Controls.Add(this.textBoxCardNumber);
            this.panelCardDetails.Controls.Add(this.labelExpiry);
            this.panelCardDetails.Controls.Add(this.textBoxCVV);
            this.panelCardDetails.Controls.Add(this.textBoxExpiry);
            this.panelCardDetails.Controls.Add(this.labelCVV);
            this.panelCardDetails.Location = new System.Drawing.Point(26, 240);
            this.panelCardDetails.Name = "panelCardDetails";
            this.panelCardDetails.Size = new System.Drawing.Size(378, 144);
            this.panelCardDetails.TabIndex = 15;
            this.panelCardDetails.Visible = false;
            // 
            // labelBookingFor
            // 
            this.labelBookingFor.AutoSize = true;
            this.labelBookingFor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBookingFor.Location = new System.Drawing.Point(26, 79);
            this.labelBookingFor.Name = "labelBookingFor";
            this.labelBookingFor.Size = new System.Drawing.Size(91, 20);
            this.labelBookingFor.TabIndex = 16;
            this.labelBookingFor.Text = "Booking for:";
            // 
            // labelBookingForValue
            // 
            this.labelBookingForValue.AutoSize = true;
            this.labelBookingForValue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBookingForValue.Location = new System.Drawing.Point(170, 79);
            this.labelBookingForValue.Name = "labelBookingForValue";
            this.labelBookingForValue.Size = new System.Drawing.Size(127, 20);
            this.labelBookingForValue.TabIndex = 17;
            this.labelBookingForValue.Text = "[CustomerName]";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(425, 482);
            this.Controls.Add(this.labelBookingForValue);
            this.Controls.Add(this.labelBookingFor);
            this.Controls.Add(this.panelCardDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.comboBoxPaymentMethod);
            this.Controls.Add(this.labelPaymentMethod);
            this.Controls.Add(this.labelAmountValue);
            this.Controls.Add(this.labelAmount);
            this.Controls.Add(this.labelServiceValue);
            this.Controls.Add(this.labelService);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panelCardDetails.ResumeLayout(false);
            this.panelCardDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelService;
        private System.Windows.Forms.Label labelServiceValue;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.Label labelAmountValue;
        private System.Windows.Forms.Label labelPaymentMethod;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethod;
        private System.Windows.Forms.Label labelCardNumber;
        private System.Windows.Forms.TextBox textBoxCardNumber;
        private System.Windows.Forms.Label labelExpiry;
        private System.Windows.Forms.TextBox textBoxExpiry;
        private System.Windows.Forms.Label labelCVV;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panelCardDetails;
        private System.Windows.Forms.Label labelBookingFor;
        private System.Windows.Forms.Label labelBookingForValue;
    }
}
