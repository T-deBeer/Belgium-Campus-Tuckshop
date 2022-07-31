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

        public static void InsertSale(SaleModel sale)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute("INSERT INTO SalesReport (SaleDate, CustomerName, Receipt) VALUES (@Date, @CustomerName, @Receipt)", sale);
            }
        }

        public static List<SaleModel> LoadSalesByDate(string date)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<SaleModel>($"SELECT * FROM SalesReport WHERE SaleDate LIKE '%{date}%'", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<SaleModel> LoadAllSales()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<SaleModel>($"SELECT * FROM SalesReport", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void AddNewItem(ItemModel item)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute("INSERT INTO Products (ProductName, ProductType, ProductCost, Popular, ItemDescription) VALUES (@Name, @Type, @Price, @Popular @Description)", item);
            }
        }

        public static void UpdateItem(ItemModel item)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute("UPDATE Products SET ProductName = @Name, ProductType = @Type, ProductCost = @Price, Popular = @Popular, ItemDescription = @Description WHERE ProductID = @ID", item);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
