
namespace ABC_traders.Forms
{
    partial class ServicesForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerUserBooking = new System.Windows.Forms.DateTimePicker();
            this.lblUserDate = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTimeDuration = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAddNew = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnDeletePart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lblTimeDuration2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ServiceGrid = new System.Windows.Forms.DataGridView();
            this.SId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.aBCTraders = new ABC_traders.DataSet.ABCTraders();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBookingSearch = new System.Windows.Forms.Button();
            this.btnAdminServices = new System.Windows.Forms.Button();
            this.btnUserBookingForm = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.ServiceBookingGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new ABC_traders.DataSet.ABCTradersTableAdapters.ServicesTableAdapter();
            this.ordersTableAdapter = new ABC_traders.DataSet.ABCTradersTableAdapters.OrdersTableAdapter();
            this.userServicesTableAdapter = new ABC_traders.DataSet.ABCTradersTableAdapters.UserServicesTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCTraders)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 307);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerUserBooking);
            this.groupBox1.Controls.Add(this.lblUserDate);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Controls.Add(this.lblTimeDuration);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblAddNew);
            this.groupBox1.Controls.Add(this.lblNIC);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtSKU);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnAddPart);
            this.groupBox1.Controls.Add(this.btnDeletePart);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.lblTimeDuration2);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 278);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // dateTimePickerUserBooking
            // 
            this.dateTimePickerUserBooking.Location = new System.Drawing.Point(576, 70);
            this.dateTimePickerUserBooking.Name = "dateTimePickerUserBooking";
            this.dateTimePickerUserBooking.Size = new System.Drawing.Size(249, 26);
            this.dateTimePickerUserBooking.TabIndex = 107;
            // 
            // lblUserDate
            // 
            this.lblUserDate.AutoSize = true;
            this.lblUserDate.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserDate.Location = new System.Drawing.Point(444, 66);
            this.lblUserDate.Name = "lblUserDate";
            this.lblUserDate.Size = new System.Drawing.Size(52, 25);
            this.lblUserDate.TabIndex = 106;
            this.lblUserDate.Text = "Date";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(414, 213);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(156, 43);
            this.btnUpdate.TabIndex = 102;
            this.btnUpdate.Text = "Update Service";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtTime.Location = new System.Drawing.Point(576, 55);
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(190, 35);
            this.txtTime.TabIndex = 98;
            // 
            // lblTimeDuration
            // 
            this.lblTimeDuration.AutoSize = true;
            this.lblTimeDuration.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDuration.Location = new System.Drawing.Point(440, 63);
            this.lblTimeDuration.Name = "lblTimeDuration";
            this.lblTimeDuration.Size = new System.Drawing.Size(134, 25);
            this.lblTimeDuration.TabIndex = 99;
            this.lblTimeDuration.Text = "Time Duration";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtPrice.Location = new System.Drawing.Point(576, 132);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 35);
            this.txtPrice.TabIndex = 94;
            // 
            // lblAddNew
            // 
            this.lblAddNew.AutoSize = true;
            this.lblAddNew.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNew.Location = new System.Drawing.Point(51, -3);
            this.lblAddNew.Name = "lblAddNew";
            this.lblAddNew.Size = new System.Drawing.Size(191, 31);
            this.lblAddNew.TabIndex = 67;
            this.lblAddNew.Text = "Add New Service";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.Location = new System.Drawing.Point(444, 140);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(54, 25);
            this.lblNIC.TabIndex = 97;
            this.lblNIC.Text = "Price";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(162, 61);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 35);
            this.txtName.TabIndex = 92;
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSKU.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtSKU.Location = new System.Drawing.Point(162, 125);
            this.txtSKU.Multiline = true;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(190, 35);
            this.txtSKU.TabIndex = 93;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(31, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(98, 25);
            this.lblEmail.TabIndex = 96;
            this.lblEmail.Text = "Service ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 95;
            this.label6.Text = "Service Name";
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAddPart.FlatAppearance.BorderSize = 0;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPart.ForeColor = System.Drawing.Color.White;
            this.btnAddPart.Location = new System.Drawing.Point(576, 213);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(156, 43);
            this.btnAddPart.TabIndex = 100;
            this.btnAddPart.Text = "Add Service";
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnDeletePart
            // 
            this.btnDeletePart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnDeletePart.FlatAppearance.BorderSize = 0;
            this.btnDeletePart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePart.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePart.ForeColor = System.Drawing.Color.White;
            this.btnDeletePart.Location = new System.Drawing.Point(576, 213);
            this.btnDeletePart.Name = "btnDeletePart";
            this.btnDeletePart.Size = new System.Drawing.Size(156, 43);
            this.btnDeletePart.TabIndex = 103;
            this.btnDeletePart.Text = "Delete Service";
            this.btnDeletePart.UseVisualStyleBackColor = false;
            this.btnDeletePart.Click += new System.EventHandler(this.btnDeletePart_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(738, 213);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(156, 43);
            this.btnClear.TabIndex = 101;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnRestore.FlatAppearance.BorderSize = 0;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.ForeColor = System.Drawing.Color.White;
            this.btnRestore.Location = new System.Drawing.Point(738, 213);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(156, 43);
            this.btnRestore.TabIndex = 104;
            this.btnRestore.Text = "Reset";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblTimeDuration2
            // 
            this.lblTimeDuration2.AutoSize = true;
            this.lblTimeDuration2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDuration2.Location = new System.Drawing.Point(440, 88);
            this.lblTimeDuration2.Name = "lblTimeDuration2";
            this.lblTimeDuration2.Size = new System.Drawing.Size(135, 25);
            this.lblTimeDuration2.TabIndex = 105;
            this.lblTimeDuration2.Text = "(For a Service)";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(12, 21);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(190, 28);
            this.txtId.TabIndex = 91;
            this.txtId.Visible = false;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(620, 9);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(104, 37);
            this.btnClearFilter.TabIndex = 25;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(25, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(293, 31);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search by Name/ServiceID";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(312, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(282, 38);
            this.txtSearch.TabIndex = 23;
            // 
            // ServiceGrid
            // 
            this.ServiceGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServiceGrid.AutoGenerateColumns = false;
            this.ServiceGrid.BackgroundColor = System.Drawing.Color.White;
            this.ServiceGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SId,
            this.nameDataGridViewTextBoxColumn1,
            this.sKUDataGridViewTextBoxColumn1,
            this.timeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn1});
            this.ServiceGrid.DataSource = this.servicesBindingSource1;
            this.ServiceGrid.GridColor = System.Drawing.Color.LightGray;
            this.ServiceGrid.Location = new System.Drawing.Point(28, 86);
            this.ServiceGrid.Name = "ServiceGrid";
            this.ServiceGrid.RowHeadersWidth = 51;
            this.ServiceGrid.Size = new System.Drawing.Size(911, 187);
            this.ServiceGrid.TabIndex = 26;
            this.ServiceGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceGrid_RowHeaderMouseDoubleClick);
            // 
            // SId
            // 
            this.SId.DataPropertyName = "SId";
            this.SId.HeaderText = "SId";
            this.SId.MinimumWidth = 6;
            this.SId.Name = "SId";
            this.SId.ReadOnly = true;
            this.SId.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sKUDataGridViewTextBoxColumn1
            // 
            this.sKUDataGridViewTextBoxColumn1.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn1.HeaderText = "Service code";
            this.sKUDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.sKUDataGridViewTextBoxColumn1.Name = "sKUDataGridViewTextBoxColumn1";
            this.sKUDataGridViewTextBoxColumn1.Width = 135;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.Width = 125;
            // 
            // servicesBindingSource1
            // 
            this.servicesBindingSource1.DataMember = "Services";
            this.servicesBindingSource1.DataSource = this.aBCTraders;
            // 
            // aBCTraders
            // 
            this.aBCTraders.DataSetName = "ABCTraders";
            this.aBCTraders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAdminServices);
            this.panel2.Controls.Add(this.btnUserBookingForm);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.ServiceGrid);
            this.panel2.Controls.Add(this.btnClearFilter);
            this.panel2.Controls.Add(this.ServiceBookingGrid);
            this.panel2.Controls.Add(this.btnBookingSearch);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 307);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 285);
            this.panel2.TabIndex = 27;
            // 
            // btnBookingSearch
            // 
            this.btnBookingSearch.BackColor = System.Drawing.Color.Silver;
            this.btnBookingSearch.BackgroundImage = global::ABC_traders.Properties.Resources.search_30px;
            this.btnBookingSearch.FlatAppearance.BorderSize = 0;
            this.btnBookingSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookingSearch.Location = new System.Drawing.Point(563, 10);
            this.btnBookingSearch.Name = "btnBookingSearch";
            this.btnBookingSearch.Size = new System.Drawing.Size(31, 33);
            this.btnBookingSearch.TabIndex = 106;
            this.btnBookingSearch.UseVisualStyleBackColor = false;
            this.btnBookingSearch.Click += new System.EventHandler(this.btnBookingSearch_Click);
            // 
            // btnAdminServices
            // 
            this.btnAdminServices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnAdminServices.FlatAppearance.BorderSize = 0;
            this.btnAdminServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminServices.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminServices.ForeColor = System.Drawing.Color.White;
            this.btnAdminServices.Location = new System.Drawing.Point(935, 13);
            this.btnAdminServices.Name = "btnAdminServices";
            this.btnAdminServices.Size = new System.Drawing.Size(139, 46);
            this.btnAdminServices.TabIndex = 105;
            this.btnAdminServices.Text = "Services";
            this.btnAdminServices.UseVisualStyleBackColor = false;
            this.btnAdminServices.Click += new System.EventHandler(this.btnAdminServices_Click);
            // 
            // btnUserBookingForm
            // 
            this.btnUserBookingForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnUserBookingForm.FlatAppearance.BorderSize = 0;
            this.btnUserBookingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserBookingForm.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserBookingForm.ForeColor = System.Drawing.Color.White;
            this.btnUserBookingForm.Location = new System.Drawing.Point(935, 15);
            this.btnUserBookingForm.Name = "btnUserBookingForm";
            this.btnUserBookingForm.Size = new System.Drawing.Size(139, 46);
            this.btnUserBookingForm.TabIndex = 103;
            this.btnUserBookingForm.Text = "Bookings";
            this.btnUserBookingForm.UseVisualStyleBackColor = false;
            this.btnUserBookingForm.Click += new System.EventHandler(this.btnUserBookingForm_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.BackgroundImage = global::ABC_traders.Properties.Resources.search_30px;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(563, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 32);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ServiceBookingGrid
            // 
            this.ServiceBookingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ServiceBookingGrid.AutoGenerateColumns = false;
            this.ServiceBookingGrid.BackgroundColor = System.Drawing.Color.White;
            this.ServiceBookingGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceBookingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceBookingGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cusIDDataGridViewTextBoxColumn1,
            this.sIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sKUDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.ServiceBookingGrid.DataSource = this.userServicesBindingSource;
            this.ServiceBookingGrid.GridColor = System.Drawing.Color.LightGray;
            this.ServiceBookingGrid.Location = new System.Drawing.Point(28, 86);
            this.ServiceBookingGrid.Name = "ServiceBookingGrid";
            this.ServiceBookingGrid.RowHeadersWidth = 51;
            this.ServiceBookingGrid.Size = new System.Drawing.Size(949, 196);
            this.ServiceBookingGrid.TabIndex = 104;
            this.ServiceBookingGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServiceBookingGrid_RowHeaderMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ServiceBookId";
            this.ID.HeaderText = "ServiceBookId";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // cusIDDataGridViewTextBoxColumn1
            // 
            this.cusIDDataGridViewTextBoxColumn1.DataPropertyName = "CusID";
            this.cusIDDataGridViewTextBoxColumn1.HeaderText = "CusID";
            this.cusIDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn1.Name = "cusIDDataGridViewTextBoxColumn1";
            this.cusIDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // sIdDataGridViewTextBoxColumn
            // 
            this.sIdDataGridViewTextBoxColumn.DataPropertyName = "SId";
            this.sIdDataGridViewTextBoxColumn.HeaderText = "SId";
            this.sIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sIdDataGridViewTextBoxColumn.Name = "sIdDataGridViewTextBoxColumn";
            this.sIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // sKUDataGridViewTextBoxColumn
            // 
            this.sKUDataGridViewTextBoxColumn.DataPropertyName = "SKU";
            this.sKUDataGridViewTextBoxColumn.HeaderText = "Service code";
            this.sKUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sKUDataGridViewTextBoxColumn.Name = "sKUDataGridViewTextBoxColumn";
            this.sKUDataGridViewTextBoxColumn.Width = 135;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // userServicesBindingSource
            // 
            this.userServicesBindingSource.DataMember = "UserServices";
            this.userServicesBindingSource.DataSource = this.aBCTraders;
            // 
            // servicesOrdersBindingSource
            // 
            this.servicesOrdersBindingSource.DataMember = "Services_Orders";
            this.servicesOrdersBindingSource.DataSource = this.servicesBindingSource;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.aBCTraders;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // userServicesTableAdapter
            // 
            this.userServicesTableAdapter.ClearBeforeFill = true;
            // 
            // ServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServicesForm";
            this.Text = "Manage Services";
            this.Load += new System.EventHandler(this.ServicesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCTraders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceBookingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesOrdersBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAddNew;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTimeDuration;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView ServiceGrid;
        private DataSet.ABCTraders aBCTraders;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private DataSet.ABCTradersTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnDeletePart;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTimeDuration2;
        private System.Windows.Forms.Button btnUserBookingForm;
        private System.Windows.Forms.DataGridView ServiceBookingGrid;
        private System.Windows.Forms.BindingSource servicesOrdersBindingSource;
        private DataSet.ABCTradersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource userServicesBindingSource;
        private DataSet.ABCTradersTableAdapters.UserServicesTableAdapter userServicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private System.Windows.Forms.Button btnAdminServices;
        private System.Windows.Forms.Button btnBookingSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn SId;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker dateTimePickerUserBooking;
        private System.Windows.Forms.Label lblUserDate;
    }
}