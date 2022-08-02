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
                    string date = dateTimePicker1.Value.ToString("MM/dd/yyyy"); 

                    ClassLibrary.SqliteDataAccess.DeleteSale(date, name);
                    lbxCustomers.Items.Remove(lbxCustomers.SelectedIndex);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following exception was raised: " + ex.Message);
            }

            try
            {
                List<ClassLibrary.SaleModel> listSales = ClassLibrary.SqliteDataAccess.LoadAllSales();
                string Date = dateTimePicker1.Value.ToString("MM/dd/yyyy");
                lbxCustomers.Items.Clear();
                rtbxReceipt.Text = "";

                foreach (var saleModel in listSales)
                {
                    if (saleModel.SaleDate == Date)
                    {
                        lbxCustomers.Items.Add(saleModel.CustomerName);
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("The following exception was raised: " + ex1.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            rtbxReceipt.ResetText();

            int Day = dateTimePicker1.Value.Day;
            int Month = dateTimePicker1.Value.Month;
            int Year = dateTimePicker1.Value.Year;

            string Date = dateTimePicker1.Value.ToString("MM/dd/yyyy");

            try
            {
                List<ClassLibrary.SaleModel> listSales = ClassLibrary.SqliteDataAccess.LoadAllSales();

                foreach (var saleModel in listSales)
                {
                    if (saleModel.SaleDate == Date)
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

                foreach (ClassLibrary.SaleModel saleModel in listSales)
                {
                    if (lbxCustomers.SelectedItem.ToString() == saleModel.CustomerName)
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
            string StringMonth;

            try
            {
                Month = dateTimePicker1.Value.Month;
                StringMonth = dateTimePicker1.Value.ToString("MM");
                Year = (dateTimePicker1.Value.Year.ToString());

                List<ClassLibrary.SaleModel> salesList = ClassLibrary.SqliteDataAccess.LoadMonthlySales(StringMonth, Year);

                rtbxReceipt.ResetText();
                int amountSales = 0;

                rtbxReceipt.Text += "MONTH REPORT FOR " + DetermineMonth(Month).ToUpper();
                rtbxReceipt.Text += "\n-----------------------------------------";

                foreach (var s in salesList)
                {
                    rtbxReceipt.Text += "\n" + s.CustomerName + "\t\t" + s.SaleDate;
                    rtbxReceipt.Text += "\n-----------------------------------------";
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

        private void mbtnBack_Click(object sender, EventArgs e)
        {
            UserMenu myUserForm = new UserMenu();
            myUserForm.ShowDialog();

            this.Hide();
        }
    }
}
