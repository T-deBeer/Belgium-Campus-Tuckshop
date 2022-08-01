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

        // Calls up the GetSelectedItem method to display selected item details.
        private void metroSetListBox1_SelectedIndexChanged(object sender)
        {
            string ItemName = "";
            int ItemQuantity = 0;
            bool validInput = false;

            ItemName = ListBoxPopular.SelectedItem.ToString();
            ItemQuantity = Convert.ToInt32(setNumeric.Value);

            //rtbxReceipt.AppendText("\n" + );
            ListBoxOutput.Items.Add(SalesOutput.GetSelectedItem(ItemName, ItemQuantity));



        }

        private void ListBoxFood_SelectedIndexChanged(object sender)
        {
            string ItemName = "";
            int ItemQuantity = 0;
            bool validInput = false;

            ItemName = ListBoxFood.SelectedItem.ToString();
            ItemQuantity = Convert.ToInt32(setNumeric.Value);

            // rtbxReceipt.AppendText("\n" + SalesOutput.GetSelectedItem(ItemName, ItemQuantity));
            ListBoxOutput.Items.Add(SalesOutput.GetSelectedItem(ItemName, ItemQuantity));
        }

        private void ListBoxColdDrinks_SelectedIndexChanged(object sender)
        {
            string ItemName = "";
            int ItemQuantity = 0;
            bool validInput = false;

            ItemName = ListBoxColdDrinks.SelectedItem.ToString();
            ItemQuantity = Convert.ToInt32(setNumeric.Value);

            // rtbxReceipt.AppendText("\n" + SalesOutput.GetSelectedItem(ItemName, ItemQuantity));
            ListBoxOutput.Items.Add(SalesOutput.GetSelectedItem(ItemName, ItemQuantity));
        }

        private void ListBoxHotDrinks_SelectedIndexChanged(object sender)
        {
            string ItemName = "";
            int ItemQuantity = 0;
            bool validInput = false;

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

            ListBoxOutput.Items.Add("Item Name\tBase Price\tQty\tPrice");
            ListBoxOutput.Items.Add("-------------------------------------------------------------------------");
            
            

        }

        private void metroSetLabel1_Click(object sender, EventArgs e)
        {

        }

        private void mbtnPay_Click(object sender, EventArgs e)
        {

        }

        private void mtbxAmountPaid_Click(object sender, EventArgs e)
        {
            string AmountPaid;

            try
            {
                AmountPaid = mtbxAmountPaid.Text;
            }
            catch
            {
                MessageBox.Show("Invalid entry,please enter in a valid amount");
                mtbxAmountPaid.Focus();
                AmountPaid = mtbxAmountPaid.Text;
            }
            finally
            {
                MessageBox.Show("Valid entry");
            }
        }

        // Rings up the bill
        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            double AmountOwed = 0;
            double SumTotal = SalesOutput.SumTotal.TotalSum;
            double Vat = 0;

            Vat = Vat + (SumTotal * (15 / 100));

            ListBoxOutput.Items.Add("-------------------------------------------------------------------------");
            ListBoxOutput.Items.Add("Total:  R" + SalesOutput.SumTotal.TotalSum);
            ListBoxOutput.Items.Add("Vat: R" +  Vat);
        }

        private void mbtnRemove_Click(object sender, EventArgs e)
        {
          
        }
    }
}
