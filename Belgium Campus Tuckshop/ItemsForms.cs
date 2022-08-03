using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using MetroSet_UI.Forms;

namespace Belgium_Campus_Tuckshop
{
    public partial class ItemsForms : MetroSetForm
    {
        public ItemsForms()
        {
            InitializeComponent();
        }


        private void mbtnAddItem_Click(object sender, EventArgs e)
        {




        }

        private void mbtnUpdate_Click(object sender, EventArgs e)
        {
            ItemModel updatedItem = new ItemModel();
            List<ItemModel> ItemList = SqliteDataAccess.LoadAllItems();
            foreach (var item in ItemList)
            {
                if (item.ProductName == lbxItemList.SelectedIndex.ToString())
                {
                    updatedItem.ProductName = mtbxItemName.Text;
                    updatedItem.ItemDescription = mtbxItemDesc.Text;
                    updatedItem.ProductCost = double.Parse(mtbxItemCost.Text);
                    updatedItem.ProductType = mtbxItemType.Text;
                    //updatedItem.Popular = 1;
                    SqliteDataAccess.UpdateItem(updatedItem, item.ProductName);
                }
            }
        }
        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Result;

                Result = MessageBox.Show("Are you sure you want to delete this item?", "Caution!", MessageBoxButtons.YesNoCancel);

                if (Result == DialogResult.Yes)
                {
                    string name = lbxItemList.GetItemText(lbxItemList.SelectedIndex);

                    ClassLibrary.SqliteDataAccess.DeleteItem(name);
                    lbxItemList.Items.Remove(lbxItemList.SelectedIndex);
                }
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

            this.Close();
        }
    }
}
