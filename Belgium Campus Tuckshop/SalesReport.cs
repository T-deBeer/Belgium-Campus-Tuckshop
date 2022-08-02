using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroSet_UI.Forms;

namespace Belgium_Campus_Tuckshop
{
    public partial class SalesReport : MetroSetForm
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result;

                Result = MessageBox.Show("Are you sure you want to delete this sale?", "Caution!", MessageBoxButtons.YesNoCancel);

                if (Result == DialogResult.Yes)
                {
                    string name = lbxCustomers.GetItemText(lbxCustomers.SelectedIndex);
                    string date = DateTime.Now.ToString();

                    ClassLibrary.SqliteDataAccess.DeleteSale(date, name);
                    lbxCustomers.Items.Remove(lbxCustomers.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following exception was raised: " + ex.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            rtbxReceipt.ResetText();

            string Day = dateTimePicker1.Value.Day.ToString();
            int Month = dateTimePicker1.Value.Month;
            string Year = dateTimePicker1.Value.Year.ToString();

            try
            {
                List<ClassLibrary.SaleModel> listDatedSales = ClassLibrary.SqliteDataAccess.LoadSalesByDate(DateOnly.FromDateTime(DateTime.Today.Date).ToString());

                foreach (var saleModel in listDatedSales)
                {
                    if (dateTimePicker1.Value.ToString().Contains(saleModel.SaleDate))
                    {
                        lbxCustomers.Items.Add(saleModel.CustomerName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Database could not be loaded succesfully. Exception raised: " + ex.Message);
            }

            try
            {
                lblCustomers.Text = "Customers On " + DetermineMonth(Month) + " " + Day + " " + Year;
                lbxCustomers.Items.Clear();
            }
            catch (FormatException ex2)
            {
                MessageBox.Show("The DateTime format could not be configured. Exception raised: " + ex2.Message);
            }
        }

        public static string DetermineMonth(int Month)
        {
            switch (Month)
            {
                case 1:
                    {
                        return "January";
                    }
                case 2:
                    {
                        return "February";
                    }
                case 3:
                    {
                        return "March";
                    }
                case 4:
                    {
                        return "April";
                    }
                case 5:
                    {
                        return "May";
                    }
                case 6:
                    {
                        return "June";
                    }
                case 7:
                    {
                        return "July";
                    }
                case 8:
                    {
                        return "August";
                    }
                case 9:
                    {
                        return "September";
                    }
                case 10:
                    {
                        return "October";
                    }
                case 11:
                    {
                        return "November";
                    }
                case 12:
                    {
                        return "December";
                    }
                default:
                    {
                        throw new Exception("Date could noot be configured");
                    }
            }
        }

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                List<ClassLibrary.SaleModel> listSales = ClassLibrary.SqliteDataAccess.LoadAllSales();

                lblReceipt.Text = "Receipt for " + lbxCustomers.GetItemText(lbxCustomers.SelectedItem);
                rtbxReceipt.ResetText();
                rtbxReceipt.Text += "ITEM NAME \tBASE PRICE \tQTY \tPRICE";
                rtbxReceipt.Text += "\n-----------------------------------------";

                foreach (ClassLibrary.SaleModel saleModel in listSales)
                {
                    if (lbxCustomers.GetItemText(lbxCustomers.SelectedIndex) == saleModel.CustomerName)
                    {
                        rtbxReceipt.Text = saleModel.Receipt;
                    }
                }

                rtbxReceipt.Text += "\n-----------------------------------------";
            }
            catch (Exception ex)
            {
                MessageBox.Show("The Database could not be accesed or processed correctly: " + ex.Message);
            }
        }

        private void mbtnAddItem_Click(object sender, EventArgs e)
        {
            int Month;
            string Year;

            try
            {
                Month = dateTimePicker1.Value.Month;
                Year = (dateTimePicker1.Value.Year.ToString());

                List<ClassLibrary.SaleModel> salesList = ClassLibrary.SqliteDataAccess.LoadMonthlySales(Month.ToString(), Year);

                rtbxReceipt.ResetText();
                int amountSales = 0;

                rtbxReceipt.Text += "MONTH REPORT FOR " + DetermineMonth(Month).ToUpper();
                rtbxReceipt.Text += "\n-----------------------------------------";

                foreach (var s in salesList)
                {
                    rtbxReceipt.Text += s.CustomerName + "\t" + s.SaleDate + "\t";
                    amountSales++;
                }

                rtbxReceipt.Text += "\n-----------------------------------------";
                rtbxReceipt.Text += "\nAmount of sales during the month: " + amountSales;
                rtbxReceipt.Text += "\n-----------------------------------------";
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following exception was raised: " + ex.Message);
            }
        }
    }
}
