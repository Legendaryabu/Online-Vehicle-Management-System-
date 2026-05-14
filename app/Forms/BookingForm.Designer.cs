namespace OVSMS_Desktop.Forms
{
    partial class BookingForm
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
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.comboVehicles = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblProviderInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServiceName.Location = new System.Drawing.Point(30, 25);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(151, 30);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "[Service Name]";
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServicePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.lblServicePrice.Location = new System.Drawing.Point(32, 60);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(95, 21);
            this.lblServicePrice.TabIndex = 1;
            this.lblServicePrice.Text = "[Price: ₹XX]";
            // 
            // lblVehicle
            // 
            this.lblVehicle.AutoSize = true;
            this.lblVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVehicle.Location = new System.Drawing.Point(32, 140);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(117, 20);
            this.lblVehicle.TabIndex = 2;
            this.lblVehicle.Text = "Select Vehicle:";
            // 
            // comboVehicles
            // 
            this.comboVehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicles.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboVehicles.FormattingEnabled = true;
            this.comboVehicles.Location = new System.Drawing.Point(32, 165); 
            this.comboVehicles.Name = "comboVehicles";
            this.comboVehicles.Size = new System.Drawing.Size(320, 28);
            this.comboVehicles.TabIndex = 1; 
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(32, 215); 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(161, 20);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Preferred Date:";
            // 
            // datePicker
            // 
            this.datePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.datePicker.Location = new System.Drawing.Point(32, 240); 
            this.datePicker.Size = new System.Drawing.Size(320, 27);
            this.datePicker.TabIndex = 2; 
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(32, 290); 
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(320, 45);
            this.btnConfirm.TabIndex = 3; 
            this.btnConfirm.Text = "Confirm Booking";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblProviderInfo
            // 
            this.lblProviderInfo.AutoSize = true;
            this.lblProviderInfo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblProviderInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblProviderInfo.Location = new System.Drawing.Point(32, 95); 
            this.lblProviderInfo.Name = "lblProviderInfo";
            this.lblProviderInfo.Size = new System.Drawing.Size(121, 19);
            this.lblProviderInfo.TabIndex = 7; 
            this.lblProviderInfo.Text = "[Provider: Name]";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 371);
            this.Controls.Add(this.lblProviderInfo);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.comboVehicles);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblServicePrice);
            this.Controls.Add(this.lblServiceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirm Booking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookingForm_FormClosed);
            this.Load += new System.EventHandler(this.BookingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.ComboBox comboVehicles;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblProviderInfo;
    }
}
