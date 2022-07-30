using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class SqliteDataAccess
    {
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<PersonModel>("SELECT * FROM Cashiers", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ItemModel> LoadAllItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ItemModel> LoadPopularItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE Popular = 1", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ItemModel> LoadFoodItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE ProductType = 'Food'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<ItemModel> LoadDrinksItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE ProductType LIKE '%Drink%'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void ListSale(SaleModel sale)
        {

        }
       

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
