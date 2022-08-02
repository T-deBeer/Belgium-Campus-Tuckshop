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
            //Initializes List Boxes

            mtbxCustomerName.Focus();
            mtxRingUp.Enabled = false;
            mbtnPay.Enabled = false;
            mbtnNext.Enabled = false;
            mtbxAmountPaid.Enabled = false;

            List<ItemModel> PopularItemList = SqliteDataAccess.LoadPopularItems();

            foreach (var item in PopularItemList)
            {
                ListBoxPopular.Items.Add(item.ProductName);
            }

            List<ItemModel> FoodItemlist = SqliteDataAccess.LoadFoodItems();

            foreach (var item in FoodItemlist)
            {
                ListBoxFood.Items.Add(item.ProductName);
            }

            List<ItemModel> ColdDrinksList = SqliteDataAccess.LoadColdDrinks();

            foreach (var item in ColdDrinksList)
            {
               ListBoxColdDrinks.Items.Add(item.ProductName);
            }

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

            AmountPaid = mtbxAmountPaid.Text;
            result = int.TryParse(AmountPaid, out i);

                if ((result ==  true) )
                {
                    PaidAmount = Convert.ToDouble(AmountPaid);

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

    

        private void mbtnNext_Click(object sender, EventArgs e)
        {
            string CustomerName = "";

            CustomerName = mtbxCustomerName.Text;
            bool Result = CustomerName.All(char.IsLetter);


            if (Result == true)
            {
                if (CustomerName != "")
                {
                    
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
            UserMenu myUserForm = new UserMenu();
            myUserForm.ShowDialog();
            
            this.Close();
        }
    }
}
