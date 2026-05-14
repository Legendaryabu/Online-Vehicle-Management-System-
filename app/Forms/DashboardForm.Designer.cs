namespace OVSMS_Desktop.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && (components != null)) { components.Dispose(); } base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabVehicles = new System.Windows.Forms.TabPage();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.dgvVehicles = new System.Windows.Forms.DataGridView();
            this.panelVehicleForm = new System.Windows.Forms.Panel();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.comboVehicleType = new System.Windows.Forms.ComboBox();
            this.btnClearVehicleForm = new System.Windows.Forms.Button();
            this.lblEditingVehicleId = new System.Windows.Forms.Label();
            this.btnSaveUpdateVehicle = new System.Windows.Forms.Button();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.lblRegNum = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblAddVehicle = new System.Windows.Forms.Label();
            this.tabBookings = new System.Windows.Forms.TabPage();
            this.btnPayNow = new System.Windows.Forms.Button();
            this.btnCancelBooking = new System.Windows.Forms.Button();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.tabServices = new System.Windows.Forms.TabPage();
            this.servicesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.panelProfile = new System.Windows.Forms.Panel();
            this.btnContactAdmin = new System.Windows.Forms.Button(); // NEW CONTROL
            this.lblProfileRole = new System.Windows.Forms.Label();
            this.txtProfileRole = new System.Windows.Forms.TextBox();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.txtProfilePhone = new System.Windows.Forms.TextBox();
            this.lblProfilePhone = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileTitle = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabVehicles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            this.panelVehicleForm.SuspendLayout();
            this.tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.tabServices.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.panelProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(24, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(271, 30);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome back, [User Name]!";
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(868, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabVehicles);
            this.tabControlMain.Controls.Add(this.tabBookings);
            this.tabControlMain.Controls.Add(this.tabServices);
            this.tabControlMain.Controls.Add(this.tabProfile);
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlMain.Location = new System.Drawing.Point(24, 69);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(938, 569);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabVehicles
            // 
            this.tabVehicles.Controls.Add(this.btnDeleteVehicle);
            this.tabVehicles.Controls.Add(this.dgvVehicles);
            this.tabVehicles.Controls.Add(this.panelVehicleForm);
            this.tabVehicles.Location = new System.Drawing.Point(4, 26);
            this.tabVehicles.Name = "tabVehicles";
            this.tabVehicles.Padding = new System.Windows.Forms.Padding(15);
            this.tabVehicles.Size = new System.Drawing.Size(930, 539);
            this.tabVehicles.TabIndex = 0;
            this.tabVehicles.Text = "My Vehicles";
            this.tabVehicles.UseVisualStyleBackColor = true;
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDeleteVehicle.FlatAppearance.BorderSize = 0;
            this.btnDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(748, 486);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(164, 35);
            this.btnDeleteVehicle.TabIndex = 9;
            this.btnDeleteVehicle.Text = "Delete Selected Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = false;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            this.dgvVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicles.Location = new System.Drawing.Point(365, 18);
            this.dgvVehicles.MultiSelect = false;
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.RowTemplate.Height = 35;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(547, 462);
            this.dgvVehicles.TabIndex = 10;
            this.dgvVehicles.SelectionChanged += new System.EventHandler(this.dgvVehicles_SelectionChanged);
            // 
            // panelVehicleForm
            // 
            this.panelVehicleForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelVehicleForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelVehicleForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVehicleForm.Controls.Add(this.lblVehicleType);
            this.panelVehicleForm.Controls.Add(this.comboVehicleType);
            this.panelVehicleForm.Controls.Add(this.btnClearVehicleForm);
            this.panelVehicleForm.Controls.Add(this.lblEditingVehicleId);
            this.panelVehicleForm.Controls.Add(this.btnSaveUpdateVehicle);
            this.panelVehicleForm.Controls.Add(this.txtRegNum);
            this.panelVehicleForm.Controls.Add(this.lblRegNum);
            this.panelVehicleForm.Controls.Add(this.txtYear);
            this.panelVehicleForm.Controls.Add(this.lblYear);
            this.panelVehicleForm.Controls.Add(this.txtModel);
            this.panelVehicleForm.Controls.Add(this.lblModel);
            this.panelVehicleForm.Controls.Add(this.txtMake);
            this.panelVehicleForm.Controls.Add(this.lblMake);
            this.panelVehicleForm.Controls.Add(this.lblAddVehicle);
            this.panelVehicleForm.Location = new System.Drawing.Point(18, 18);
            this.panelVehicleForm.Name = "panelVehicleForm";
            this.panelVehicleForm.Padding = new System.Windows.Forms.Padding(15);
            this.panelVehicleForm.Size = new System.Drawing.Size(330, 503);
            this.panelVehicleForm.TabIndex = 0;
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblVehicleType.Location = new System.Drawing.Point(18, 72);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(84, 17);
            this.lblVehicleType.TabIndex = 2;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // comboVehicleType
            // 
            this.comboVehicleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboVehicleType.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.comboVehicleType.FormattingEnabled = true;
            this.comboVehicleType.Location = new System.Drawing.Point(18, 92);
            this.comboVehicleType.Name = "comboVehicleType";
            this.comboVehicleType.Size = new System.Drawing.Size(292, 28);
            this.comboVehicleType.TabIndex = 1;
            // 
            // btnClearVehicleForm
            // 
            this.btnClearVehicleForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnClearVehicleForm.FlatAppearance.BorderSize = 0;
            this.btnClearVehicleForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearVehicleForm.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearVehicleForm.ForeColor = System.Drawing.Color.White;
            this.btnClearVehicleForm.Location = new System.Drawing.Point(18, 442);
            this.btnClearVehicleForm.Name = "btnClearVehicleForm";
            this.btnClearVehicleForm.Size = new System.Drawing.Size(292, 35);
            this.btnClearVehicleForm.TabIndex = 7;
            this.btnClearVehicleForm.Text = "Clear / New Vehicle";
            this.btnClearVehicleForm.UseVisualStyleBackColor = false;
            this.btnClearVehicleForm.Click += new System.EventHandler(this.btnClearVehicleForm_Click);
            // 
            // lblEditingVehicleId
            // 
            this.lblEditingVehicleId.AutoSize = true;
            this.lblEditingVehicleId.Location = new System.Drawing.Point(18, 480);
            this.lblEditingVehicleId.Name = "lblEditingVehicleId";
            this.lblEditingVehicleId.Size = new System.Drawing.Size(15, 17);
            this.lblEditingVehicleId.TabIndex = 99;
            this.lblEditingVehicleId.Text = "0";
            this.lblEditingVehicleId.Visible = false;
            // 
            // btnSaveUpdateVehicle
            // 
            this.btnSaveUpdateVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.btnSaveUpdateVehicle.FlatAppearance.BorderSize = 0;
            this.btnSaveUpdateVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdateVehicle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveUpdateVehicle.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpdateVehicle.Location = new System.Drawing.Point(18, 391);
            this.btnSaveUpdateVehicle.Name = "btnSaveUpdateVehicle";
            this.btnSaveUpdateVehicle.Size = new System.Drawing.Size(292, 45);
            this.btnSaveUpdateVehicle.TabIndex = 6;
            this.btnSaveUpdateVehicle.Text = "Save Vehicle";
            this.btnSaveUpdateVehicle.UseVisualStyleBackColor = false;
            this.btnSaveUpdateVehicle.Click += new System.EventHandler(this.btnSaveUpdateVehicle_Click);
            // 
            // txtRegNum
            // 
            this.txtRegNum.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegNum.Location = new System.Drawing.Point(18, 345);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.PlaceholderText = "e.g. ABC-1234";
            this.txtRegNum.Size = new System.Drawing.Size(292, 27);
            this.txtRegNum.TabIndex = 5;
            // 
            // lblRegNum
            // 
            this.lblRegNum.AutoSize = true;
            this.lblRegNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegNum.Location = new System.Drawing.Point(18, 325);
            this.lblRegNum.Name = "lblRegNum";
            this.lblRegNum.Size = new System.Drawing.Size(133, 17);
            this.lblRegNum.TabIndex = 10;
            this.lblRegNum.Text = "Registration Number";
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtYear.Location = new System.Drawing.Point(18, 282);
            this.txtYear.Name = "txtYear";
            this.txtYear.PlaceholderText = "e.g. 2020";
            this.txtYear.Size = new System.Drawing.Size(292, 27);
            this.txtYear.TabIndex = 4;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(18, 262);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(33, 17);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModel.Location = new System.Drawing.Point(18, 218);
            this.txtModel.Name = "txtModel";
            this.txtModel.PlaceholderText = "e.g. Corolla";
            this.txtModel.Size = new System.Drawing.Size(292, 27);
            this.txtModel.TabIndex = 3;
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(18, 198);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            // 
            // txtMake
            // 
            this.txtMake.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMake.Location = new System.Drawing.Point(18, 155);
            this.txtMake.Name = "txtMake";
            this.txtMake.PlaceholderText = "e.g. Toyota";
            this.txtMake.Size = new System.Drawing.Size(292, 27);
            this.txtMake.TabIndex = 2;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMake.Location = new System.Drawing.Point(18, 135);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(40, 17);
            this.lblMake.TabIndex = 4;
            this.lblMake.Text = "Make";
            // 
            // lblAddVehicle
            // 
            this.lblAddVehicle.AutoSize = true;
            this.lblAddVehicle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddVehicle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblAddVehicle.Location = new System.Drawing.Point(15, 15);
            this.lblAddVehicle.Name = "lblAddVehicle";
            this.lblAddVehicle.Size = new System.Drawing.Size(163, 25);
            this.lblAddVehicle.TabIndex = 0;
            this.lblAddVehicle.Text = "Add / Edit Vehicle";
            // 
            // tabBookings
            // 
            this.tabBookings.Controls.Add(this.btnPayNow);
            this.tabBookings.Controls.Add(this.btnCancelBooking);
            this.tabBookings.Controls.Add(this.dgvBookings);
            this.tabBookings.Location = new System.Drawing.Point(4, 26);
            this.tabBookings.Name = "tabBookings";
            this.tabBookings.Padding = new System.Windows.Forms.Padding(15);
            this.tabBookings.Size = new System.Drawing.Size(930, 539);
            this.tabBookings.TabIndex = 1;
            this.tabBookings.Text = "Recent Bookings";
            this.tabBookings.UseVisualStyleBackColor = true;
            // 
            // btnPayNow
            // 
            this.btnPayNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayNow.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPayNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayNow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPayNow.ForeColor = System.Drawing.Color.White;
            this.btnPayNow.Location = new System.Drawing.Point(608, 486);
            this.btnPayNow.Name = "btnPayNow";
            this.btnPayNow.Size = new System.Drawing.Size(130, 35);
            this.btnPayNow.TabIndex = 2;
            this.btnPayNow.Text = "Pay Now";
            this.btnPayNow.UseVisualStyleBackColor = false;
            this.btnPayNow.Click += new System.EventHandler(this.btnPayNow_Click);
            // 
            // btnCancelBooking
            // 
            this.btnCancelBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnCancelBooking.FlatAppearance.BorderSize = 0;
            this.btnCancelBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBooking.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelBooking.ForeColor = System.Drawing.Color.White;
            this.btnCancelBooking.Location = new System.Drawing.Point(748, 486);
            this.btnCancelBooking.Name = "btnCancelBooking";
            this.btnCancelBooking.Size = new System.Drawing.Size(164, 35);
            this.btnCancelBooking.TabIndex = 1;
            this.btnCancelBooking.Text = "Cancel Selected Booking";
            this.btnCancelBooking.UseVisualStyleBackColor = false;
            this.btnCancelBooking.Click += new System.EventHandler(this.btnCancelBooking_Click);
            // 
            // dgvBookings
            // 
            this.dgvBookings.AllowUserToAddRows = false;
            this.dgvBookings.AllowUserToDeleteRows = false;
            this.dgvBookings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvBookings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookings.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookings.Location = new System.Drawing.Point(18, 18);
            this.dgvBookings.MultiSelect = false;
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersVisible = false;
            this.dgvBookings.RowTemplate.Height = 35;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(894, 462);
            this.dgvBookings.TabIndex = 0;
            this.dgvBookings.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBookings_CellFormatting);
            // 
            // tabServices
            // 
            this.tabServices.Controls.Add(this.servicesFlowPanel);
            this.tabServices.Location = new System.Drawing.Point(4, 26);
            this.tabServices.Name = "tabServices";
            this.tabServices.Padding = new System.Windows.Forms.Padding(10);
            this.tabServices.Size = new System.Drawing.Size(930, 539);
            this.tabServices.TabIndex = 2;
            this.tabServices.Text = "Book a Service";
            this.tabServices.UseVisualStyleBackColor = true;
            // 
            // servicesFlowPanel
            // 
            this.servicesFlowPanel.AutoScroll = true;
            this.servicesFlowPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.servicesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesFlowPanel.Location = new System.Drawing.Point(10, 10);
            this.servicesFlowPanel.Name = "servicesFlowPanel";
            this.servicesFlowPanel.Padding = new System.Windows.Forms.Padding(5);
            this.servicesFlowPanel.Size = new System.Drawing.Size(910, 519);
            this.servicesFlowPanel.TabIndex = 0;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.panelProfile);
            this.tabProfile.Location = new System.Drawing.Point(4, 26);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(15);
            this.tabProfile.Size = new System.Drawing.Size(930, 539);
            this.tabProfile.TabIndex = 3;
            this.tabProfile.Text = "My Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // panelProfile
            // 
            this.panelProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelProfile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfile.Controls.Add(this.btnContactAdmin); 
            this.panelProfile.Controls.Add(this.lblProfileRole);
            this.panelProfile.Controls.Add(this.txtProfileRole);
            this.panelProfile.Controls.Add(this.lblProfileEmail);
            this.panelProfile.Controls.Add(this.txtProfileEmail);
            this.panelProfile.Controls.Add(this.btnUpdateProfile);
            this.panelProfile.Controls.Add(this.txtProfilePhone);
            this.panelProfile.Controls.Add(this.lblProfilePhone);
            this.panelProfile.Controls.Add(this.txtProfileName);
            this.panelProfile.Controls.Add(this.lblProfileName);
            this.panelProfile.Controls.Add(this.lblProfileTitle);
            this.panelProfile.Location = new System.Drawing.Point(265, 80);
            this.panelProfile.MaximumSize = new System.Drawing.Size(400, 430); 
            this.panelProfile.Name = "panelProfile";
            this.panelProfile.Padding = new System.Windows.Forms.Padding(20);
            this.panelProfile.Size = new System.Drawing.Size(400, 410); 
            this.panelProfile.TabIndex = 0;
            // 
            // btnContactAdmin
            // 
            this.btnContactAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnContactAdmin.FlatAppearance.BorderSize = 0;
            this.btnContactAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContactAdmin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnContactAdmin.ForeColor = System.Drawing.Color.White;
            this.btnContactAdmin.Location = new System.Drawing.Point(23, 358); 
            this.btnContactAdmin.Name = "btnContactAdmin";
            this.btnContactAdmin.Size = new System.Drawing.Size(352, 30);
            this.btnContactAdmin.TabIndex = 6;
            this.btnContactAdmin.Text = "Contact Administrator";
            this.btnContactAdmin.UseVisualStyleBackColor = false;
            this.btnContactAdmin.Click += new System.EventHandler(this.btnContactAdmin_Click); 
            // 
            // lblProfileRole
            // 
            this.lblProfileRole.AutoSize = true;
            this.lblProfileRole.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileRole.Location = new System.Drawing.Point(23, 255);
            this.lblProfileRole.Name = "lblProfileRole";
            this.lblProfileRole.Size = new System.Drawing.Size(34, 17);
            this.lblProfileRole.TabIndex = 9;
            this.lblProfileRole.Text = "Role";
            // 
            // txtProfileRole
            // 
            this.txtProfileRole.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProfileRole.Location = new System.Drawing.Point(23, 275);
            this.txtProfileRole.Name = "txtProfileRole";
            this.txtProfileRole.ReadOnly = true;
            this.txtProfileRole.Size = new System.Drawing.Size(352, 27);
            this.txtProfileRole.TabIndex = 8;
            this.txtProfileRole.TabStop = false;
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileEmail.Location = new System.Drawing.Point(23, 192);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(39, 17);
            this.lblProfileEmail.TabIndex = 7;
            this.lblProfileEmail.Text = "Email";
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProfileEmail.Location = new System.Drawing.Point(23, 212);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.ReadOnly = true;
            this.txtProfileEmail.Size = new System.Drawing.Size(352, 27);
            this.txtProfileEmail.TabIndex = 6;
            this.txtProfileEmail.TabStop = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(110)))), ((int)(((byte)(253)))));
            this.btnUpdateProfile.FlatAppearance.BorderSize = 0;
            this.btnUpdateProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProfile.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateProfile.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(23, 312);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(352, 40);
            this.btnUpdateProfile.TabIndex = 5;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // txtProfilePhone
            // 
            this.txtProfilePhone.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProfilePhone.Location = new System.Drawing.Point(23, 149);
            this.txtProfilePhone.Name = "txtProfilePhone";
            this.txtProfilePhone.Size = new System.Drawing.Size(352, 27);
            this.txtProfilePhone.TabIndex = 4;
            // 
            // lblProfilePhone
            // 
            this.lblProfilePhone.AutoSize = true;
            this.lblProfilePhone.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfilePhone.Location = new System.Drawing.Point(23, 129);
            this.lblProfilePhone.Name = "lblProfilePhone";
            this.lblProfilePhone.Size = new System.Drawing.Size(97, 17);
            this.lblProfilePhone.TabIndex = 3;
            this.lblProfilePhone.Text = "Phone Number";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.txtProfileName.Location = new System.Drawing.Point(23, 86);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(352, 27);
            this.txtProfileName.TabIndex = 2;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileName.Location = new System.Drawing.Point(23, 66);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(66, 17);
            this.lblProfileName.TabIndex = 1;
            this.lblProfileName.Text = "Full Name";
            // 
            // lblProfileTitle
            // 
            this.lblProfileTitle.AutoSize = true;
            this.lblProfileTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lblProfileTitle.Location = new System.Drawing.Point(20, 20);
            this.lblProfileTitle.Name = "lblProfileTitle";
            this.lblProfileTitle.Size = new System.Drawing.Size(107, 25);
            this.lblProfileTitle.TabIndex = 0;
            this.lblProfileTitle.Text = "My Profile";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.MinimumSize = new System.Drawing.Size(900, 700);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OVSMS - Customer Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabVehicles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            this.panelVehicleForm.ResumeLayout(false);
            this.panelVehicleForm.PerformLayout();
            this.tabBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.tabServices.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.panelProfile.ResumeLayout(false);
            this.panelProfile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabVehicles;
        private System.Windows.Forms.TabPage tabBookings;
        private System.Windows.Forms.TabPage tabServices;
        private System.Windows.Forms.FlowLayoutPanel servicesFlowPanel;
        private System.Windows.Forms.Panel panelVehicleForm;
        private System.Windows.Forms.Button btnSaveUpdateVehicle;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.Label lblRegNum;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblAddVehicle;
        private System.Windows.Forms.Button btnDeleteVehicle;
        private System.Windows.Forms.DataGridView dgvVehicles;
        private System.Windows.Forms.Button btnCancelBooking;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Label lblEditingVehicleId;
        private System.Windows.Forms.Button btnClearVehicleForm;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.Panel panelProfile;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.TextBox txtProfilePhone;
        private System.Windows.Forms.Label lblProfilePhone;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.Label lblProfileTitle;
        private System.Windows.Forms.Label lblProfileRole;
        private System.Windows.Forms.TextBox txtProfileRole;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.ComboBox comboVehicleType;
        private System.Windows.Forms.Button btnPayNow;
        private System.Windows.Forms.Button btnContactAdmin; 
    }
}