using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ABC_traders.DataSet;
using ABC_traders.Forms;
namespace ABC_traders.Reports
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            btnCreateReport.BackColor = Class.ThemeColor.PrimaryColor;
            
        }





        // Populate ComboBox with report types
        //comboBoxReportType.Items.Add("Orders - Last 30 Days");
        //comboBoxReportType.Items.Add("Car Orders - Last 30 Days");
        //comboBoxReportType.Items.Add("Car Parts Orders - Last 30 Days");
        //comboBoxReportType.Items.Add("Services - Last 30 Days");
        //comboBoxReportType.SelectedIndex = 0; // Set default selection

        private void btnCreateReport_Click(object sender, EventArgs e)
        {

            if (comboBoxReportCreate.SelectedIndex == 0)
            {
                ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetData();
                ABCTraders.OrdersDataTable tb = new ABCTraders.OrdersDataTable();


                for (int i = 0; i < data.Count; i++)
                {
                    ABCTraders.OrdersRow cr = tb.NewOrdersRow();
                    ABCTraders.OrdersRow RecRow = null;
                    RecRow = data.Rows[i] as ABCTraders.OrdersRow;

                    cr.ProId = RecRow.ProId;
                    cr.OrderId = RecRow.OrderId;
                    cr.ProName = RecRow.ProName;
                    cr.ProType = RecRow.ProType;
                    cr.Qty = RecRow.Qty;
                    cr.Rate = RecRow.Rate;
                    cr.CusID = RecRow.CusID;
                    cr.Amount = RecRow.Amount;
                    cr.OrderId = RecRow.OrderId;
                    tb.Rows.Add(cr);
                }
                Orders myrpt = new Orders();
                myrpt.SetDataSource((DataTable)tb);
                crystalReportViewer1.ReportSource = myrpt;
            }
            else if (comboBoxReportCreate.SelectedIndex == 1)
            {
                ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetByType("Car");
                ABCTraders.OrdersDataTable tb = new ABCTraders.OrdersDataTable();


                for (int i = 0; i < data.Count; i++)
                {
                    ABCTraders.OrdersRow cr = tb.NewOrdersRow();
                    ABCTraders.OrdersRow RecRow = null;
                    RecRow = data.Rows[i] as ABCTraders.OrdersRow;

                    cr.ProId = RecRow.ProId;
                    cr.OrderId = RecRow.OrderId;
                    cr.ProName = RecRow.ProName;
                    cr.ProType = RecRow.ProType;
                    cr.Qty = RecRow.Qty;
                    cr.Rate = RecRow.Rate;
                    cr.CusID = RecRow.CusID;
                    cr.Amount = RecRow.Amount;
                    cr.OrderId = RecRow.OrderId;
                    tb.Rows.Add(cr);
                }
                Orders myrpt = new Orders();
                myrpt.SetDataSource((DataTable)tb);
                crystalReportViewer1.ReportSource = myrpt;
            }
            else if (comboBoxReportCreate.SelectedIndex == 2)
            {
                ABCTraders.OrdersDataTable data = new DataSet.ABCTradersTableAdapters.OrdersTableAdapter().GetByType("Parts");
                ABCTraders.OrdersDataTable tb = new ABCTraders.OrdersDataTable();


                for (int i = 0; i < data.Count; i++)
                {
                    ABCTraders.OrdersRow cr = tb.NewOrdersRow();
                    ABCTraders.OrdersRow RecRow = null;
                    RecRow = data.Rows[i] as ABCTraders.OrdersRow;

                    cr.ProId = RecRow.ProId;
                    cr.OrderId = RecRow.OrderId;
                    cr.ProName = RecRow.ProName;
                    cr.ProType = RecRow.ProType;
                    cr.Qty = RecRow.Qty;
                    cr.Rate = RecRow.Rate;
                    cr.CusID = RecRow.CusID;
                    cr.Amount = RecRow.Amount;
                    cr.OrderId = RecRow.OrderId;
                    tb.Rows.Add(cr);
                }
                Orders myrpt = new Orders();
                myrpt.SetDataSource((DataTable)tb);
                crystalReportViewer1.ReportSource = myrpt;
            }
            else if (comboBoxReportCreate.SelectedIndex == 3)
            {
                ABCTraders.UserServicesDataTable data = new DataSet.ABCTradersTableAdapters.UserServicesTableAdapter().GetData();
                ABCTraders.UserServicesDataTable tb = new ABCTraders.UserServicesDataTable();


                for (int i = 0; i < data.Count; i++)
                {
                    ABCTraders.UserServicesRow cr = tb.NewUserServicesRow();
                    ABCTraders.UserServicesRow RecRow = null;
                    RecRow = data.Rows[i] as ABCTraders.UserServicesRow;

                    cr.ServiceBookId = RecRow.ServiceBookId;
                    cr.CusID = RecRow.CusID;
                    cr.SId = RecRow.SId;
                    cr.Name = RecRow.Name;
                    cr.SKU = RecRow.SKU;
                    cr.Price = RecRow.Price;
                    cr.Date = RecRow.Date;
                    tb.Rows.Add(cr);
                }
                UserServices myrpt = new UserServices();
                myrpt.SetDataSource((DataTable)tb);
                crystalReportViewer1.ReportSource = myrpt;
            }
            else
            {
                MessageBox.Show("Please Select Report to create", "Report Generate Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
   
    }
}
