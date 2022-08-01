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

        /// <summary>
        /// Creates a list of objects of the class of PersonModel,
        /// the list is populated by the Cashiers Table in the SQLite Database
        /// </summary>
        /// <returns> List<PersonModel>() </returns>
        public static List<PersonModel> LoadPeople()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<PersonModel>("SELECT * FROM Cashiers", new DynamicParameters());
                return output.ToList();
            }
        }


        /// <summary>
        /// Creates a list of objects of the class of ItemModel,
        /// the list is populated by the Products Table in the SQLite Database
        /// </summary>
        /// <returns> List<ItemModel>() </returns>
        public static List<ItemModel> LoadAllItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Creates a list of object of the class of ItemModel
        /// The list is populated by the Products Tbale in the SQLite Database
        /// It only returns products that have the product type "Cold Drinks"
        /// </summary>
        /// <returns></returns>
        public static List<ItemModel> LoadColdDrinks()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE ProductType = 'Cold Drink' ", new DynamicParameters());
               return output.ToList();
            }

        }

        /// <summary>
        /// Creates a list of object of the class of ItemModel
        /// The list is populated by the Products Tbale in the SQLite Database
        /// It only returns products that have the product type "Hot Drinks"
        /// </summary>
        /// <returns></returns>

   

        public static List<ItemModel> LoadHotDrinks()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE ProductType = 'Hot Drink' ", new DynamicParameters());
                return output.ToList();
            }
        }



        /// <summary>
        /// Creates a list of objects of the class of ItemModel,
        /// the list is populated by the Products Table in the SQLite Database,
        /// it only returns the Products that are considered popular
        /// </summary>
        /// <returns> List<ItemModel>() </returns>
        public static List<ItemModel> LoadPopularItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE Popular = 1", new DynamicParameters());
                return output.ToList();
            }
        }


        /// <summary>
        /// Creates a list of objects of the class of ItemModel,
        /// the list is populated by the Products Table in the SQLite Database,
        /// it only returns the Products that are classed as Food
        /// </summary>
        /// <returns> List<ItemModel>() </returns>
        public static List<ItemModel> LoadFoodItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE ProductType = 'Food'", new DynamicParameters());
                return output.ToList();
            }
        }


        /// <summary>
        /// Creates a list of objects of the class of ItemModel,
        /// the list is populated by the Products Table in the SQLite Database,
        /// it only returns the Products that are classed as Drinks
        /// </summary>
        /// <returns> List<ItemModel>() </returns>
        public static List<ItemModel> LoadDrinksItems()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<ItemModel>("SELECT * FROM Products WHERE ProductType LIKE '%Drink%'", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Writes a Sale of class SaleModel into the
        /// SalesReport table of the Database
        /// </summary>
        public static void InsertSale(SaleModel sale)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute("INSERT INTO SalesReport (SaleDate, CustomerName, Receipt) VALUES (@Date, @CustomerName, @Receipt)", sale);
            }
        }

        /// <summary>
        /// Creates a list of objects of the class of SaleModel,
        /// the list is populated by the SalesReport Table in the SQLite Database
        /// it only returns Sales made on the date that is entered as a parameter.
        /// </summary>
        /// <returns> List<SaleModel>() </returns>
        public static List<SaleModel> LoadSalesByDate(string date)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<SaleModel>($"SELECT * FROM SalesReport WHERE SaleDate LIKE '%{date}%'", new DynamicParameters());
                return output.ToList();
            }
        }


        /// <summary>
        /// Creates a list of objects of the class of SaleModel,
        /// the list is populated by the SalesReport Table in the SQLite Database
        /// </summary>
        /// <returns> List<SaleModel>() </returns>
        public static List<SaleModel> LoadAllSales()
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<SaleModel>($"SELECT * FROM SalesReport", new DynamicParameters());
                return output.ToList();
            }
        }

        public static List<SaleModel> LoadMonthlySales(string datePart)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                var output = database.Query<SaleModel>($"SELECT * FROM SalesReport WHERE SaleDate LIKE '%{datePart}'", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Writes a new Item of class ItemModel into
        /// the Products table of the Database
        /// </summary>
        public static void AddNewItem(ItemModel item)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute("INSERT INTO Products (ProductName, ProductType, ProductCost, Popular, ItemDescription) VALUES (@ProductName, @ProductType, @ProductCost, @Popular @ItemDescription)", item);
            }
        }

        /// <summary>
        /// Updates an exsisting record in the Products table of the database
        /// by using an item from class ItemModel 
        /// </summary>
        public static void UpdateItem(ItemModel item, string name)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute("UPDATE Products SET ProductName = @ProductName, ProductType = @ProductType, ProductCost = @ProductCost, Popular = @Popular, ItemDescription = @ItemDescription WHERE ProductName = @ProductName", item);
            }
        }

        public static void DeleteSale(string date, string name)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute($"DELETE FROM SalesRecord WHERE SaleDate = {date} AND CustomerName = {name}");
            }
        }

        public static void DeleteItem(string name)
        {
            using (IDbConnection database = new SQLiteConnection(LoadConnectionString()))
            {
                database.Execute($"DELETE FROM Products WHERE ProductName = {name}");
            }
        }

        /// <summary>
        /// Used to get the connection string for the database in the App.config file
        /// </summary>
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
