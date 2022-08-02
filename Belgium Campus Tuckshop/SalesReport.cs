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

        private void mbtnDelete_Click(object sender, EventArgs e) //Delete Button for deleting sales
        {
            try
            {
                DialogResult Result;

                //Display confirmation message before deleting

                Result = MessageBox.Show("Are you sure you want to delete this sale?", "Caution!", MessageBoxButtons.YesNoCancel);

                if (Result == DialogResult.Yes)
                {
                    // Gets index, name, and date of sale customer to delete 

                    string name = lbxCustomers.SelectedItem.ToString();
                    string date = dateTimePicker1.Value.ToString("MM/dd/yyyy"); 

                    //Call the delete function

                    ClassLibrary.SqliteDataAccess.DeleteSale(date, name);
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

                //Loops through the database

                foreach (var saleModel in listSales)
                {
                    //Tests if the date in the database is equal to the datetimepicker

                    if (saleModel.SaleDate == Date)
                    {
                        //If the dates are equal, display the customer's name

                        lbxCustomers.Items.Add(saleModel.CustomerName);
                    }
                }
            }
            catch (Exception ex1)
            {
                MessageBox.Show("The following exception was raised: " + ex1.Message);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) //Display the customers on a certain date
        {
            rtbxReceipt.ResetText();

            //Decompose the datetimepicker to display the day, month and year seperately

            int Day = dateTimePicker1.Value.Day;
            int Month = dateTimePicker1.Value.Month;
            int Year = dateTimePicker1.Value.Year;

            //Store datetimepicker in string variable to compare to the database's date

            string Date = dateTimePicker1.Value.ToString("MM/dd/yyyy");

            try
            {
                List<ClassLibrary.SaleModel> listSales = ClassLibrary.SqliteDataAccess.LoadAllSales();

                //Loops through the database

                foreach (var saleModel in listSales)
                {
                    //If the dates are equal, display the customer's name

                    if (saleModel.SaleDate == Date)
                    {
                        //If the dates are equal, display the customer's name

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
                //Display the date in the label above the listbox

                lblCustomers.Text = "Customers On " + DetermineMonth(Month) + " " + Day + " " + Year;
            }
            catch (FormatException ex2)
            {
                MessageBox.Show("The DateTime format could not be configured. Exception raised: " + ex2.Message);
            }
        }

        public static string DetermineMonth(int Month) //This method determines the month name with the month number as a parameter
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

        private void lbxCustomers_SelectedIndexChanged(object sender, EventArgs e) //Display the customer's receipt
        {
            try
            {
                List<ClassLibrary.SaleModel> listSales = ClassLibrary.SqliteDataAccess.LoadAllSales();

                //Display the recepitent's name in the label above the richeditbox

                lblReceipt.Text = "Receipt for " + lbxCustomers.GetItemText(lbxCustomers.SelectedItem);
                rtbxReceipt.ResetText();

                //Loops through the database 

                foreach (ClassLibrary.SaleModel saleModel in listSales)
                {
                    //Checks if the customer's name in the listbox is equal to the database's customername

                    if (lbxCustomers.SelectedItem.ToString() == saleModel.CustomerName)
                    {
                        //If it is equal, display the customer's receipt

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

        private void mbtnAddItem_Click(object sender, EventArgs e) //Creates a month report listing all the month's sales
        {
            int Month;
            string Year;
            string StringMonth;

            try
            {
                //Decomposes the datetimepicker to get the month

                Month = dateTimePicker1.Value.Month;
                StringMonth = dateTimePicker1.Value.ToString("MM");
                Year = (dateTimePicker1.Value.Year.ToString());

                List<ClassLibrary.SaleModel> salesList = ClassLibrary.SqliteDataAccess.LoadMonthlySales(StringMonth, Year);

                rtbxReceipt.ResetText();
                int amountSales = 0;

                rtbxReceipt.Text += "MONTH REPORT FOR " + DetermineMonth(Month).ToUpper();
                rtbxReceipt.Text += "\n-----------------------------------------";

                //Loops through the database where the month is equal to the datetimepicker

                foreach (var s in salesList)
                {
                    rtbxReceipt.Text += "\n" + s.CustomerName + "\t\t" + s.SaleDate;
                    rtbxReceipt.Text += "\n-----------------------------------------";
                    amountSales++;
                }

                //Displays the amount of sales in the month

                rtbxReceipt.Text += "\n-----------------------------------------";
                rtbxReceipt.Text += "\nAmount of sales during the month: " + amountSales;
                rtbxReceipt.Text += "\n-----------------------------------------";
            }
            catch (Exception ex)
            {
                MessageBox.Show("The following exception was raised: " + ex.Message);
            }
        }

        private void mbtnBack_Click(object sender, EventArgs e) //Returns to the Main Menu of the program
        {
            UserMenu myUserForm = new UserMenu();
            myUserForm.ShowDialog();

            this.Hide(); //Hides current form
        }
    }
}
