namespace OVSMS_Desktop.Forms
{
    partial class ProviderDashboardForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcomeProvider = new System.Windows.Forms.Label();
            this.btnLogoutProvider = new System.Windows.Forms.Button();
            this.tabControlProvider = new System.Windows.Forms.TabControl();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.panelBookingDetails = new System.Windows.Forms.Panel();
            this.lblDetailPaymentStatus = new System.Windows.Forms.Label();
            this.lblStaticPaymentStatus = new System.Windows.Forms.Label();
            this.lblDetailStatus = new System.Windows.Forms.Label();
            this.lblStaticStatus = new System.Windows.Forms.Label();
            this.lblDetailBookingDate = new System.Windows.Forms.Label();
            this.lblStaticBookingDate = new System.Windows.Forms.Label();
            this.lblDetailServiceDesc = new System.Windows.Forms.Label();
            this.lblStaticService = new System.Windows.Forms.Label();
            this.lblDetailVehicle = new System.Windows.Forms.Label();
            this.lblStaticVehicle = new System.Windows.Forms.Label();
            this.lblDetailCustomerPhone = new System.Windows.Forms.Label();
            this.lblStaticCustomerPhone = new System.Windows.Forms.Label();
            this.lblDetailCustomerName = new System.Windows.Forms.Label();
            this.lblStaticCustomerName = new System.Windows.Forms.Label();
            this.lblBookingDetailsTitle = new System.Windows.Forms.Label();
            this.btnCompleteBooking = new System.Windows.Forms.Button();
            this.btnAcceptBooking = new System.Windows.Forms.Button();
            this.dgvBookingRequests = new System.Windows.Forms.DataGridView();
            this.tabMyServices = new System.Windows.Forms.TabPage();
            this.btnSaveMyServices = new System.Windows.Forms.Button();
            this.clbServices = new System.Windows.Forms.CheckedListBox();
            this.lblMyServicesInstruction = new System.Windows.Forms.Label();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.lblScheduleInfo = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.tabCompletedBookings = new System.Windows.Forms.TabPage();
            this.dgvCompletedBookings = new System.Windows.Forms.DataGridView();
            this.lblCompletedBookingsTitle = new System.Windows.Forms.Label();
            this.tabProviderProfile = new System.Windows.Forms.TabPage();
            this.panelProviderProfile = new System.Windows.Forms.Panel();
            this.btnContactAdmin = new System.Windows.Forms.Button();
            this.btnUpdateProviderProfile = new System.Windows.Forms.Button();
            this.txtProfilePhoneProvider = new System.Windows.Forms.TextBox();
            this.lblProfilePhoneProvider = new System.Windows.Forms.Label();
            this.txtProfileNameProvider = new System.Windows.Forms.TextBox();
            this.lblProfileNameProvider = new System.Windows.Forms.Label();
            this.lblProfileTitleProvider = new System.Windows.Forms.Label();
            this.tabControlProvider.SuspendLayout();
            this.tabBookings.SuspendLayout();
            this.panelBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingRequests)).BeginInit();
            this.tabMyServices.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.tabCompletedBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedBookings)).BeginInit();
            this.tabProviderProfile.SuspendLayout();
            this.panelProviderProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcomeProvider
            // 
            this.lblWelcomeProvider.AutoSize = true;
            this.lblWelcomeProvider.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeProvider.Location = new System.Drawing.Point(24, 20);
            this.lblWelcomeProvider.Name = "lblWelcomeProvider";
            this.lblWelcomeProvider.Size = new System.Drawing.Size(209, 30);
            this.lblWelcomeProvider.TabIndex = 0;
            this.lblWelcomeProvider.Text = "Welcome, Provider!";
            // 
            // btnLogoutProvider
            // 
            this.btnLogoutProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoutProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogoutProvider.FlatAppearance.BorderSize = 0;
            this.btnLogoutProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutProvider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogoutProvider.ForeColor = System.Drawing.Color.White;
            this.btnLogoutProvider.Location = new System.Drawing.Point(868, 20);
            this.btnLogoutProvider.Name = "btnLogoutProvider";
            this.btnLogoutProvider.Size = new System.Drawing.Size(94, 35);
            this.btnLogoutProvider.TabIndex = 1;
            this.btnLogoutProvider.Text = "Logout";
            this.btnLogoutProvider.UseVisualStyleBackColor = false;
            this.btnLogoutProvider.Click += new System.EventHandler(this.btnLogoutProvider_Click);
            // 
            // tabControlProvider
            // 
            this.tabControlProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlProvider.Controls.Add(this.tabBookings);
            this.tabControlProvider.Controls.Add(this.tabMyServices);
            this.tabControlProvider.Controls.Add(this.tabSchedule);
            this.tabControlProvider.Controls.Add(this.tabCompletedBookings);
            this.tabControlProvider.Controls.Add(this.tabProviderProfile);
            this.tabControlProvider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlProvider.Location = new System.Drawing.Point(24, 69);
            this.tabControlProvider.Name = "tabControlProvider";
            this.tabControlProvider.SelectedIndex = 0;
            this.tabControlProvider.Size = new System.Drawing.Size(938, 569);
            this.tabControlProvider.TabIndex = 2;
            this.tabControlProvider.SelectedIndexChanged += new System.EventHandler(this.tabControlProvider_SelectedIndexChanged);
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.panelBookingDetails);
            this.tabBookings.Controls.Add(this.btnCompleteBooking);
            this.tabBookings.Controls.Add(this.btnAcceptBooking);
            this.tabBookings.Controls.Add(this.dgvBookingRequests);
            this.tabBookings.Location = new System.Drawing.Point(4, 26);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(15);
            this.tabBookings.Size = new System.Drawing.Size(930, 539);
            this.tabBookings.TabIndex = 0;
            this.tabBookings.Text = "Booking Requests";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // panelBookingDetails
            // 
            this.panelBookingDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBookingDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBookingDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookingDetails.Controls.Add(this.lblDetailPaymentStatus);
            this.panelBookingDetails.Controls.Add(this.lblStaticPaymentStatus);
            this.panelBookingDetails.Controls.Add(this.lblDetailStatus);
            this.panelBookingDetails.Controls.Add(this.lblStaticStatus);
            this.panelBookingDetails.Controls.Add(this.lblDetailBookingDate);
            this.panelBookingDetails.Controls.Add(this.lblStaticBookingDate);
            this.panelBookingDetails.Controls.Add(this.lblDetailServiceDesc);
            this.panelBookingDetails.Controls.Add(this.lblStaticService);
            this.panelBookingDetails.Controls.Add(this.lblDetailVehicle);
            this.panelBookingDetails.Controls.Add(this.lblStaticVehicle);
            this.panelBookingDetails.Controls.Add(this.lblDetailCustomerPhone);
            this.panelBookingDetails.Controls.Add(this.lblStaticCustomerPhone);
            this.panelBookingDetails.Controls.Add(this.lblDetailCustomerName);
            this.panelBookingDetails.Controls.Add(this.lblStaticCustomerName);
            this.panelBookingDetails.Controls.Add(this.lblBookingDetailsTitle);
            this.panelBookingDetails.Location = new System.Drawing.Point(632, 18);
            this.panelBookingDetails.Name = "panelBookingDetails";
            this.panelBookingDetails.Padding = new System.Windows.Forms.Padding(10);
            this.panelBookingDetails.Size = new System.Drawing.Size(280, 462);
            this.panelBookingDetails.TabIndex = 3;
            this.panelBookingDetails.Visible = false;
            // 
            // lblDetailPaymentStatus
            // 
            this.lblDetailPaymentStatus.AutoSize = true;
            this.lblDetailPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDetailPaymentStatus.Location = new System.Drawing.Point(13, 335);
            this.lblDetailPaymentStatus.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDetailPaymentStatus.Name = "lblDetailPaymentStatus";
            this.lblDetailPaymentStatus.Size = new System.Drawing.Size(78, 20);
            this.lblDetailPaymentStatus.TabIndex = 14;
            this.lblDetailPaymentStatus.Text = "[Payment]";
            // 
            // lblStaticPaymentStatus
            // 
            this.lblStaticPaymentStatus.AutoSize = true;
            this.lblStaticPaymentStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaticPaymentStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaticPaymentStatus.Location = new System.Drawing.Point(13, 320);
            this.lblStaticPaymentStatus.Name = "lblStaticPaymentStatus";
            this.lblStaticPaymentStatus.Size = new System.Drawing.Size(92, 15);
            this.lblStaticPaymentStatus.TabIndex = 13;
            this.lblStaticPaymentStatus.Text = "Payment Status:";
            // 
            // lblDetailStatus
            // 
            this.lblDetailStatus.AutoSize = true;
            this.lblDetailStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDetailStatus.Location = new System.Drawing.Point(13, 290);
            this.lblDetailStatus.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDetailStatus.Name = "lblDetailStatus";
            this.lblDetailStatus.Size = new System.Drawing.Size(60, 20);
            this.lblDetailStatus.TabIndex = 12;
            this.lblDetailStatus.Text = "[Status]";
            // 
            // lblStaticStatus
            // 
            this.lblStaticStatus.AutoSize = true;
            this.lblStaticStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaticStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaticStatus.Location = new System.Drawing.Point(13, 275);
            this.lblStaticStatus.Name = "lblStaticStatus";
            this.lblStaticStatus.Size = new System.Drawing.Size(43, 15);
            this.lblStaticStatus.TabIndex = 11;
            this.lblStaticStatus.Text = "Status:";
            // 
            // lblDetailBookingDate
            // 
            this.lblDetailBookingDate.AutoSize = true;
            this.lblDetailBookingDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailBookingDate.Location = new System.Drawing.Point(13, 245);
            this.lblDetailBookingDate.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDetailBookingDate.Name = "lblDetailBookingDate";
            this.lblDetailBookingDate.Size = new System.Drawing.Size(45, 19);
            this.lblDetailBookingDate.TabIndex = 10;
            this.lblDetailBookingDate.Text = "[Date]";
            // 
            // lblStaticBookingDate
            // 
            this.lblStaticBookingDate.AutoSize = true;
            this.lblStaticBookingDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaticBookingDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaticBookingDate.Location = new System.Drawing.Point(13, 230);
            this.lblStaticBookingDate.Name = "lblStaticBookingDate";
            this.lblStaticBookingDate.Size = new System.Drawing.Size(83, 15);
            this.lblStaticBookingDate.TabIndex = 9;
            this.lblStaticBookingDate.Text = "Booking Date:";
            // 
            // lblDetailServiceDesc
            // 
            this.lblDetailServiceDesc.AutoSize = true;
            this.lblDetailServiceDesc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailServiceDesc.Location = new System.Drawing.Point(13, 200);
            this.lblDetailServiceDesc.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDetailServiceDesc.Name = "lblDetailServiceDesc";
            this.lblDetailServiceDesc.Size = new System.Drawing.Size(61, 19);
            this.lblDetailServiceDesc.TabIndex = 8;
            this.lblDetailServiceDesc.Text = "[Service]";
            // 
            // lblStaticService
            // 
            this.lblStaticService.AutoSize = true;
            this.lblStaticService.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaticService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaticService.Location = new System.Drawing.Point(13, 185);
            this.lblStaticService.Name = "lblStaticService";
            this.lblStaticService.Size = new System.Drawing.Size(47, 15);
            this.lblStaticService.TabIndex = 7;
            this.lblStaticService.Text = "Service:";
            // 
            // lblDetailVehicle
            // 
            this.lblDetailVehicle.AutoSize = true;
            this.lblDetailVehicle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailVehicle.Location = new System.Drawing.Point(13, 155);
            this.lblDetailVehicle.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDetailVehicle.Name = "lblDetailVehicle";
            this.lblDetailVehicle.Size = new System.Drawing.Size(59, 19);
            this.lblDetailVehicle.TabIndex = 6;
            this.lblDetailVehicle.Text = "[Vehicle]";
            // 
            // lblStaticVehicle
            // 
            this.lblStaticVehicle.AutoSize = true;
            this.lblStaticVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaticVehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaticVehicle.Location = new System.Drawing.Point(13, 140);
            this.lblStaticVehicle.Name = "lblStaticVehicle";
            this.lblStaticVehicle.Size = new System.Drawing.Size(47, 15);
            this.lblStaticVehicle.TabIndex = 5;
            this.lblStaticVehicle.Text = "Vehicle:";
            // 
            // lblDetailCustomerPhone
            // 
            this.lblDetailCustomerPhone.AutoSize = true;
            this.lblDetailCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailCustomerPhone.Location = new System.Drawing.Point(13, 110);
            this.lblDetailCustomerPhone.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDetailCustomerPhone.Name = "lblDetailCustomerPhone";
            this.lblDetailCustomerPhone.Size = new System.Drawing.Size(54, 19);
            this.lblDetailCustomerPhone.TabIndex = 4;
            this.lblDetailCustomerPhone.Text = "[Phone]";
            // 
            // lblStaticCustomerPhone
            // 
            this.lblStaticCustomerPhone.AutoSize = true;
            this.lblStaticCustomerPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaticCustomerPhone.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaticCustomerPhone.Location = new System.Drawing.Point(13, 95);
            this.lblStaticCustomerPhone.Name = "lblStaticCustomerPhone";
            this.lblStaticCustomerPhone.Size = new System.Drawing.Size(100, 15);
            this.lblStaticCustomerPhone.TabIndex = 3;
            this.lblStaticCustomerPhone.Text = "Customer Phone:";
            // 
            // lblDetailCustomerName
            // 
            this.lblDetailCustomerName.AutoSize = true;
            this.lblDetailCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDetailCustomerName.Location = new System.Drawing.Point(13, 65);
            this.lblDetailCustomerName.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblDetailCustomerName.Name = "lblDetailCustomerName";
            this.lblDetailCustomerName.Size = new System.Drawing.Size(52, 19);
            this.lblDetailCustomerName.TabIndex = 2;
            this.lblDetailCustomerName.Text = "[Name]";
            // 
            // lblStaticCustomerName
            // 
            this.lblStaticCustomerName.AutoSize = true;
            this.lblStaticCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblStaticCustomerName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaticCustomerName.Location = new System.Drawing.Point(13, 50);
            this.lblStaticCustomerName.Name = "lblStaticCustomerName";
            this.lblStaticCustomerName.Size = new System.Drawing.Size(98, 15);
            this.lblStaticCustomerName.TabIndex = 1;
            this.lblStaticCustomerName.Text = "Customer Name:";
            // 
            // lblBookingDetailsTitle
            // 
            this.lblBookingDetailsTitle.AutoSize = true;
            this.lblBookingDetailsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingDetailsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblBookingDetailsTitle.Location = new System.Drawing.Point(10, 10);
            this.lblBookingDetailsTitle.Name = "lblBookingDetailsTitle";
            this.lblBookingDetailsTitle.Size = new System.Drawing.Size(128, 21);
            this.lblBookingDetailsTitle.TabIndex = 0;
            this.lblBookingDetailsTitle.Text = "Booking Details";
            // 
            // btnCompleteBooking
            // 
            this.btnCompleteBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompleteBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnCompleteBooking.FlatAppearance.BorderSize = 0;
            this.btnCompleteBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCompleteBooking.ForeColor = System.Drawing.Color.White;
            this.btnCompleteBooking.Location = new System.Drawing.Point(748, 486);
            this.btnCompleteBooking.Name = "btnCompleteBooking";
            this.btnCompleteBooking.Size = new System.Drawing.Size(164, 35);
            this.btnCompleteBooking.TabIndex = 2;
            this.btnCompleteBooking.Text = "Mark as Completed";
            this.btnCompleteBooking.UseVisualStyleBackColor = false;
            this.btnCompleteBooking.Click += new System.EventHandler(this.btnCompleteBooking_Click);
            // 
            // btnAcceptBooking
            // 
            this.btnAcceptBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcceptBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnAcceptBooking.FlatAppearance.BorderSize = 0;
            this.btnAcceptBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAcceptBooking.ForeColor = System.Drawing.Color.White;
            this.btnAcceptBooking.Location = new System.Drawing.Point(578, 486);
            this.btnAcceptBooking.Name = "btnAcceptBooking";
            this.btnAcceptBooking.Size = new System.Drawing.Size(164, 35);
            this.btnAcceptBooking.TabIndex = 1;
            this.btnAcceptBooking.Text = "Accept Booking";
            this.btnAcceptBooking.UseVisualStyleBackColor = false;
            this.btnAcceptBooking.Click += new System.EventHandler(this.btnAcceptBooking_Click);
            // 
            // dgvBookingRequests
            // 
            this.dgvBookingRequests.AllowUserToAddRows = false;
            this.dgvBookingRequests.AllowUserToDeleteRows = false;
            this.dgvBookingRequests.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookingRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookingRequests.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookingRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookingRequests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookingRequests.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookingRequests.Location = new System.Drawing.Point(18, 18);
            this.dgvBookingRequests.MultiSelect = false;
            this.dgvBookingRequests.Name = "dgvBookingRequests";
            this.dgvBookingRequests.ReadOnly = true;
            this.dgvBookingRequests.RowHeadersVisible = false;
            this.dgvBookingRequests.RowTemplate.Height = 35;
            this.dgvBookingRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookingRequests.Size = new System.Drawing.Size(600, 462);
            this.dgvBookingRequests.TabIndex = 0;
            this.dgvBookingRequests.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBookingRequests_CellFormatting);
            this.dgvBookingRequests.SelectionChanged += new System.EventHandler(this.dgvBookingRequests_SelectionChanged);
            // 
            // tabMyServices
            // 
            this.tabMyServices.Controls.Add(this.btnSaveMyServices);
            this.tabMyServices.Controls.Add(this.clbServices);
            this.tabMyServices.Controls.Add(this.lblMyServicesInstruction);
            this.tabMyServices.Location = new System.Drawing.Point(4, 26);
            this.tabMyServices.Name = "tabMyServices";
            this.tabMyServices.Padding = new System.Windows.Forms.Padding(15);
            this.tabMyServices.Size = new System.Drawing.Size(930, 539);
            this.tabMyServices.TabIndex = 1;
            this.tabMyServices.Text = "My Offered Services";
            this.tabMyServices.UseVisualStyleBackColor = true;
            // 
            // btnSaveMyServices
            // 
            this.btnSaveMyServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMyServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnSaveMyServices.FlatAppearance.BorderSize = 0;
            this.btnSaveMyServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMyServices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveMyServices.ForeColor = System.Drawing.Color.White;
            this.btnSaveMyServices.Location = new System.Drawing.Point(748, 486);
            this.btnSaveMyServices.Name = "btnSaveMyServices";
            this.btnSaveMyServices.Size = new System.Drawing.Size(164, 35);
            this.btnSaveMyServices.TabIndex = 2;
            this.btnSaveMyServices.Text = "Save My Services";
            this.btnSaveMyServices.UseVisualStyleBackColor = false;
            this.btnSaveMyServices.Click += new System.EventHandler(this.btnSaveMyServices_Click);
            // 
            // clbServices
            // 
            this.clbServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbServices.CheckOnClick = true;
            this.clbServices.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbServices.FormattingEnabled = true;
            this.clbServices.HorizontalScrollbar = true;
            this.clbServices.Location = new System.Drawing.Point(18, 48);
            this.clbServices.Name = "clbServices";
            this.clbServices.Size = new System.Drawing.Size(894, 422);
            this.clbServices.TabIndex = 1;
            // 
            // lblMyServicesInstruction
            // 
            this.lblMyServicesInstruction.AutoSize = true;
            this.lblMyServicesInstruction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMyServicesInstruction.Location = new System.Drawing.Point(18, 18);
            this.lblMyServicesInstruction.Name = "lblMyServicesInstruction";
            this.lblMyServicesInstruction.Size = new System.Drawing.Size(359, 21);
            this.lblMyServicesInstruction.TabIndex = 0;
            this.lblMyServicesInstruction.Text = "Select the services you offer from the list below:";
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.lblScheduleInfo);
            this.tabSchedule.Controls.Add(this.dgvSchedule);
            this.tabSchedule.Location = new System.Drawing.Point(4, 26);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(15);
            this.tabSchedule.Size = new System.Drawing.Size(930, 539);
            this.tabSchedule.TabIndex = 2;
            this.tabSchedule.Text = "My Schedule";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // lblScheduleInfo
            // 
            this.lblScheduleInfo.AutoSize = true;
            this.lblScheduleInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblScheduleInfo.Location = new System.Drawing.Point(18, 18);
            this.lblScheduleInfo.Name = "lblScheduleInfo";
            this.lblScheduleInfo.Size = new System.Drawing.Size(439, 20);
            this.lblScheduleInfo.TabIndex = 1;
            this.lblScheduleInfo.Text = "Your upcoming assigned bookings (Pending and In Progress):";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AllowUserToAddRows = false;
            this.dgvSchedule.AllowUserToDeleteRows = false;
            this.dgvSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvSchedule.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchedule.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSchedule.Location = new System.Drawing.Point(18, 48);
            this.dgvSchedule.MultiSelect = false;
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.ReadOnly = true;
            this.dgvSchedule.RowHeadersVisible = false;
            this.dgvSchedule.RowTemplate.Height = 35;
            this.dgvSchedule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchedule.Size = new System.Drawing.Size(894, 473);
            this.dgvSchedule.TabIndex = 0;
            this.dgvSchedule.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSchedule_CellFormatting);
            // 
            // tabCompletedBookings
            // 
            this.tabCompletedBookings.Controls.Add(this.dgvCompletedBookings);
            this.tabCompletedBookings.Controls.Add(this.lblCompletedBookingsTitle);
            this.tabCompletedBookings.Location = new System.Drawing.Point(4, 26);
            this.tabCompletedBookings.Name = "tabCompletedBookings";
            this.tabCompletedBookings.Padding = new System.Windows.Forms.Padding(15);
            this.tabCompletedBookings.Size = new System.Drawing.Size(930, 539);
            this.tabCompletedBookings.TabIndex = 4;
            this.tabCompletedBookings.Text = "Recent Works";
            this.tabCompletedBookings.UseVisualStyleBackColor = true;
            // 
            // dgvCompletedBookings
            // 
            this.dgvCompletedBookings.AllowUserToAddRows = false;
            this.dgvCompletedBookings.AllowUserToDeleteRows = false;
            this.dgvCompletedBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCompletedBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompletedBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCompletedBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCompletedBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCompletedBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCompletedBookings.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCompletedBookings.Location = new System.Drawing.Point(18, 48);
            this.dgvCompletedBookings.MultiSelect = false;
            this.dgvCompletedBookings.Name = "dgvCompletedBookings";
            this.dgvCompletedBookings.ReadOnly = true;
            this.dgvCompletedBookings.RowHeadersVisible = false;
            this.dgvCompletedBookings.RowTemplate.Height = 35;
            this.dgvCompletedBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompletedBookings.Size = new System.Drawing.Size(894, 473);
            this.dgvCompletedBookings.TabIndex = 1;
            this.dgvCompletedBookings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCompletedBookings_CellFormatting);
            // 
            // lblCompletedBookingsTitle
            // 
            this.lblCompletedBookingsTitle.AutoSize = true;
            this.lblCompletedBookingsTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblCompletedBookingsTitle.Location = new System.Drawing.Point(18, 18);
            this.lblCompletedBookingsTitle.Name = "lblCompletedBookingsTitle";
            this.lblCompletedBookingsTitle.Size = new System.Drawing.Size(264, 20);
            this.lblCompletedBookingsTitle.TabIndex = 0;
            this.lblCompletedBookingsTitle.Text = "History of Completed Bookings:";
            // 
            // tabProviderProfile
            // 
            this.tabProviderProfile.Controls.Add(this.panelProviderProfile);
            this.tabProviderProfile.Location = new System.Drawing.Point(4, 26);
            this.tabProviderProfile.Name = "tabProviderProfile";
            this.tabProviderProfile.Padding = new System.Windows.Forms.Padding(15);
            this.tabProviderProfile.Size = new System.Drawing.Size(930, 539);
            this.tabProviderProfile.TabIndex = 3;
            this.tabProviderProfile.Text = "My Profile";
            this.tabProviderProfile.UseVisualStyleBackColor = true;
            // 
            // panelProviderProfile
            // 
            this.panelProviderProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelProviderProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProviderProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProviderProfile.Controls.Add(this.btnContactAdmin);
            this.panelProviderProfile.Controls.Add(this.btnUpdateProviderProfile);
            this.panelProviderProfile.Controls.Add(this.txtProfilePhoneProvider);
            this.panelProviderProfile.Controls.Add(this.lblProfilePhoneProvider);
            this.panelProviderProfile.Controls.Add(this.txtProfileNameProvider);
            this.panelProviderProfile.Controls.Add(this.lblProfileNameProvider);
            this.panelProviderProfile.Controls.Add(this.lblProfileTitleProvider);
            this.panelProviderProfile.Location = new System.Drawing.Point(265, 100);
            this.panelProviderProfile.MaximumSize = new System.Drawing.Size(400, 350);
            this.panelProviderProfile.Name = "panelProviderProfile";
            this.panelProviderProfile.Padding = new System.Windows.Forms.Padding(20);
            this.panelProviderProfile.Size = new System.Drawing.Size(400, 320);
            this.panelProviderProfile.TabIndex = 1;
            // 
            // btnContactAdmin
            // 
            this.btnContactAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnContactAdmin.FlatAppearance.BorderSize = 0;
            this.btnContactAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnContactAdmin.ForeColor = System.Drawing.Color.White;
            this.btnContactAdmin.Location = new System.Drawing.Point(23, 269);
            this.btnContactAdmin.Name = "btnContactAdmin";
            this.btnContactAdmin.Size = new System.Drawing.Size(352, 30);
            this.btnContactAdmin.TabIndex = 6;
            this.btnContactAdmin.Text = "Contact Administrator";
            this.btnContactAdmin.UseVisualStyleBackColor = false;
            this.btnContactAdmin.Click += new System.EventHandler(this.btnContactAdmin_Click);
            // 
            // btnUpdateProviderProfile
            // 
            this.btnUpdateProviderProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnUpdateProviderProfile.FlatAppearance.BorderSize = 0;
            this.btnUpdateProviderProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProviderProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProviderProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProviderProfile.Location = new System.Drawing.Point(23, 220);
            this.btnUpdateProviderProfile.Name = "btnUpdateProviderProfile";
            this.btnUpdateProviderProfile.Size = new System.Drawing.Size(352, 40);
            this.btnUpdateProviderProfile.TabIndex = 5;
            this.btnUpdateProviderProfile.Text = "Update My Profile";
            this.btnUpdateProviderProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProviderProfile.Click += new System.EventHandler(this.btnUpdateProviderProfile_Click);
            // 
            // txtProfilePhoneProvider
            // 
            this.txtProfilePhoneProvider.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProfilePhoneProvider.Location = new System.Drawing.Point(23, 179);
            this.txtProfilePhoneProvider.Name = "txtProfilePhoneProvider";
            this.txtProfilePhoneProvider.Size = new System.Drawing.Size(352, 27);
            this.txtProfilePhoneProvider.TabIndex = 4;
            // 
            // lblProfilePhoneProvider
            // 
            this.lblProfilePhoneProvider.AutoSize = true;
            this.lblProfilePhoneProvider.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfilePhoneProvider.Location = new System.Drawing.Point(23, 159);
            this.lblProfilePhoneProvider.Name = "lblProfilePhoneProvider";
            this.lblProfilePhoneProvider.Size = new System.Drawing.Size(97, 17);
            this.lblProfilePhoneProvider.TabIndex = 3;
            this.lblProfilePhoneProvider.Text = "Phone Number";
            // 
            // txtProfileNameProvider
            // 
            this.txtProfileNameProvider.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProfileNameProvider.Location = new System.Drawing.Point(23, 116);
            this.txtProfileNameProvider.Name = "txtProfileNameProvider";
            this.txtProfileNameProvider.Size = new System.Drawing.Size(352, 27);
            this.txtProfileNameProvider.TabIndex = 2;
            // 
            // lblProfileNameProvider
            // 
            this.lblProfileNameProvider.AutoSize = true;
            this.lblProfileNameProvider.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileNameProvider.Location = new System.Drawing.Point(23, 96);
            this.lblProfileNameProvider.Name = "lblProfileNameProvider";
            this.lblProfileNameProvider.Size = new System.Drawing.Size(107, 17);
            this.lblProfileNameProvider.TabIndex = 1;
            this.lblProfileNameProvider.Text = "Name / Business";
            // 
            // lblProfileTitleProvider
            // 
            this.lblProfileTitleProvider.AutoSize = true;
            this.lblProfileTitleProvider.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileTitleProvider.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblProfileTitleProvider.Location = new System.Drawing.Point(20, 20);
            this.lblProfileTitleProvider.Name = "lblProfileTitleProvider";
            this.lblProfileTitleProvider.Size = new System.Drawing.Size(147, 25);
            this.lblProfileTitleProvider.TabIndex = 0;
            this.lblProfileTitleProvider.Text = "My Provider Profile";
            // 
            // ProviderDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControlProvider);
            this.Controls.Add(this.btnLogoutProvider);
            this.Controls.Add(this.lblWelcomeProvider);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "ProviderDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OVSMS - Provider Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProviderDashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.ProviderDashboardForm_Load);
            this.tabControlProvider.ResumeLayout(false);
            this.tabBookings.ResumeLayout(false);
            this.panelBookingDetails.ResumeLayout(false);
            this.panelBookingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookingRequests)).EndInit();
            this.tabMyServices.ResumeLayout(false);
            this.tabMyServices.PerformLayout();
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.tabCompletedBookings.ResumeLayout(false);
            this.tabCompletedBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompletedBookings)).EndInit();
            this.tabProviderProfile.ResumeLayout(false);
            this.panelProviderProfile.ResumeLayout(false);
            this.panelProviderProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeProvider;
        private System.Windows.Forms.Button btnLogoutProvider;
        private System.Windows.Forms.TabControl tabControlProvider;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.TabPage tabMyServices;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.DataGridView dgvBookingRequests;
        private System.Windows.Forms.Button btnCompleteBooking;
        private System.Windows.Forms.Button btnAcceptBooking;
        private System.Windows.Forms.Label lblMyServicesInstruction;
        private System.Windows.Forms.CheckedListBox clbServices;
        private System.Windows.Forms.Button btnSaveMyServices;
        private System.Windows.Forms.Panel panelBookingDetails;
        private System.Windows.Forms.Label lblBookingDetailsTitle;
        private System.Windows.Forms.Label lblStaticCustomerName;
        private System.Windows.Forms.Label lblDetailCustomerName;
        private System.Windows.Forms.Label lblStaticCustomerPhone;
        private System.Windows.Forms.Label lblDetailCustomerPhone;
        private System.Windows.Forms.Label lblStaticVehicle;
        private System.Windows.Forms.Label lblDetailVehicle;
        private System.Windows.Forms.Label lblStaticService;
        private System.Windows.Forms.Label lblDetailServiceDesc;
        private System.Windows.Forms.Label lblStaticBookingDate;
        private System.Windows.Forms.Label lblDetailBookingDate;
        private System.Windows.Forms.Label lblStaticStatus;
        private System.Windows.Forms.Label lblDetailStatus;
        private System.Windows.Forms.Label lblScheduleInfo;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.TabPage tabProviderProfile;
        private System.Windows.Forms.Panel panelProviderProfile;
        private System.Windows.Forms.Button btnUpdateProviderProfile;
        private System.Windows.Forms.TextBox txtProfilePhoneProvider;
        private System.Windows.Forms.Label lblProfilePhoneProvider;
        private System.Windows.Forms.TextBox txtProfileNameProvider;
        private System.Windows.Forms.Label lblProfileNameProvider;
        private System.Windows.Forms.Label lblProfileTitleProvider;
        private System.Windows.Forms.Label lblDetailPaymentStatus;
        private System.Windows.Forms.Label lblStaticPaymentStatus;
        private System.Windows.Forms.TabPage tabCompletedBookings;
        private System.Windows.Forms.Label lblCompletedBookingsTitle;
        private System.Windows.Forms.DataGridView dgvCompletedBookings;
        private System.Windows.Forms.Button btnContactAdmin;
    }
}