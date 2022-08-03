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
using MetroSet_UI;
using MetroSet_UI.Components;
using MetroSet_UI.Controls;
using ClassLibrary;

namespace Belgium_Campus_Tuckshop
{
    public partial class ItemsForms : MetroSetForm
    {
        List<ItemModel> allItems = SqliteDataAccess.LoadAllItems();


        public ItemsForms()
        {
            InitializeComponent();
            LoadItemsInListBoxes();

        }

        //Responsible for loading exsisting products to the ListBoxes
        private void LoadItemsInListBoxes()
        {
            allItems = SqliteDataAccess.LoadAllItems();
            List<ItemModel> popularItems = SqliteDataAccess.LoadPopularItems();
            List<ItemModel> foodItems = SqliteDataAccess.LoadFoodItems();
            List<ItemModel> hotDrinkItems = SqliteDataAccess.LoadHotDrinks();
            List<ItemModel> coldDrinkItems = SqliteDataAccess.LoadColdDrinks();


            ListBoxFood.SelectedIndex = -1;
            ListBoxPopular.SelectedIndex = -1;
            ListBoxColdDrinks.SelectedIndex = -1;
            ListBoxHotDrinks.SelectedIndex = -1;

            ListBoxFood.Items.Clear();
            ListBoxPopular.Items.Clear();
            ListBoxColdDrinks.Items.Clear();
            ListBoxHotDrinks.Items.Clear();

            foreach (var item in popularItems)
            {
                ListBoxPopular.Items.Add(item.ProductName);
            }

            foreach (var item in foodItems)
            {
                ListBoxFood.Items.Add(item.ProductName);
            }
            foreach (var item in hotDrinkItems)
            {
                ListBoxHotDrinks.Items.Add(item.ProductName);
            }
            foreach (var item in coldDrinkItems)
            {
                ListBoxColdDrinks.Items.Add(item.ProductName);
            }
        }

        private void LoadItemInformation(ItemModel selectedItem)
        {
            mtbxItemCost.Text = selectedItem.ProductCost.ToString();
            mtbxItemName.Text = selectedItem.ProductName;

            foreach (var option in cbxItemType.Items)
            {
                if (selectedItem.ProductType == option.ToString())
                {
                    cbxItemType.SelectedItem = option;
                }
            }

            mtbxDescription.Text = selectedItem.ItemDescription;
            mswPopular.Switched = Convert.ToBoolean(selectedItem.Popular);
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

        private void ListBoxPopular_SelectedIndexChanged(object sender)
        {
            ItemLoad(ListBoxPopular);
        }

        private void ItemLoad(MetroSetListBox listBox)
        {
            foreach (var item in allItems)
            {
                if (listBox.SelectedItem.ToString() == item.ProductName)
                {
                    LoadItemInformation(item);
                }
            }
        }

        private void ListBoxFood_SelectedIndexChanged(object sender)
        {
            ItemLoad(ListBoxFood);
        }

        private void ListBoxColdDrinks_SelectedIndexChanged(object sender)
        {
            ItemLoad(ListBoxColdDrinks);
        }

        private void ListBoxHotDrinks_SelectedIndexChanged(object sender)
        {
            ItemLoad(ListBoxHotDrinks);
        }


        //Deletes a selected item from the database
        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            bool deleted = false;

            //If an item has been selected
            if (AllFieldsEntered())
            {
                var confirmation = MessageBox.Show("Are you sure you want to delete the item.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //If user confirms the deletion of the item
                if (confirmation == DialogResult.Yes)
                {
                    foreach (var item in allItems)
                    {
                        //Finds the product to delete
                        if (mtbxItemName.Text == item.ProductName)
                        {

                            SqliteDataAccess.DeleteItem(item.ProductName);
                            MessageBox.Show("The item has been deleted from the database.");
                            deleted = true;
                        }
                    }

                    //Reloads the list boxes with the new updated database
                    LoadItemsInListBoxes();
                    ResetControls();
                }
            }
            else
            {
                MessageBox.Show("You need to select an item before you can delete one.");
            }
        }

        private void mbtnUpdate_Click(object sender, EventArgs e)
        {
            bool updated = false;

            if (AllFieldsEntered())
            {
                var confirmation = MessageBox.Show("Are you sure you want to update the item.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    foreach (var item in allItems)
                    {
                        if (mtbxItemName.Text == item.ProductName)
                        {
                            ItemModel updatedItem = new ItemModel();

                            try
                            {
                                updatedItem.ProductName = mtbxItemName.Text;
                                updatedItem.ProductType = cbxItemType.SelectedItem.ToString();
                                updatedItem.ItemDescription = mtbxDescription.Text;
                                updatedItem.ProductCost = double.Parse(mtbxItemCost.Text);
                                updatedItem.Popular = Convert.ToInt32(mswPopular.Switched);

                                SqliteDataAccess.UpdateItem(updatedItem, item.ProductName);

                                MessageBox.Show("The item has been updated in the database.");
                                updated = true;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            LoadItemsInListBoxes();
                            ResetControls();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to select an item before you can update one.");
            }
        }

        private void mbtnAddItem_Click(object sender, EventArgs e)
        {
            if (AllFieldsEntered())
            {
                bool added = false;
                var confirmation = MessageBox.Show("Are you sure you want to add this item.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmation == DialogResult.Yes)
                {
                    foreach (var item in allItems)
                    {

                        ItemModel newItem = new ItemModel();

                        try
                        {
                            if (!added)
                            {
                                newItem.ProductName = mtbxItemName.Text;
                                newItem.ProductType = cbxItemType.SelectedItem.ToString();
                                newItem.ItemDescription = mtbxDescription.Text;
                                newItem.ProductCost = double.Parse(mtbxItemCost.Text);
                                newItem.Popular = Convert.ToInt32(mswPopular.Switched);
                                SqliteDataAccess.AddNewItem(newItem);
                                MessageBox.Show("The item has been added the database.");
                                added = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }


                        LoadItemsInListBoxes();
                        ResetControls();
                    }
                }
            }
            else
            {
                MessageBox.Show("You need to create an item before it can be added.");
            }
        }

        private void ResetControls()
        {
            cbxItemType.SelectedItem = null;
            mtbxDescription.Text = "";
            mtbxItemCost.Text = "";
            mtbxItemName.Text = "";
            mswPopular.Switched = false;
        }

        private bool AllFieldsEntered()
        {
            if (mtbxItemName.Text == "" || mtbxItemName.Text == " ")
            {
                MessageBox.Show("Your item needs a name.");
                return false;
            }
            if (mtbxDescription.Text == "" || mtbxDescription.Text == " ")
            {
                MessageBox.Show("Your item needs a description.");
                return false;
            }
            if (mtbxItemCost.Text == "" || mtbxItemCost.Text == " ")
            {
                MessageBox.Show("Your item needs a price.");
                return false;

            }
            if (cbxItemType.SelectedItem == null)
            {
                MessageBox.Show("Your item needs a prouduct type.");
                return false;

            }
            return true;
        }
    }
}
