using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using System.Windows.Forms;
using MetroSet_UI.Forms;
using System.ComponentModel;

namespace Belgium_Campus_Tuckshop
{
    public class SalesOutput
    {
        //Method for getting selected item

        
        public static string GetSelectedItem(string ItemName, int NumericValue)
        {
            string Output = "";
            double cumulativeItemPrice = 0;
            
            List<ItemModel> ListAllItems = SqliteDataAccess.LoadAllItems();

            foreach (ItemModel Item in ListAllItems)
            {
                if (ItemName == Item.ProductName)
                {
                    string Layout = "{0}@{1} each, quantity {2} = R{3}";
                   cumulativeItemPrice = Item.ProductCost * NumericValue;
                   SumTotal.TotalSum = SumTotal.TotalSum + cumulativeItemPrice;

                    Output = String.Format(Layout,Item.ProductName,Item.ProductCost,Convert.ToString(NumericValue),cumulativeItemPrice);
                   
                    break;
                }
            }

            return Output;

        }



        public static class SumTotal
        {
            public static double TotalSum;
        }
    }
}
