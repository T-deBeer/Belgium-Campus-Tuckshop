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


        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
