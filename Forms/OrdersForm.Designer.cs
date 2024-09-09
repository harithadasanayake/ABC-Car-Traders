
namespace ABC_traders.Forms
{
    partial class OrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblORate = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblAddNewPart = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.lblOPrice = new System.Windows.Forms.Label();
            this.lblOSKU = new System.Windows.Forms.Label();
            this.lblOImage = new System.Windows.Forms.Label();
            this.lblOQnt = new System.Windows.Forms.Label();
            this.lblOName = new System.Windows.Forms.Label();
            this.lblUName = new System.Windows.Forms.Label();
            this.lblUEmail = new System.Windows.Forms.Label();
            this.lblUAddress = new System.Windows.Forms.Label();
            this.lblUMobile = new System.Windows.Forms.Label();
            this.lblNIC = new System.Windows.Forms.Label();
            this.lbUUsername = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBCTraders = new ABC_traders.DataSet.ABCTraders();
            this.ordersTableAdapter = new ABC_traders.DataSet.ABCTradersTableAdapters.OrdersTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCTraders)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 305);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblORate);
            this.groupBox1.Controls.Add(this.txtContact);
            this.groupBox1.Controls.Add(this.lblAddNewPart);
            this.groupBox1.Controls.Add(this.picProduct);
            this.groupBox1.Controls.Add(this.lblOPrice);
            this.groupBox1.Controls.Add(this.lblOSKU);
            this.groupBox1.Controls.Add(this.lblOImage);
            this.groupBox1.Controls.Add(this.lblOQnt);
            this.groupBox1.Controls.Add(this.lblOName);
            this.groupBox1.Controls.Add(this.lblUName);
            this.groupBox1.Controls.Add(this.lblUEmail);
            this.groupBox1.Controls.Add(this.lblUAddress);
            this.groupBox1.Controls.Add(this.lblUMobile);
            this.groupBox1.Controls.Add(this.lblNIC);
            this.groupBox1.Controls.Add(this.lbUUsername);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtUName);
            this.groupBox1.Controls.Add(this.txtSKU);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.txtNIC);
            this.groupBox1.Controls.Add(this.txtQnt);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnUser);
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1082, 281);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            // 
            // lblORate
            // 
            this.lblORate.AutoSize = true;
            this.lblORate.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblORate.Location = new System.Drawing.Point(21, 144);
            this.lblORate.Name = "lblORate";
            this.lblORate.Size = new System.Drawing.Size(54, 25);
            this.lblORate.TabIndex = 117;
            this.lblORate.Text = "Price";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Enabled = false;
            this.txtContact.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtContact.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContact.Location = new System.Drawing.Point(516, 144);
            this.txtContact.Multiline = true;
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(187, 35);
            this.txtContact.TabIndex = 124;
            // 
            // lblAddNewPart
            // 
            this.lblAddNewPart.AutoSize = true;
            this.lblAddNewPart.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewPart.Location = new System.Drawing.Point(63, 0);
            this.lblAddNewPart.Name = "lblAddNewPart";
            this.lblAddNewPart.Size = new System.Drawing.Size(152, 31);
            this.lblAddNewPart.TabIndex = 105;
            this.lblAddNewPart.Text = "Order Details";
            // 
            // picProduct
            // 
            this.picProduct.Image = ((System.Drawing.Image)(resources.GetObject("picProduct.Image")));
            this.picProduct.Location = new System.Drawing.Point(873, 34);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(187, 97);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 115;
            this.picProduct.TabStop = false;
            // 
            // lblOPrice
            // 
            this.lblOPrice.AutoSize = true;
            this.lblOPrice.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOPrice.Location = new System.Drawing.Point(396, 97);
            this.lblOPrice.Name = "lblOPrice";
            this.lblOPrice.Size = new System.Drawing.Size(91, 25);
            this.lblOPrice.TabIndex = 114;
            this.lblOPrice.Text = "Amount  ";
            // 
            // lblOSKU
            // 
            this.lblOSKU.AutoSize = true;
            this.lblOSKU.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOSKU.Location = new System.Drawing.Point(20, 96);
            this.lblOSKU.Name = "lblOSKU";
            this.lblOSKU.Size = new System.Drawing.Size(103, 25);
            this.lblOSKU.TabIndex = 113;
            this.lblOSKU.Text = "Product ID";
            // 
            // lblOImage
            // 
            this.lblOImage.AutoSize = true;
            this.lblOImage.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOImage.Location = new System.Drawing.Point(734, 42);
            this.lblOImage.Name = "lblOImage";
            this.lblOImage.Size = new System.Drawing.Size(137, 25);
            this.lblOImage.TabIndex = 111;
            this.lblOImage.Text = "Product Image";
            // 
            // lblOQnt
            // 
            this.lblOQnt.AutoSize = true;
            this.lblOQnt.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblOQnt.Location = new System.Drawing.Point(394, 46);
            this.lblOQnt.Name = "lblOQnt";
            this.lblOQnt.Size = new System.Drawing.Size(87, 25);
            this.lblOQnt.TabIndex = 110;
            this.lblOQnt.Text = "Quantity";
            // 
            // lblOName
            // 
            this.lblOName.AutoSize = true;
            this.lblOName.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOName.Location = new System.Drawing.Point(20, 46);
            this.lblOName.Name = "lblOName";
            this.lblOName.Size = new System.Drawing.Size(134, 25);
            this.lblOName.TabIndex = 112;
            this.lblOName.Text = "Product Name";
            // 
            // lblUName
            // 
            this.lblUName.AutoSize = true;
            this.lblUName.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUName.Location = new System.Drawing.Point(17, 50);
            this.lblUName.Name = "lblUName";
            this.lblUName.Size = new System.Drawing.Size(97, 25);
            this.lblUName.TabIndex = 127;
            this.lblUName.Text = "Name       ";
            // 
            // lblUEmail
            // 
            this.lblUEmail.AutoSize = true;
            this.lblUEmail.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblUEmail.Location = new System.Drawing.Point(17, 91);
            this.lblUEmail.Name = "lblUEmail";
            this.lblUEmail.Size = new System.Drawing.Size(93, 25);
            this.lblUEmail.TabIndex = 128;
            this.lblUEmail.Text = "Email       ";
            // 
            // lblUAddress
            // 
            this.lblUAddress.AutoSize = true;
            this.lblUAddress.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblUAddress.Location = new System.Drawing.Point(391, 47);
            this.lblUAddress.Name = "lblUAddress";
            this.lblUAddress.Size = new System.Drawing.Size(80, 25);
            this.lblUAddress.TabIndex = 130;
            this.lblUAddress.Text = "Address";
            // 
            // lblUMobile
            // 
            this.lblUMobile.AutoSize = true;
            this.lblUMobile.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblUMobile.Location = new System.Drawing.Point(396, 149);
            this.lblUMobile.Name = "lblUMobile";
            this.lblUMobile.Size = new System.Drawing.Size(108, 25);
            this.lblUMobile.TabIndex = 126;
            this.lblUMobile.Text = "Contact No";
            // 
            // lblNIC
            // 
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblNIC.Location = new System.Drawing.Point(18, 142);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(63, 25);
            this.lblNIC.TabIndex = 129;
            this.lblNIC.Text = "NIC    ";
            // 
            // lbUUsername
            // 
            this.lbUUsername.AutoSize = true;
            this.lbUUsername.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lbUUsername.Location = new System.Drawing.Point(393, 95);
            this.lbUUsername.Name = "lbUUsername";
            this.lbUUsername.Size = new System.Drawing.Size(97, 25);
            this.lbUUsername.TabIndex = 125;
            this.lbUUsername.Text = "Username";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(155, 44);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 35);
            this.txtName.TabIndex = 106;
            // 
            // txtUName
            // 
            this.txtUName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtUName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUName.Enabled = false;
            this.txtUName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtUName.Location = new System.Drawing.Point(154, 43);
            this.txtUName.Multiline = true;
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(190, 35);
            this.txtUName.TabIndex = 119;
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSKU.Enabled = false;
            this.txtSKU.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtSKU.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSKU.Location = new System.Drawing.Point(155, 90);
            this.txtSKU.Multiline = true;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(190, 35);
            this.txtSKU.TabIndex = 107;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtEmail.Location = new System.Drawing.Point(155, 90);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(190, 35);
            this.txtEmail.TabIndex = 120;
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRate.Enabled = false;
            this.txtRate.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRate.Location = new System.Drawing.Point(155, 144);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(190, 35);
            this.txtRate.TabIndex = 116;
            // 
            // txtNIC
            // 
            this.txtNIC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtNIC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNIC.Enabled = false;
            this.txtNIC.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtNIC.Location = new System.Drawing.Point(154, 144);
            this.txtNIC.Multiline = true;
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(190, 35);
            this.txtNIC.TabIndex = 121;
            // 
            // txtQnt
            // 
            this.txtQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtQnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQnt.Enabled = false;
            this.txtQnt.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtQnt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtQnt.Location = new System.Drawing.Point(514, 37);
            this.txtQnt.Multiline = true;
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(186, 35);
            this.txtQnt.TabIndex = 109;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Enabled = false;
            this.txtAddress.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtAddress.Location = new System.Drawing.Point(515, 36);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(187, 35);
            this.txtAddress.TabIndex = 122;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtPrice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPrice.Location = new System.Drawing.Point(516, 90);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(188, 35);
            this.txtPrice.TabIndex = 108;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Enabled = false;
            this.txtUsername.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtUsername.Location = new System.Drawing.Point(516, 91);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 35);
            this.txtUsername.TabIndex = 123;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(744, 229);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(213, 43);
            this.btnUser.TabIndex = 118;
            this.btnUser.Text = "Show Customer";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(744, 230);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(213, 43);
            this.btnOrder.TabIndex = 131;
            this.btnOrder.Text = "Show Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(120)))), ((int)(((byte)(187)))));
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(675, 30);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(104, 37);
            this.btnClearFilter.TabIndex = 34;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(625, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 32);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(23, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(382, 31);
            this.lblSearch.TabIndex = 31;
            this.lblSearch.Text = "Search by Order Id or Product Type";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(371, 31);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(285, 38);
            this.txtSearch.TabIndex = 32;
            // 
            // OrderGrid
            // 
            this.OrderGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderGrid.AutoGenerateColumns = false;
            this.OrderGrid.BackgroundColor = System.Drawing.Color.White;
            this.OrderGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.proTypeDataGridViewTextBoxColumn,
            this.ProID,
            this.proNameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.OrderGrid.DataSource = this.ordersBindingSource;
            this.OrderGrid.GridColor = System.Drawing.Color.LightGray;
            this.OrderGrid.Location = new System.Drawing.Point(22, 89);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RowHeadersWidth = 51;
            this.OrderGrid.Size = new System.Drawing.Size(947, 186);
            this.OrderGrid.TabIndex = 30;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "OrderId";
            this.Id.HeaderText = "Order Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // proTypeDataGridViewTextBoxColumn
            // 
            this.proTypeDataGridViewTextBoxColumn.DataPropertyName = "ProType";
            this.proTypeDataGridViewTextBoxColumn.HeaderText = "Product Type";
            this.proTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proTypeDataGridViewTextBoxColumn.Name = "proTypeDataGridViewTextBoxColumn";
            this.proTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.proTypeDataGridViewTextBoxColumn.Width = 150;
            // 
            // ProID
            // 
            this.ProID.DataPropertyName = "ProId";
            this.ProID.HeaderText = "Pro Id";
            this.ProID.MinimumWidth = 6;
            this.ProID.Name = "ProID";
            this.ProID.ReadOnly = true;
            this.ProID.Visible = false;
            this.ProID.Width = 125;
            // 
            // proNameDataGridViewTextBoxColumn
            // 
            this.proNameDataGridViewTextBoxColumn.DataPropertyName = "ProName";
            this.proNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.proNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proNameDataGridViewTextBoxColumn.Name = "proNameDataGridViewTextBoxColumn";
            this.proNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.proNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 125;
            // 
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Price";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn.Width = 125;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.aBCTraders;
            // 
            // aBCTraders
            // 
            this.aBCTraders.DataSetName = "ABCTraders";
            this.aBCTraders.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.btnClearFilter);
            this.panel2.Controls.Add(this.OrderGrid);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 305);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 287);
            this.panel2.TabIndex = 35;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdersForm";
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBCTraders)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblORate;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblOPrice;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblOSKU;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.Label lblOImage;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblOQnt;
        private System.Windows.Forms.Label lblOName;
        private System.Windows.Forms.Label lblAddNewPart;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView OrderGrid;
        private DataSet.ABCTraders aBCTraders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSet.ABCTradersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblUMobile;
        private System.Windows.Forms.Label lblUAddress;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblUEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUName;
        private System.Windows.Forms.Label lbUUsername;
        private System.Windows.Forms.Label lblUName;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProID;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}