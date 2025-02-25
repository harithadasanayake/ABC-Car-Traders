﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_traders.DataSet;

namespace ABC_traders.Forms
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();


        }
       
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSKU.Text == "" || txtTime.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("All fieds are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().AddService(txtName.Text, txtSKU.Text, txtTime.Text, int.Parse(txtPrice.Text));
                    ServiceLoad();
                    restore();
                    MessageBox.Show("New Service Added Succefully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Please try again shortly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBCTraders.UserServices' table. You can move, or remove it, as needed.
            this.userServicesTableAdapter.Fill(this.aBCTraders.UserServices);
            btnUpdate.BackColor = Class.ThemeColor.PrimaryColor;
            btnRestore.BackColor = Class.ThemeColor.PrimaryColor;
            btnAddPart.BackColor = Class.ThemeColor.PrimaryColor;
            btnClear.BackColor = Class.ThemeColor.PrimaryColor;
            btnDeletePart.BackColor = Class.ThemeColor.SecondaryColor;
            btnSearch.BackColor = Class.ThemeColor.PrimaryColor;
            btnClearFilter.BackColor = Class.ThemeColor.PrimaryColor;
            btnUserBookingForm.BackColor = Class.ThemeColor.PrimaryColor;
            btnAdminServices.BackColor = Class.ThemeColor.PrimaryColor;
            btnBookingSearch.BackColor = Class.ThemeColor.PrimaryColor;

            btnUpdate.Visible = false;
            btnDeletePart.Visible = false;
            btnRestore.Visible = false;
            btnAddPart.Visible = true;
            btnClear.Visible = true;
            ServiceGrid.Visible = true;
            ServiceLoad();
            ServiceBookingGrid.Visible = false;
            btnAdminServices.Visible = false;
            ServiceBookingLoad();
            btnBookingSearch.Visible = false;
            lblUserDate.Visible = false;
            dateTimePickerUserBooking.Visible = false;
        }

        private void ServiceLoad()
        {
            ABCTraders.ServicesDataTable sa = new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().GetData();
            ServiceGrid.DataSource = sa.DefaultView;
            ServiceGrid.AutoGenerateColumns = false;

            ServiceGrid.EnableHeadersVisualStyles = false;
            ServiceGrid.ColumnHeadersDefaultCellStyle.BackColor = Class.ThemeColor.PrimaryColor;
            ServiceGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ServiceGrid.RowTemplate.Height = 50;
        }

        private void ServiceBookingLoad()
        {
            ABCTraders.UserServicesDataTable sa = new DataSet.ABCTradersTableAdapters.UserServicesTableAdapter().GetData();
            ServiceBookingGrid.DataSource = sa.DefaultView;
            ServiceBookingGrid.AutoGenerateColumns = false;

            ServiceBookingGrid.EnableHeadersVisualStyles = false;
            ServiceBookingGrid.ColumnHeadersDefaultCellStyle.BackColor = Class.ThemeColor.PrimaryColor;
            ServiceBookingGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ServiceBookingGrid.RowTemplate.Height = 50;
        }

        private void restore()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSKU.Text = "";
            txtTime.Text = "";
            txtPrice.Text = "";
            btnUpdate.Visible = false;
            btnDeletePart.Visible = false;
            btnRestore.Visible = false;
            btnAddPart.Visible = true;
            btnClear.Visible = true;
            lblAddNew.Text = "Add New Service";
        }


        private void ServiceGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                
                DataGridViewRow row = this.ServiceGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["SId"].Value.ToString());
                var adapter = new DataSet.ABCTradersTableAdapters.ServicesTableAdapter();
                ABCTraders.ServicesDataTable data = adapter.GeById(id);
                txtId.Text = data[0].SId.ToString();
                txtName.Text = data[0].Name;
                txtSKU.Text = data[0].SKU;
                txtTime.Text = data[0].Time;
                txtPrice.Text = data[0].Price.ToString();
                btnUpdate.Visible = true;
                btnDeletePart.Visible = true;
                btnRestore.Visible = true;
                btnAddPart.Visible = false;
                btnClear.Visible = false;
                lblAddNew.Text = "Update The Service";

            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtSKU.Text = "";
            txtTime.Text = "";
            txtPrice.Text = "";
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            restore();
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want delete this Service?.", "Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().DeleteService(int.Parse(txtId.Text));
                    ServiceLoad();
                    restore();
                    MessageBox.Show("Service delete Succefully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong. Please try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtSKU.Text == "" || txtTime.Text == "" || txtPrice.Text == "")
            {
                MessageBox.Show("All fieds are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dr = MessageBox.Show("Do you want update this Service record?.", "Update", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().UpdateService(txtName.Text, txtSKU.Text, txtTime.Text, int.Parse(txtPrice.Text), int.Parse(txtId.Text));
                        ServiceLoad();
                        restore();
                        MessageBox.Show("Service Updated Succefully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Something went wrong. Please try again later!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
                
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            ServiceLoad();
            ServiceBookingLoad();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search term is empty! Please fill it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServiceLoad();
                return;
            }
            else
            {
                ABCTraders.ServicesDataTable data = null;
                string txt = txtSearch.Text;
                data = new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().GetByName(txt);
                if (data.Count == 0)
                {
                    data = new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().GetBySKU(txt);
                }

                ServiceGrid.DataSource = data.DefaultView;
                ServiceGrid.AutoGenerateColumns = false;
            }
        }

        private void btnUserBookingForm_Click(object sender, EventArgs e)
        {
            //this.Hide();

            //UserBooking userBookingForm = new UserBooking();
            //userBookingForm.Show();
            //userBookingForm.BringToFront();

            ServiceBookingGrid.Visible = true;
            ServiceGrid.Visible = false;
            ServiceBookingLoad();
            btnAdminServices.Visible = true;
            btnUserBookingForm.Visible = false;
            btnBookingSearch.Visible = true;
            btnSearch.Visible = false;

            btnUpdate.Visible = false;
            btnDeletePart.Visible = false;
            btnRestore.Visible = false;
            btnAddPart.Visible = false;
            btnClear.Visible = false;
            lblTimeDuration.Visible = false;
            lblTimeDuration2.Visible = false;
            txtTime.Visible = false;
            lblUserDate.Visible = true;
            dateTimePickerUserBooking.Visible = true;


        }

        private void btnAdminServices_Click(object sender, EventArgs e)
        {
            ServiceGrid.Visible = true;
            ServiceBookingGrid.Visible = false;
            ServiceLoad();
            btnAdminServices.Visible = false;
            btnUserBookingForm.Visible = true;
            btnBookingSearch.Visible = false;
            btnSearch.Visible = true;

            btnUpdate.Visible = false;
            btnDeletePart.Visible = false;
            btnRestore.Visible = false;
            btnAddPart.Visible = true;
            btnClear.Visible = true;
            lblTimeDuration.Visible = true;
            lblTimeDuration2.Visible = true;
            txtTime.Visible = true;
            lblUserDate.Visible = false;
            dateTimePickerUserBooking.Visible = false;

        }

        private void btnBookingSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                MessageBox.Show("Search term is empty! Please fill it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ServiceBookingLoad();
                return;
            }
            else
            {
                ABCTraders.UserServicesDataTable data = null;
                string txt = txtSearch.Text;
                data = new DataSet.ABCTradersTableAdapters.UserServicesTableAdapter().GetByName(txt);
                if (data.Count == 0)
                {
                    data = new DataSet.ABCTradersTableAdapters.UserServicesTableAdapter().GetBySKU(txt);
                }

                ServiceBookingGrid.DataSource = data.DefaultView;
                ServiceBookingGrid.AutoGenerateColumns = false;
            }
        }

        private void ServiceBookingGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewRow row = this.ServiceGrid.Rows[e.RowIndex];
            //int id = int.Parse(row.Cells["ID"].Value.ToString());
            //ABCTraders.ServicesDataTable data = new DataSet.ABCTradersTableAdapters.ServicesTableAdapter().GeById(id);
            //txtId.Text = data[0].SId.ToString();
            //txtName.Text = data[0].Name;
            //txtSKU.Text = data[0].SKU;
            //txtTime.Text = data[0].Time;
            //txtPrice.Text = data[0].Price.ToString();
            //btnUpdate.Visible = true;
            //btnDeletePart.Visible = true;
            //btnRestore.Visible = true;
            //btnAddPart.Visible = false;
            //btnClear.Visible = false;
            //lblAddNew.Text = "Update The Service";

            try
            {
                
                DataGridViewRow row = this.ServiceBookingGrid.Rows[e.RowIndex];
                int id = int.Parse(row.Cells["ID"].Value.ToString());
                ABCTraders.UserServicesDataTable data = new DataSet.ABCTradersTableAdapters.UserServicesTableAdapter().GetById(id);
                txtId.Text = data[0].SId.ToString();
                txtName.Text = data[0].Name;
                txtSKU.Text = data[0].SKU;
                dateTimePickerUserBooking.Value = data[0].Date;
                txtPrice.Text = data[0].Price.ToString();
                btnUpdate.Visible = false;
                btnDeletePart.Visible = false;
                btnRestore.Visible = false;
                btnAddPart.Visible = false;
                btnClear.Visible = false;
                lblAddNew.Text = "Service Booking";
            }
            catch (Exception)
            {

                //throw;
            }

            
        }
    }
}
