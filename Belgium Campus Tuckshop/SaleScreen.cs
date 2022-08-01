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

        private void metroSetListBox1_SelectedIndexChanged(object sender)
        {
            rtbxReceipt.Text += ListBoxPopular.SelectedItem.ToString();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages["tabPage1"])
            {
                MessageBox.Show("boi");
            }
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







        }
    }
}
