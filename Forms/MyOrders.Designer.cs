
namespace ABC_traders.Forms
{
    partial class MyOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyOrders));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAddNewPart = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.txtSts = new System.Windows.Forms.TextBox();
            this.lblSts = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSKU = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtQnt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aBCTraders = new ABC_traders.DataSet.ABCTraders();
            this.ordersTableAdapter = new ABC_traders.DataSet.ABCTradersTableAdapters.OrdersTableAdapter();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(1114, 234);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAddNewPart);
            this.groupBox1.Controls.Add(this.txtRate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.picProduct);
            this.groupBox1.Controls.Add(this.txtSts);
            this.groupBox1.Controls.Add(this.lblSts);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtSKU);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtQnt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1090, 212);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // lblAddNewPart
            // 
            this.lblAddNewPart.AutoSize = true;
            this.lblAddNewPart.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddNewPart.Location = new System.Drawing.Point(50, -3);
            this.lblAddNewPart.Name = "lblAddNewPart";
            this.lblAddNewPart.Size = new System.Drawing.Size(152, 31);
            this.lblAddNewPart.TabIndex = 92;
            this.lblAddNewPart.Text = "Order Details";
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRate.Enabled = false;
            this.txtRate.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtRate.Location = new System.Drawing.Point(144, 148);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(190, 35);
            this.txtRate.TabIndex = 103;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 104;
            this.label1.Text = "Rate";
            // 
            // picProduct
            // 
            this.picProduct.Image = ((System.Drawing.Image)(resources.GetObject("picProduct.Image")));
            this.picProduct.Location = new System.Drawing.Point(889, 37);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(187, 97);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 102;
            this.picProduct.TabStop = false;
            // 
            // txtSts
            // 
            this.txtSts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtSts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSts.Enabled = false;
            this.txtSts.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtSts.Location = new System.Drawing.Point(527, 148);
            this.txtSts.Multiline = true;
            this.txtSts.Name = "txtSts";
            this.txtSts.Size = new System.Drawing.Size(190, 35);
            this.txtSts.TabIndex = 95;
            // 
            // lblSts
            // 
            this.lblSts.AutoSize = true;
            this.lblSts.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblSts.Location = new System.Drawing.Point(401, 146);
            this.lblSts.Name = "lblSts";
            this.lblSts.Size = new System.Drawing.Size(118, 25);
            this.lblSts.TabIndex = 101;
            this.lblSts.Text = "Order Status";
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtPrice.Location = new System.Drawing.Point(527, 98);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(190, 35);
            this.txtPrice.TabIndex = 95;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(401, 96);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 25);
            this.lblAddress.TabIndex = 101;
            this.lblAddress.Text = "Price";
            // 
            // txtSKU
            // 
            this.txtSKU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtSKU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSKU.Enabled = false;
            this.txtSKU.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtSKU.Location = new System.Drawing.Point(144, 98);
            this.txtSKU.Multiline = true;
            this.txtSKU.Name = "txtSKU";
            this.txtSKU.Size = new System.Drawing.Size(190, 35);
            this.txtSKU.TabIndex = 94;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.lblEmail.Location = new System.Drawing.Point(10, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(103, 25);
            this.lblEmail.TabIndex = 100;
            this.lblEmail.Text = "Product ID";
            // 
            // txtQnt
            // 
            this.txtQnt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtQnt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQnt.Enabled = false;
            this.txtQnt.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F);
            this.txtQnt.Location = new System.Drawing.Point(527, 45);
            this.txtQnt.Multiline = true;
            this.txtQnt.Name = "txtQnt";
            this.txtQnt.Size = new System.Drawing.Size(190, 35);
            this.txtQnt.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(754, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 98;
            this.label3.Text = "Product Image";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(144, 45);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 35);
            this.txtName.TabIndex = 93;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(401, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 97;
            this.label2.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 99;
            this.label6.Text = "Product Name";
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
            this.cusIDDataGridViewTextBoxColumn,
            this.proTypeDataGridViewTextBoxColumn,
            this.proIdDataGridViewTextBoxColumn,
            this.proNameDataGridViewTextBoxColumn,
            this.rateDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.OrderGrid.DataSource = this.ordersBindingSource;
            this.OrderGrid.GridColor = System.Drawing.Color.LightGray;
            this.OrderGrid.Location = new System.Drawing.Point(32, 89);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.ReadOnly = true;
            this.OrderGrid.RowHeadersWidth = 51;
            this.OrderGrid.Size = new System.Drawing.Size(930, 257);
            this.OrderGrid.TabIndex = 1;
            this.OrderGrid.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrderGrid_RowHeaderMouseDoubleClick);
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
            // cusIDDataGridViewTextBoxColumn
            // 
            this.cusIDDataGridViewTextBoxColumn.DataPropertyName = "CusID";
            this.cusIDDataGridViewTextBoxColumn.HeaderText = "CusID";
            this.cusIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cusIDDataGridViewTextBoxColumn.Name = "cusIDDataGridViewTextBoxColumn";
            this.cusIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusIDDataGridViewTextBoxColumn.Visible = false;
            this.cusIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // proTypeDataGridViewTextBoxColumn
            // 
            this.proTypeDataGridViewTextBoxColumn.DataPropertyName = "ProType";
            this.proTypeDataGridViewTextBoxColumn.HeaderText = "Product";
            this.proTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proTypeDataGridViewTextBoxColumn.Name = "proTypeDataGridViewTextBoxColumn";
            this.proTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.proTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // proIdDataGridViewTextBoxColumn
            // 
            this.proIdDataGridViewTextBoxColumn.DataPropertyName = "ProId";
            this.proIdDataGridViewTextBoxColumn.HeaderText = "ProId";
            this.proIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.proIdDataGridViewTextBoxColumn.Name = "proIdDataGridViewTextBoxColumn";
            this.proIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.proIdDataGridViewTextBoxColumn.Visible = false;
            this.proIdDataGridViewTextBoxColumn.Width = 125;
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
            // rateDataGridViewTextBoxColumn
            // 
            this.rateDataGridViewTextBoxColumn.DataPropertyName = "Rate";
            this.rateDataGridViewTextBoxColumn.HeaderText = "Rate";
            this.rateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rateDataGridViewTextBoxColumn.Name = "rateDataGridViewTextBoxColumn";
            this.rateDataGridViewTextBoxColumn.ReadOnly = true;
            this.rateDataGridViewTextBoxColumn.Width = 125;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 125;
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
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnClearFilter.FlatAppearance.BorderSize = 0;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFilter.ForeColor = System.Drawing.Color.White;
            this.btnClearFilter.Location = new System.Drawing.Point(604, 19);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(104, 34);
            this.btnClearFilter.TabIndex = 29;
            this.btnClearFilter.Text = "Clear Filters";
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.BackgroundImage = global::ABC_traders.Properties.Resources.search_30px;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(566, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(31, 32);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(26, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(357, 31);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "Search by Order Id/Product Type";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(346, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(251, 38);
            this.txtSearch.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearFilter);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.OrderGrid);
            this.panel2.Controls.Add(this.lblSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 358);
            this.panel2.TabIndex = 30;
            // 
            // MyOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1114, 592);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyOrders";
            this.Text = "My Orders";
            this.Load += new System.EventHandler(this.MyOrders_Load);
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
        private System.Windows.Forms.DataGridView OrderGrid;
        private DataSet.ABCTraders aBCTraders;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DataSet.ABCTradersTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblAddNewPart;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtSKU;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtQnt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSts;
        private System.Windows.Forms.Label lblSts;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
    }
}