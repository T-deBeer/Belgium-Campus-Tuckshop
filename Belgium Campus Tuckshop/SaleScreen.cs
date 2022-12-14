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
using ClassLibrary;

namespace Belgium_Campus_Tuckshop
{
    public partial class SalesScreen : MetroSetForm
    {

        public SalesScreen()
        {
            InitializeComponent();
            
        }

        private void mtbxCustomerName_Click(object sender, EventArgs e)
        {
            
        }


        // Calls up the GetSelectedItem method to display selected item details for popular Items.
        private void metroSetListBox1_SelectedIndexChanged(object sender)
        {
            mtxRingUp.Enabled = true;
            string ItemName = "";
            int ItemQuantity = 0;

            ItemName = ListBoxPopular.SelectedItem.ToString();
            ItemQuantity = Convert.ToInt32(setNumeric.Value);

            ListBoxOutput.Items.Add(SalesOutput.GetSelectedItem(ItemName, ItemQuantity));

        }

        // Calls up the GetSelectedItem method to display selected item details for Food Items.

        private void ListBoxFood_SelectedIndexChanged(object sender)
        {
            mtxRingUp.Enabled = true;
            string ItemName = "";
            int ItemQuantity = 0;

            ItemName = ListBoxFood.SelectedItem.ToString();
            ItemQuantity = Convert.ToInt32(setNumeric.Value);

            ListBoxOutput.Items.Add(SalesOutput.GetSelectedItem(ItemName, ItemQuantity));
        }

        // Calls up the GetSelectedItem method to display selected item details for Cold Drinks.
        private void ListBoxColdDrinks_SelectedIndexChanged(object sender)
        {
            mtxRingUp.Enabled = true;
            string ItemName = "";
            int ItemQuantity = 0;

            ItemName = ListBoxColdDrinks.SelectedItem.ToString();
            ItemQuantity = Convert.ToInt32(setNumeric.Value);

            ListBoxOutput.Items.Add(SalesOutput.GetSelectedItem(ItemName, ItemQuantity));
        }

        // Calls up the GetSelectedItem method to display selected item details for Hot Drinks.

        private void ListBoxHotDrinks_SelectedIndexChanged(object sender)
        {
            mtxRingUp.Enabled = true;
            string ItemName = "";
            int ItemQuantity = 0;

            ItemName = ListBoxHotDrinks.SelectedItem.ToString();
            ItemQuantity = Convert.ToInt32(setNumeric.Value);

            ListBoxOutput.Items.Add(SalesOutput.GetSelectedItem(ItemName, ItemQuantity));
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SalesScreen_Load(object sender, EventArgs e)
        {

            mtbxCustomerName.Focus();
            mtxRingUp.Enabled = false;
            mbtnPay.Enabled = false;
            mbtnNext.Enabled = false;
            mtbxAmountPaid.Enabled = false;

            // Populates the Popular Item List.

            List<ItemModel> PopularItemList = SqliteDataAccess.LoadPopularItems();

            foreach (var item in PopularItemList)
            {
                ListBoxPopular.Items.Add(item.ProductName);
            }

            // Populates the Food Item List.

            List<ItemModel> FoodItemlist = SqliteDataAccess.LoadFoodItems();

            foreach (var item in FoodItemlist)
            {
                ListBoxFood.Items.Add(item.ProductName);
            }

            // Populates the cold drinks list.

            List<ItemModel> ColdDrinksList = SqliteDataAccess.LoadColdDrinks();

            foreach (var item in ColdDrinksList)
            {
               ListBoxColdDrinks.Items.Add(item.ProductName);
            }

            // Populates the hot drinks list.

            List<ItemModel> HotDrinksList = SqliteDataAccess.LoadHotDrinks();

            foreach (var item in HotDrinksList)
            {
                ListBoxHotDrinks.Items.Add(item.ProductName);
            }
            ListBoxOutput.Items.Add("-------------------------------------------------------------------------");

        }

        private void metroSetLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mbtnPay_Click(object sender, EventArgs e)
        {
            int i = 0;
            string AmountPaid;
            bool result = false;
            double PaidAmount,ChangeOwed = 0;

            mbtnNext.Enabled = true;

            //checks if the amount paid is a number 

            AmountPaid = mtbxAmountPaid.Text;
            result = int.TryParse(AmountPaid, out i);

                if ((result ==  true) )
                {
                    PaidAmount = Convert.ToDouble(AmountPaid);
                
                    // Checks if he Paid Amount is greater than the total bill                

                    if (PaidAmount >= SalesOutput.SumTotal.TotalSum)
                    {
                        ChangeOwed = PaidAmount - SalesOutput.SumTotal.TotalSum;
                        lblChange.Text = "Change required: R" + Math.Round(ChangeOwed,2);
                    }
                    else
                    {
                    MessageBox.Show("Invalid Amount entered");
                    }      
                }
                else
                {
                    MessageBox.Show("Please enter a number value ");
                    mtbxAmountPaid.Focus();
                }
        }

        private void mtbxAmountPaid_Click(object sender, EventArgs e)
        {

        }

        // Rings up the bill
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            double SumTotal = Math.Round(SalesOutput.SumTotal.TotalSum,2) ;
            mbtnPay.Enabled = true;
            mtbxAmountPaid.Enabled = true;

            ListBoxOutput.Items.Add("-------------------------------------------------------------------------");
            ListBoxOutput.Items.Add("Total:  R" + SumTotal);
      
        }

        /// <summary>
        /// This method validates that the user has entered a customer name.
        /// once this is validated, the sale is exported to the database into the sales table.
        /// </summary>
        private void mbtnNext_Click(object sender, EventArgs e)
        {
            string CustomerName = "";

            CustomerName = mtbxCustomerName.Text;
            bool Result = CustomerName.All(char.IsLetter);
            var dateToday = DateTime.Now;
       ;

            string RecieptText ="";

            SaleModel sale = new SaleModel();


            if (Result == true)
            {
                if (CustomerName != "")
                {
                    
                    for (int i = 0; i < ListBoxOutput.Count; i++)
                    {
                        RecieptText += "\n" + ListBoxOutput.Items[i].ToString();
                    }

                    // Provides the values that need to be added to the data base
                    sale = new SaleModel();
                    sale.CustomerName = CustomerName;
                    sale.Receipt = RecieptText;
                    sale.SaleDate = DateTime.Now.ToString("MM\\/dd\\/yyyy");


                    SqliteDataAccess.InsertSale(sale);
                    
                }
                else
                {
                    MessageBox.Show("Please enter a customer name to continue");
                }
            }
            else
            {
                MessageBox.Show("Invalid Input , please enter the customer name");
                mtbxCustomerName.Focus();
            }

        }

        private void mbtnBack_Click(object sender, EventArgs e)
        {
            var confirmation = MessageBox.Show("Are you sure you want to return to menu.", "Return to Menu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                UserMenu form = new UserMenu();
                form.Show();
                this.Hide();
            }
        }
    }
}
