namespace OVSMS_Desktop.Forms
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.btnLogoutAdmin = new System.Windows.Forms.Button();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.groupBoxStats = new System.Windows.Forms.GroupBox();
            this.lblTotalRevenueValue = new System.Windows.Forms.Label();
            this.lblBookingsMonthValue = new System.Windows.Forms.Label();
            this.lblPendingApprovalsValue = new System.Windows.Forms.Label();
            this.lblTotalProvidersValue = new System.Windows.Forms.Label();
            this.lblTotalCustomersValue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.lblBookingsMonth = new System.Windows.Forms.Label();
            this.lblPendingApprovals = new System.Windows.Forms.Label();
            this.lblTotalProviders = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.tabAllBookings = new System.Windows.Forms.TabPage();
            this.btnMarkAsPaidAdmin = new System.Windows.Forms.Button();
            this.btnCancelBookingAdmin = new System.Windows.Forms.Button();
            this.dgvAllBookings = new System.Windows.Forms.DataGridView();
            this.btnRefreshBookings = new System.Windows.Forms.Button();
            this.comboBookingStatusFilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProviderApproval = new System.Windows.Forms.TabPage();
            this.lblProviderApprovalInfo = new System.Windows.Forms.Label();
            this.btnRejectProvider = new System.Windows.Forms.Button();
            this.btnApproveProvider = new System.Windows.Forms.Button();
            this.dgvPendingProviders = new System.Windows.Forms.DataGridView();
            this.tabUserManagement = new System.Windows.Forms.TabPage();
            this.panelEditUser = new System.Windows.Forms.Panel();
            this.btnLoadUserDetails = new System.Windows.Forms.Button();
            this.lblSelectedUserId = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnSaveUserDetails = new System.Windows.Forms.Button();
            this.txtEditUserPhone = new System.Windows.Forms.TextBox();
            this.lblEditUserPhone = new System.Windows.Forms.Label();
            this.txtEditUserName = new System.Windows.Forms.TextBox();
            this.lblEditUserName = new System.Windows.Forms.Label();
            this.lblEditUserTitle = new System.Windows.Forms.Label();
            this.lblChangeRole = new System.Windows.Forms.Label();
            this.comboNewRole = new System.Windows.Forms.ComboBox();
            this.btnChangeRole = new System.Windows.Forms.Button();
            this.lblUserManagementInfo = new System.Windows.Forms.Label();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.dgvAllUsers = new System.Windows.Forms.DataGridView();
            this.tabServiceManagement = new System.Windows.Forms.TabPage();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.panelServiceForm = new System.Windows.Forms.Panel();
            this.btnClearServiceForm = new System.Windows.Forms.Button();
            this.lblEditingServiceId = new System.Windows.Forms.Label();
            this.btnSaveUpdateService = new System.Windows.Forms.Button();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.lblServicePrice = new System.Windows.Forms.Label();
            this.txtServiceCategory = new System.Windows.Forms.TextBox();
            this.lblServiceCategory = new System.Windows.Forms.Label();
            this.txtServiceDescription = new System.Windows.Forms.TextBox();
            this.lblServiceDescription = new System.Windows.Forms.Label();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.lblServiceName = new System.Windows.Forms.Label();
            this.lblAddEditService = new System.Windows.Forms.Label();
            this.tabTransactions = new System.Windows.Forms.TabPage();
            this.btnFilterPayments = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.tabControlAdmin.SuspendLayout();
            this.tabOverview.SuspendLayout();
            this.groupBoxStats.SuspendLayout();
            this.tabAllBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).BeginInit();
            this.tabProviderApproval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingProviders)).BeginInit();
            this.tabUserManagement.SuspendLayout();
            this.panelEditUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).BeginInit();
            this.tabServiceManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            this.panelServiceForm.SuspendLayout();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(24, 20);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(188, 30);
            this.lblWelcomeAdmin.TabIndex = 0;
            this.lblWelcomeAdmin.Text = "Welcome, Admin!";
            // 
            // btnLogoutAdmin
            // 
            this.btnLogoutAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogoutAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogoutAdmin.FlatAppearance.BorderSize = 0;
            this.btnLogoutAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogoutAdmin.ForeColor = System.Drawing.Color.White;
            this.btnLogoutAdmin.Location = new System.Drawing.Point(868, 20);
            this.btnLogoutAdmin.Name = "btnLogoutAdmin";
            this.btnLogoutAdmin.Size = new System.Drawing.Size(94, 35);
            this.btnLogoutAdmin.TabIndex = 1;
            this.btnLogoutAdmin.Text = "Logout";
            this.btnLogoutAdmin.UseVisualStyleBackColor = false;
            this.btnLogoutAdmin.Click += new System.EventHandler(this.btnLogoutAdmin_Click);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdmin.Controls.Add(this.tabOverview);
            this.tabControlAdmin.Controls.Add(this.tabAllBookings);
            this.tabControlAdmin.Controls.Add(this.tabProviderApproval);
            this.tabControlAdmin.Controls.Add(this.tabUserManagement);
            this.tabControlAdmin.Controls.Add(this.tabServiceManagement);
            this.tabControlAdmin.Controls.Add(this.tabTransactions);
            this.tabControlAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlAdmin.Location = new System.Drawing.Point(24, 69);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(938, 569);
            this.tabControlAdmin.TabIndex = 2;
            this.tabControlAdmin.SelectedIndexChanged += new System.EventHandler(this.tabControlAdmin_SelectedIndexChanged);
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.groupBoxStats);
            this.tabOverview.Location = new System.Drawing.Point(4, 26);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(15);
            this.tabOverview.Size = new System.Drawing.Size(930, 539);
            this.tabOverview.TabIndex = 3;
            this.tabOverview.Text = "Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // groupBoxStats
            // 
            this.groupBoxStats.Controls.Add(this.lblTotalRevenueValue);
            this.groupBoxStats.Controls.Add(this.lblBookingsMonthValue);
            this.groupBoxStats.Controls.Add(this.lblPendingApprovalsValue);
            this.groupBoxStats.Controls.Add(this.lblTotalProvidersValue);
            this.groupBoxStats.Controls.Add(this.lblTotalCustomersValue);
            this.groupBoxStats.Controls.Add(this.lblTotalRevenue);
            this.groupBoxStats.Controls.Add(this.lblBookingsMonth);
            this.groupBoxStats.Controls.Add(this.lblPendingApprovals);
            this.groupBoxStats.Controls.Add(this.lblTotalProviders);
            this.groupBoxStats.Controls.Add(this.lblTotalCustomers);
            this.groupBoxStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxStats.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.groupBoxStats.Location = new System.Drawing.Point(15, 15);
            this.groupBoxStats.Name = "groupBoxStats";
            this.groupBoxStats.Size = new System.Drawing.Size(900, 150);
            this.groupBoxStats.TabIndex = 0;
            this.groupBoxStats.TabStop = false;
            this.groupBoxStats.Text = "System Overview";
            // 
            // lblTotalRevenueValue
            // 
            this.lblTotalRevenueValue.AutoSize = true;
            this.lblTotalRevenueValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenueValue.Location = new System.Drawing.Point(200, 105);
            this.lblTotalRevenueValue.Name = "lblTotalRevenueValue";
            this.lblTotalRevenueValue.Size = new System.Drawing.Size(28, 21);
            this.lblTotalRevenueValue.TabIndex = 9;
            this.lblTotalRevenueValue.Text = "₹0";
            // 
            // lblBookingsMonthValue
            // 
            this.lblBookingsMonthValue.AutoSize = true;
            this.lblBookingsMonthValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBookingsMonthValue.Location = new System.Drawing.Point(200, 70);
            this.lblBookingsMonthValue.Name = "lblBookingsMonthValue";
            this.lblBookingsMonthValue.Size = new System.Drawing.Size(19, 21);
            this.lblBookingsMonthValue.TabIndex = 8;
            this.lblBookingsMonthValue.Text = "0";
            // 
            // lblPendingApprovalsValue
            // 
            this.lblPendingApprovalsValue.AutoSize = true;
            this.lblPendingApprovalsValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPendingApprovalsValue.Location = new System.Drawing.Point(650, 70);
            this.lblPendingApprovalsValue.Name = "lblPendingApprovalsValue";
            this.lblPendingApprovalsValue.Size = new System.Drawing.Size(19, 21);
            this.lblPendingApprovalsValue.TabIndex = 7;
            this.lblPendingApprovalsValue.Text = "0";
            // 
            // lblTotalProvidersValue
            // 
            this.lblTotalProvidersValue.AutoSize = true;
            this.lblTotalProvidersValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalProvidersValue.Location = new System.Drawing.Point(650, 35);
            this.lblTotalProvidersValue.Name = "lblTotalProvidersValue";
            this.lblTotalProvidersValue.Size = new System.Drawing.Size(19, 21);
            this.lblTotalProvidersValue.TabIndex = 6;
            this.lblTotalProvidersValue.Text = "0";
            // 
            // lblTotalCustomersValue
            // 
            this.lblTotalCustomersValue.AutoSize = true;
            this.lblTotalCustomersValue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomersValue.Location = new System.Drawing.Point(200, 35);
            this.lblTotalCustomersValue.Name = "lblTotalCustomersValue";
            this.lblTotalCustomersValue.Size = new System.Drawing.Size(19, 21);
            this.lblTotalCustomersValue.TabIndex = 5;
            this.lblTotalCustomersValue.Text = "0";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalRevenue.Location = new System.Drawing.Point(20, 105);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(107, 20);
            this.lblTotalRevenue.TabIndex = 4;
            this.lblTotalRevenue.Text = "Total Revenue:";
            // 
            // lblBookingsMonth
            // 
            this.lblBookingsMonth.AutoSize = true;
            this.lblBookingsMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblBookingsMonth.Location = new System.Drawing.Point(20, 70);
            this.lblBookingsMonth.Name = "lblBookingsMonth";
            this.lblBookingsMonth.Size = new System.Drawing.Size(135, 20);
            this.lblBookingsMonth.TabIndex = 3;
            this.lblBookingsMonth.Text = "Bookings (Month):";
            // 
            // lblPendingApprovals
            // 
            this.lblPendingApprovals.AutoSize = true;
            this.lblPendingApprovals.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPendingApprovals.Location = new System.Drawing.Point(470, 70);
            this.lblPendingApprovals.Name = "lblPendingApprovals";
            this.lblPendingApprovals.Size = new System.Drawing.Size(140, 20);
            this.lblPendingApprovals.TabIndex = 2;
            this.lblPendingApprovals.Text = "Pending Approvals:";
            // 
            // lblTotalProviders
            // 
            this.lblTotalProviders.AutoSize = true;
            this.lblTotalProviders.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalProviders.Location = new System.Drawing.Point(470, 35);
            this.lblTotalProviders.Name = "lblTotalProviders";
            this.lblTotalProviders.Size = new System.Drawing.Size(150, 20);
            this.lblTotalProviders.TabIndex = 1;
            this.lblTotalProviders.Text = "Approved Providers:";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalCustomers.Location = new System.Drawing.Point(20, 35);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(124, 20);
            this.lblTotalCustomers.TabIndex = 0;
            this.lblTotalCustomers.Text = "Total Customers:";
            // 
            // tabAllBookings
            // 
            this.tabAllBookings.Controls.Add(this.btnMarkAsPaidAdmin);
            this.tabAllBookings.Controls.Add(this.btnCancelBookingAdmin);
            this.tabAllBookings.Controls.Add(this.dgvAllBookings);
            this.tabAllBookings.Controls.Add(this.btnRefreshBookings);
            this.tabAllBookings.Controls.Add(this.comboBookingStatusFilter);
            this.tabAllBookings.Controls.Add(this.label1);
            this.tabAllBookings.Location = new System.Drawing.Point(4, 26);
            this.tabAllBookings.Name = "tabAllBookings";
            this.tabAllBookings.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllBookings.Size = new System.Drawing.Size(930, 539);
            this.tabAllBookings.TabIndex = 4;
            this.tabAllBookings.Text = "All Bookings";
            this.tabAllBookings.UseVisualStyleBackColor = true;
            // 
            // btnMarkAsPaidAdmin
            // 
            this.btnMarkAsPaidAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMarkAsPaidAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnMarkAsPaidAdmin.FlatAppearance.BorderSize = 0;
            this.btnMarkAsPaidAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkAsPaidAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnMarkAsPaidAdmin.ForeColor = System.Drawing.Color.White;
            this.btnMarkAsPaidAdmin.Location = new System.Drawing.Point(589, 487);
            this.btnMarkAsPaidAdmin.Name = "btnMarkAsPaidAdmin";
            this.btnMarkAsPaidAdmin.Size = new System.Drawing.Size(164, 35);
            this.btnMarkAsPaidAdmin.TabIndex = 5;
            this.btnMarkAsPaidAdmin.Text = "Mark as Paid";
            this.btnMarkAsPaidAdmin.UseVisualStyleBackColor = false;
            this.btnMarkAsPaidAdmin.Click += new System.EventHandler(this.btnMarkAsPaidAdmin_Click);
            // 
            // btnCancelBookingAdmin
            // 
            this.btnCancelBookingAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBookingAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelBookingAdmin.FlatAppearance.BorderSize = 0;
            this.btnCancelBookingAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBookingAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelBookingAdmin.ForeColor = System.Drawing.Color.White;
            this.btnCancelBookingAdmin.Location = new System.Drawing.Point(759, 487);
            this.btnCancelBookingAdmin.Name = "btnCancelBookingAdmin";
            this.btnCancelBookingAdmin.Size = new System.Drawing.Size(164, 35);
            this.btnCancelBookingAdmin.TabIndex = 4;
            this.btnCancelBookingAdmin.Text = "Cancel Selected Booking";
            this.btnCancelBookingAdmin.UseVisualStyleBackColor = false;
            this.btnCancelBookingAdmin.Click += new System.EventHandler(this.btnCancelBookingAdmin_Click);
            // 
            // dgvAllBookings
            // 
            this.dgvAllBookings.AllowUserToAddRows = false;
            this.dgvAllBookings.AllowUserToDeleteRows = false;
            this.dgvAllBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvAllBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllBookings.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAllBookings.Location = new System.Drawing.Point(7, 48);
            this.dgvAllBookings.MultiSelect = false;
            this.dgvAllBookings.Name = "dgvAllBookings";
            this.dgvAllBookings.ReadOnly = true;
            this.dgvAllBookings.RowHeadersVisible = false;
            this.dgvAllBookings.RowTemplate.Height = 35;
            this.dgvAllBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllBookings.Size = new System.Drawing.Size(916, 424);
            this.dgvAllBookings.TabIndex = 3;
            this.dgvAllBookings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvAllBookings_CellFormatting);
            // 
            // btnRefreshBookings
            // 
            this.btnRefreshBookings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRefreshBookings.Location = new System.Drawing.Point(280, 14);
            this.btnRefreshBookings.Name = "btnRefreshBookings";
            this.btnRefreshBookings.Size = new System.Drawing.Size(120, 28);
            this.btnRefreshBookings.TabIndex = 2;
            this.btnRefreshBookings.Text = "Refresh / Filter";
            this.btnRefreshBookings.UseVisualStyleBackColor = true;
            this.btnRefreshBookings.Click += new System.EventHandler(this.btnRefreshBookings_Click);
            // 
            // comboBookingStatusFilter
            // 
            this.comboBookingStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBookingStatusFilter.FormattingEnabled = true;
            this.comboBookingStatusFilter.Location = new System.Drawing.Point(125, 16);
            this.comboBookingStatusFilter.Name = "comboBookingStatusFilter";
            this.comboBookingStatusFilter.Size = new System.Drawing.Size(140, 25);
            this.comboBookingStatusFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter by Status:";
            // 
            // tabProviderApproval
            // 
            this.tabProviderApproval.Controls.Add(this.lblProviderApprovalInfo);
            this.tabProviderApproval.Controls.Add(this.btnRejectProvider);
            this.tabProviderApproval.Controls.Add(this.btnApproveProvider);
            this.tabProviderApproval.Controls.Add(this.dgvPendingProviders);
            this.tabProviderApproval.Location = new System.Drawing.Point(4, 26);
            this.tabProviderApproval.Name = "tabProviderApproval";
            this.tabProviderApproval.Padding = new System.Windows.Forms.Padding(15);
            this.tabProviderApproval.Size = new System.Drawing.Size(930, 539);
            this.tabProviderApproval.TabIndex = 0;
            this.tabProviderApproval.Text = "Provider Approval";
            this.tabProviderApproval.UseVisualStyleBackColor = true;
            // 
            // lblProviderApprovalInfo
            // 
            this.lblProviderApprovalInfo.AutoSize = true;
            this.lblProviderApprovalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProviderApprovalInfo.Location = new System.Drawing.Point(18, 18);
            this.lblProviderApprovalInfo.Name = "lblProviderApprovalInfo";
            this.lblProviderApprovalInfo.Size = new System.Drawing.Size(393, 20);
            this.lblProviderApprovalInfo.TabIndex = 3;
            this.lblProviderApprovalInfo.Text = "Select a provider from the list below to approve or reject:";
            // 
            // btnRejectProvider
            // 
            this.btnRejectProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRejectProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnRejectProvider.FlatAppearance.BorderSize = 0;
            this.btnRejectProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectProvider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnRejectProvider.ForeColor = System.Drawing.Color.White;
            this.btnRejectProvider.Location = new System.Drawing.Point(748, 486);
            this.btnRejectProvider.Name = "btnRejectProvider";
            this.btnRejectProvider.Size = new System.Drawing.Size(164, 35);
            this.btnRejectProvider.TabIndex = 2;
            this.btnRejectProvider.Text = "Reject Provider";
            this.btnRejectProvider.UseVisualStyleBackColor = false;
            this.btnRejectProvider.Click += new System.EventHandler(this.btnRejectProvider_Click);
            // 
            // btnApproveProvider
            // 
            this.btnApproveProvider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApproveProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnApproveProvider.FlatAppearance.BorderSize = 0;
            this.btnApproveProvider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveProvider.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnApproveProvider.ForeColor = System.Drawing.Color.White;
            this.btnApproveProvider.Location = new System.Drawing.Point(578, 486);
            this.btnApproveProvider.Name = "btnApproveProvider";
            this.btnApproveProvider.Size = new System.Drawing.Size(164, 35);
            this.btnApproveProvider.TabIndex = 1;
            this.btnApproveProvider.Text = "Approve Provider";
            this.btnApproveProvider.UseVisualStyleBackColor = false;
            this.btnApproveProvider.Click += new System.EventHandler(this.btnApproveProvider_Click);
            // 
            // dgvPendingProviders
            // 
            this.dgvPendingProviders.AllowUserToAddRows = false;
            this.dgvPendingProviders.AllowUserToDeleteRows = false;
            this.dgvPendingProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPendingProviders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPendingProviders.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPendingProviders.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPendingProviders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPendingProviders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPendingProviders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPendingProviders.Location = new System.Drawing.Point(18, 48);
            this.dgvPendingProviders.MultiSelect = false;
            this.dgvPendingProviders.Name = "dgvPendingProviders";
            this.dgvPendingProviders.ReadOnly = true;
            this.dgvPendingProviders.RowHeadersVisible = false;
            this.dgvPendingProviders.RowTemplate.Height = 35;
            this.dgvPendingProviders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingProviders.Size = new System.Drawing.Size(894, 432);
            this.dgvPendingProviders.TabIndex = 0;
            // 
            // tabUserManagement
            // 
            this.tabUserManagement.Controls.Add(this.panelEditUser);
            this.tabUserManagement.Controls.Add(this.lblChangeRole);
            this.tabUserManagement.Controls.Add(this.comboNewRole);
            this.tabUserManagement.Controls.Add(this.btnChangeRole);
            this.tabUserManagement.Controls.Add(this.lblUserManagementInfo);
            this.tabUserManagement.Controls.Add(this.btnDeleteUser);
            this.tabUserManagement.Controls.Add(this.dgvAllUsers);
            this.tabUserManagement.Location = new System.Drawing.Point(4, 26);
            this.tabUserManagement.Name = "tabUserManagement";
            this.tabUserManagement.Padding = new System.Windows.Forms.Padding(15);
            this.tabUserManagement.Size = new System.Drawing.Size(930, 539);
            this.tabUserManagement.TabIndex = 1;
            this.tabUserManagement.Text = "User Management";
            this.tabUserManagement.UseVisualStyleBackColor = true;
            // 
            // panelEditUser
            // 
            this.panelEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelEditUser.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelEditUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEditUser.Controls.Add(this.btnLoadUserDetails);
            this.panelEditUser.Controls.Add(this.lblSelectedUserId);
            this.panelEditUser.Controls.Add(this.btnResetPassword);
            this.panelEditUser.Controls.Add(this.txtNewPassword);
            this.panelEditUser.Controls.Add(this.lblNewPassword);
            this.panelEditUser.Controls.Add(this.btnSaveUserDetails);
            this.panelEditUser.Controls.Add(this.txtEditUserPhone);
            this.panelEditUser.Controls.Add(this.lblEditUserPhone);
            this.panelEditUser.Controls.Add(this.txtEditUserName);
            this.panelEditUser.Controls.Add(this.lblEditUserName);
            this.panelEditUser.Controls.Add(this.lblEditUserTitle);
            this.panelEditUser.Location = new System.Drawing.Point(632, 48);
            this.panelEditUser.Name = "panelEditUser";
            this.panelEditUser.Padding = new System.Windows.Forms.Padding(15);
            this.panelEditUser.Size = new System.Drawing.Size(280, 432);
            this.panelEditUser.TabIndex = 7;
            // 
            // btnLoadUserDetails
            // 
            this.btnLoadUserDetails.BackColor = System.Drawing.Color.DarkGray;
            this.btnLoadUserDetails.FlatAppearance.BorderSize = 0;
            this.btnLoadUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadUserDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnLoadUserDetails.ForeColor = System.Drawing.Color.Black;
            this.btnLoadUserDetails.Location = new System.Drawing.Point(18, 55);
            this.btnLoadUserDetails.Name = "btnLoadUserDetails";
            this.btnLoadUserDetails.Size = new System.Drawing.Size(242, 30);
            this.btnLoadUserDetails.TabIndex = 1;
            this.btnLoadUserDetails.Text = "Load Selected User\'s Details";
            this.btnLoadUserDetails.UseVisualStyleBackColor = false;
            this.btnLoadUserDetails.Click += new System.EventHandler(this.btnLoadUserDetails_Click);
            // 
            // lblSelectedUserId
            // 
            this.lblSelectedUserId.AutoSize = true;
            this.lblSelectedUserId.Location = new System.Drawing.Point(247, 15);
            this.lblSelectedUserId.Name = "lblSelectedUserId";
            this.lblSelectedUserId.Size = new System.Drawing.Size(15, 17);
            this.lblSelectedUserId.TabIndex = 9;
            this.lblSelectedUserId.Text = "0";
            this.lblSelectedUserId.Visible = false;
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnResetPassword.FlatAppearance.BorderSize = 0;
            this.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnResetPassword.ForeColor = System.Drawing.Color.Black;
            this.btnResetPassword.Location = new System.Drawing.Point(18, 375);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(242, 35);
            this.btnResetPassword.TabIndex = 8;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = false;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtNewPassword.Location = new System.Drawing.Point(18, 335);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderText = "Enter new password to reset";
            this.txtNewPassword.Size = new System.Drawing.Size(242, 27);
            this.txtNewPassword.TabIndex = 7;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.Location = new System.Drawing.Point(18, 315);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(126, 17);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Reset Password To:";
            // 
            // btnSaveUserDetails
            // 
            this.btnSaveUserDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnSaveUserDetails.FlatAppearance.BorderSize = 0;
            this.btnSaveUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUserDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSaveUserDetails.ForeColor = System.Drawing.Color.White;
            this.btnSaveUserDetails.Location = new System.Drawing.Point(18, 260);
            this.btnSaveUserDetails.Name = "btnSaveUserDetails";
            this.btnSaveUserDetails.Size = new System.Drawing.Size(242, 35);
            this.btnSaveUserDetails.TabIndex = 5;
            this.btnSaveUserDetails.Text = "Save User Details";
            this.btnSaveUserDetails.UseVisualStyleBackColor = false;
            this.btnSaveUserDetails.Click += new System.EventHandler(this.btnSaveUserDetails_Click);
            // 
            // txtEditUserPhone
            // 
            this.txtEditUserPhone.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtEditUserPhone.Location = new System.Drawing.Point(18, 215);
            this.txtEditUserPhone.Name = "txtEditUserPhone";
            this.txtEditUserPhone.Size = new System.Drawing.Size(242, 27);
            this.txtEditUserPhone.TabIndex = 4;
            // 
            // lblEditUserPhone
            // 
            this.lblEditUserPhone.AutoSize = true;
            this.lblEditUserPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEditUserPhone.Location = new System.Drawing.Point(18, 195);
            this.lblEditUserPhone.Name = "lblEditUserPhone";
            this.lblEditUserPhone.Size = new System.Drawing.Size(97, 17);
            this.lblEditUserPhone.TabIndex = 3;
            this.lblEditUserPhone.Text = "Phone Number";
            // 
            // txtEditUserName
            // 
            this.txtEditUserName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtEditUserName.Location = new System.Drawing.Point(18, 155);
            this.txtEditUserName.Name = "txtEditUserName";
            this.txtEditUserName.Size = new System.Drawing.Size(242, 27);
            this.txtEditUserName.TabIndex = 2;
            // 
            // lblEditUserName
            // 
            this.lblEditUserName.AutoSize = true;
            this.lblEditUserName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblEditUserName.Location = new System.Drawing.Point(18, 135);
            this.lblEditUserName.Name = "lblEditUserName";
            this.lblEditUserName.Size = new System.Drawing.Size(66, 17);
            this.lblEditUserName.TabIndex = 1;
            this.lblEditUserName.Text = "Full Name";
            // 
            // lblEditUserTitle
            // 
            this.lblEditUserTitle.AutoSize = true;
            this.lblEditUserTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblEditUserTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblEditUserTitle.Location = new System.Drawing.Point(15, 15);
            this.lblEditUserTitle.Name = "lblEditUserTitle";
            this.lblEditUserTitle.Size = new System.Drawing.Size(126, 21);
            this.lblEditUserTitle.TabIndex = 0;
            this.lblEditUserTitle.Text = "Edit User Details";
            // 
            // lblChangeRole
            // 
            this.lblChangeRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChangeRole.AutoSize = true;
            this.lblChangeRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblChangeRole.Location = new System.Drawing.Point(18, 495);
            this.lblChangeRole.Name = "lblChangeRole";
            this.lblChangeRole.Size = new System.Drawing.Size(88, 17);
            this.lblChangeRole.TabIndex = 6;
            this.lblChangeRole.Text = "Set New Role:";
            // 
            // comboNewRole
            // 
            this.comboNewRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboNewRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNewRole.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboNewRole.FormattingEnabled = true;
            this.comboNewRole.Location = new System.Drawing.Point(112, 491);
            this.comboNewRole.Name = "comboNewRole";
            this.comboNewRole.Size = new System.Drawing.Size(121, 25);
            this.comboNewRole.TabIndex = 5;
            // 
            // btnChangeRole
            // 
            this.btnChangeRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnChangeRole.FlatAppearance.BorderSize = 0;
            this.btnChangeRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeRole.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnChangeRole.ForeColor = System.Drawing.Color.White;
            this.btnChangeRole.Location = new System.Drawing.Point(242, 486);
            this.btnChangeRole.Name = "btnChangeRole";
            this.btnChangeRole.Size = new System.Drawing.Size(121, 35);
            this.btnChangeRole.TabIndex = 1;
            this.btnChangeRole.Text = "Change Role";
            this.btnChangeRole.UseVisualStyleBackColor = false;
            this.btnChangeRole.Click += new System.EventHandler(this.btnChangeRole_Click);
            // 
            // lblUserManagementInfo
            // 
            this.lblUserManagementInfo.AutoSize = true;
            this.lblUserManagementInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserManagementInfo.Location = new System.Drawing.Point(18, 18);
            this.lblUserManagementInfo.Name = "lblUserManagementInfo";
            this.lblUserManagementInfo.Size = new System.Drawing.Size(425, 20);
            this.lblUserManagementInfo.TabIndex = 4;
            this.lblUserManagementInfo.Text = "Select a user from the list below to manage their account:";
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteUser.FlatAppearance.BorderSize = 0;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(748, 486);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(164, 35);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "Delete Selected User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // dgvAllUsers
            // 
            this.dgvAllUsers.AllowUserToAddRows = false;
            this.dgvAllUsers.AllowUserToDeleteRows = false;
            this.dgvAllUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAllUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllUsers.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAllUsers.Location = new System.Drawing.Point(18, 48);
            this.dgvAllUsers.MultiSelect = false;
            this.dgvAllUsers.Name = "dgvAllUsers";
            this.dgvAllUsers.ReadOnly = true;
            this.dgvAllUsers.RowHeadersVisible = false;
            this.dgvAllUsers.RowTemplate.Height = 35;
            this.dgvAllUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllUsers.Size = new System.Drawing.Size(600, 432);
            this.dgvAllUsers.TabIndex = 0;
            // 
            // tabServiceManagement
            // 
            this.tabServiceManagement.Controls.Add(this.btnDeleteService);
            this.tabServiceManagement.Controls.Add(this.dgvServices);
            this.tabServiceManagement.Controls.Add(this.panelServiceForm);
            this.tabServiceManagement.Location = new System.Drawing.Point(4, 26);
            this.tabServiceManagement.Name = "tabServiceManagement";
            this.tabServiceManagement.Padding = new System.Windows.Forms.Padding(15);
            this.tabServiceManagement.Size = new System.Drawing.Size(930, 539);
            this.tabServiceManagement.TabIndex = 2;
            this.tabServiceManagement.Text = "Service Management";
            this.tabServiceManagement.UseVisualStyleBackColor = true;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteService.FlatAppearance.BorderSize = 0;
            this.btnDeleteService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteService.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteService.ForeColor = System.Drawing.Color.White;
            this.btnDeleteService.Location = new System.Drawing.Point(748, 486);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(164, 35);
            this.btnDeleteService.TabIndex = 9;
            this.btnDeleteService.Text = "Delete Selected Service";
            this.btnDeleteService.UseVisualStyleBackColor = false;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvServices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvServices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvServices.Location = new System.Drawing.Point(365, 18);
            this.dgvServices.MultiSelect = false;
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersVisible = false;
            this.dgvServices.RowTemplate.Height = 35;
            this.dgvServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServices.Size = new System.Drawing.Size(547, 462);
            this.dgvServices.TabIndex = 10;
            this.dgvServices.SelectionChanged += new System.EventHandler(this.dgvServices_SelectionChanged);
            // 
            // panelServiceForm
            // 
            this.panelServiceForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelServiceForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelServiceForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelServiceForm.Controls.Add(this.btnClearServiceForm);
            this.panelServiceForm.Controls.Add(this.lblEditingServiceId);
            this.panelServiceForm.Controls.Add(this.btnSaveUpdateService);
            this.panelServiceForm.Controls.Add(this.txtServicePrice);
            this.panelServiceForm.Controls.Add(this.lblServicePrice);
            this.panelServiceForm.Controls.Add(this.txtServiceCategory);
            this.panelServiceForm.Controls.Add(this.lblServiceCategory);
            this.panelServiceForm.Controls.Add(this.txtServiceDescription);
            this.panelServiceForm.Controls.Add(this.lblServiceDescription);
            this.panelServiceForm.Controls.Add(this.txtServiceName);
            this.panelServiceForm.Controls.Add(this.lblServiceName);
            this.panelServiceForm.Controls.Add(this.lblAddEditService);
            this.panelServiceForm.Location = new System.Drawing.Point(18, 18);
            this.panelServiceForm.Name = "panelServiceForm";
            this.panelServiceForm.Padding = new System.Windows.Forms.Padding(15);
            this.panelServiceForm.Size = new System.Drawing.Size(330, 503);
            this.panelServiceForm.TabIndex = 0;
            // 
            // btnClearServiceForm
            // 
            this.btnClearServiceForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClearServiceForm.FlatAppearance.BorderSize = 0;
            this.btnClearServiceForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearServiceForm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearServiceForm.ForeColor = System.Drawing.Color.White;
            this.btnClearServiceForm.Location = new System.Drawing.Point(18, 442);
            this.btnClearServiceForm.Name = "btnClearServiceForm";
            this.btnClearServiceForm.Size = new System.Drawing.Size(292, 35);
            this.btnClearServiceForm.TabIndex = 10;
            this.btnClearServiceForm.Text = "Clear / New Service";
            this.btnClearServiceForm.UseVisualStyleBackColor = false;
            this.btnClearServiceForm.Click += new System.EventHandler(this.btnClearServiceForm_Click);
            // 
            // lblEditingServiceId
            // 
            this.lblEditingServiceId.AutoSize = true;
            this.lblEditingServiceId.Location = new System.Drawing.Point(18, 480);
            this.lblEditingServiceId.Name = "lblEditingServiceId";
            this.lblEditingServiceId.Size = new System.Drawing.Size(15, 17);
            this.lblEditingServiceId.TabIndex = 9;
            this.lblEditingServiceId.Text = "0";
            this.lblEditingServiceId.Visible = false;
            // 
            // btnSaveUpdateService
            // 
            this.btnSaveUpdateService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnSaveUpdateService.FlatAppearance.BorderSize = 0;
            this.btnSaveUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdateService.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUpdateService.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpdateService.Location = new System.Drawing.Point(18, 391);
            this.btnSaveUpdateService.Name = "btnSaveUpdateService";
            this.btnSaveUpdateService.Size = new System.Drawing.Size(292, 45);
            this.btnSaveUpdateService.TabIndex = 9;
            this.btnSaveUpdateService.Text = "Save Service";
            this.btnSaveUpdateService.UseVisualStyleBackColor = false;
            this.btnSaveUpdateService.Click += new System.EventHandler(this.btnSaveUpdateService_Click);
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServicePrice.Location = new System.Drawing.Point(18, 345);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.PlaceholderText = "e.g. 999.00";
            this.txtServicePrice.Size = new System.Drawing.Size(292, 27);
            this.txtServicePrice.TabIndex = 7;
            // 
            // lblServicePrice
            // 
            this.lblServicePrice.AutoSize = true;
            this.lblServicePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServicePrice.Location = new System.Drawing.Point(18, 325);
            this.lblServicePrice.Name = "lblServicePrice";
            this.lblServicePrice.Size = new System.Drawing.Size(68, 17);
            this.lblServicePrice.TabIndex = 6;
            this.lblServicePrice.Text = "Base Price";
            // 
            // txtServiceCategory
            // 
            this.txtServiceCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServiceCategory.Location = new System.Drawing.Point(18, 282);
            this.txtServiceCategory.Name = "txtServiceCategory";
            this.txtServiceCategory.PlaceholderText = "e.g. Maintenance, Repairs";
            this.txtServiceCategory.Size = new System.Drawing.Size(292, 27);
            this.txtServiceCategory.TabIndex = 6;
            // 
            // lblServiceCategory
            // 
            this.lblServiceCategory.AutoSize = true;
            this.lblServiceCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServiceCategory.Location = new System.Drawing.Point(18, 262);
            this.lblServiceCategory.Name = "lblServiceCategory";
            this.lblServiceCategory.Size = new System.Drawing.Size(61, 17);
            this.lblServiceCategory.TabIndex = 4;
            this.lblServiceCategory.Text = "Category";
            // 
            // txtServiceDescription
            // 
            this.txtServiceDescription.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServiceDescription.Location = new System.Drawing.Point(18, 155);
            this.txtServiceDescription.Multiline = true;
            this.txtServiceDescription.Name = "txtServiceDescription";
            this.txtServiceDescription.PlaceholderText = "Detailed description of the service...";
            this.txtServiceDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtServiceDescription.Size = new System.Drawing.Size(292, 85);
            this.txtServiceDescription.TabIndex = 3;
            // 
            // lblServiceDescription
            // 
            this.lblServiceDescription.AutoSize = true;
            this.lblServiceDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServiceDescription.Location = new System.Drawing.Point(18, 135);
            this.lblServiceDescription.Name = "lblServiceDescription";
            this.lblServiceDescription.Size = new System.Drawing.Size(76, 17);
            this.lblServiceDescription.TabIndex = 2;
            this.lblServiceDescription.Text = "Description";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServiceName.Location = new System.Drawing.Point(18, 92);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PlaceholderText = "e.g. Regular Maintenance";
            this.txtServiceName.Size = new System.Drawing.Size(292, 27);
            this.txtServiceName.TabIndex = 1;
            // 
            // lblServiceName
            // 
            this.lblServiceName.AutoSize = true;
            this.lblServiceName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblServiceName.Location = new System.Drawing.Point(18, 72);
            this.lblServiceName.Name = "lblServiceName";
            this.lblServiceName.Size = new System.Drawing.Size(90, 17);
            this.lblServiceName.TabIndex = 0;
            this.lblServiceName.Text = "Service Name";
            // 
            // lblAddEditService
            // 
            this.lblAddEditService.AutoSize = true;
            this.lblAddEditService.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddEditService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblAddEditService.Location = new System.Drawing.Point(15, 15);
            this.lblAddEditService.Name = "lblAddEditService";
            this.lblAddEditService.Size = new System.Drawing.Size(161, 25);
            this.lblAddEditService.TabIndex = 0;
            this.lblAddEditService.Text = "Add / Edit Service";
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.btnFilterPayments);
            this.tabTransactions.Controls.Add(this.dtpEndDate);
            this.tabTransactions.Controls.Add(this.label3);
            this.tabTransactions.Controls.Add(this.dtpStartDate);
            this.tabTransactions.Controls.Add(this.label2);
            this.tabTransactions.Controls.Add(this.dgvPayments);
            this.tabTransactions.Location = new System.Drawing.Point(4, 26);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Padding = new System.Windows.Forms.Padding(15);
            this.tabTransactions.Size = new System.Drawing.Size(930, 539);
            this.tabTransactions.TabIndex = 5;
            this.tabTransactions.Text = "Transactions";
            this.tabTransactions.UseVisualStyleBackColor = true;
            // 
            // btnFilterPayments
            // 
            this.btnFilterPayments.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnFilterPayments.Location = new System.Drawing.Point(468, 18);
            this.btnFilterPayments.Name = "btnFilterPayments";
            this.btnFilterPayments.Size = new System.Drawing.Size(120, 28);
            this.btnFilterPayments.TabIndex = 5;
            this.btnFilterPayments.Text = "Filter by Date";
            this.btnFilterPayments.UseVisualStyleBackColor = true;
            this.btnFilterPayments.Click += new System.EventHandler(this.btnFilterPayments_Click);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(269, 18);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(175, 25);
            this.dtpEndDate.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(238, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "To:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(59, 18);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(175, 25);
            this.dtpStartDate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "From:";
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayments.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPayments.Location = new System.Drawing.Point(15, 60);
            this.dgvPayments.MultiSelect = false;
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersVisible = false;
            this.dgvPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayments.Size = new System.Drawing.Size(900, 464);
            this.dgvPayments.TabIndex = 0;
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.btnLogoutAdmin);
            this.Controls.Add(this.lblWelcomeAdmin);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OVSMS - Admin Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabOverview.ResumeLayout(false);
            this.groupBoxStats.ResumeLayout(false);
            this.groupBoxStats.PerformLayout();
            this.tabAllBookings.ResumeLayout(false);
            this.tabAllBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBookings)).EndInit();
            this.tabProviderApproval.ResumeLayout(false);
            this.tabProviderApproval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingProviders)).EndInit();
            this.tabUserManagement.ResumeLayout(false);
            this.tabUserManagement.PerformLayout();
            this.panelEditUser.ResumeLayout(false);
            this.panelEditUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllUsers)).EndInit();
            this.tabServiceManagement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            this.panelServiceForm.ResumeLayout(false);
            this.panelServiceForm.PerformLayout();
            this.tabTransactions.ResumeLayout(false);
            this.tabTransactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Button btnLogoutAdmin;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabProviderApproval;
        private System.Windows.Forms.TabPage tabUserManagement;
        private System.Windows.Forms.Button btnRejectProvider;
        private System.Windows.Forms.Button btnApproveProvider;
        private System.Windows.Forms.DataGridView dgvPendingProviders;
        private System.Windows.Forms.Label lblProviderApprovalInfo;
        private System.Windows.Forms.Label lblUserManagementInfo;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.DataGridView dgvAllUsers;
        private System.Windows.Forms.TabPage tabServiceManagement;
        private System.Windows.Forms.Panel panelServiceForm;
        private System.Windows.Forms.Button btnClearServiceForm;
        private System.Windows.Forms.Label lblEditingServiceId;
        private System.Windows.Forms.Button btnSaveUpdateService;
        private System.Windows.Forms.TextBox txtServicePrice;
        private System.Windows.Forms.Label lblServicePrice;
        private System.Windows.Forms.TextBox txtServiceCategory;
        private System.Windows.Forms.Label lblServiceCategory;
        private System.Windows.Forms.TextBox txtServiceDescription;
        private System.Windows.Forms.Label lblServiceDescription;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label lblServiceName;
        private System.Windows.Forms.Label lblAddEditService;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnChangeRole;
        private System.Windows.Forms.ComboBox comboNewRole;
        private System.Windows.Forms.Label lblChangeRole;
        private System.Windows.Forms.Panel panelEditUser;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnSaveUserDetails;
        private System.Windows.Forms.TextBox txtEditUserPhone;
        private System.Windows.Forms.Label lblEditUserPhone;
        private System.Windows.Forms.TextBox txtEditUserName;
        private System.Windows.Forms.Label lblEditUserName;
        private System.Windows.Forms.Label lblEditUserTitle;
        private System.Windows.Forms.Label lblSelectedUserId;
        private System.Windows.Forms.Button btnLoadUserDetails;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.GroupBox groupBoxStats;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label lblBookingsMonth;
        private System.Windows.Forms.Label lblPendingApprovals;
        private System.Windows.Forms.Label lblTotalProviders;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalRevenueValue;
        private System.Windows.Forms.Label lblBookingsMonthValue;
        private System.Windows.Forms.Label lblPendingApprovalsValue;
        private System.Windows.Forms.Label lblTotalProvidersValue;
        private System.Windows.Forms.Label lblTotalCustomersValue;
        private System.Windows.Forms.TabPage tabAllBookings;
        private System.Windows.Forms.DataGridView dgvAllBookings;
        private System.Windows.Forms.Button btnRefreshBookings;
        private System.Windows.Forms.ComboBox comboBookingStatusFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMarkAsPaidAdmin;
        private System.Windows.Forms.Button btnCancelBookingAdmin;
        private System.Windows.Forms.TabPage tabTransactions;
        private System.Windows.Forms.Button btnFilterPayments;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPayments;
    }
}