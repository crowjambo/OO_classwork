using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace Task5RestoHelper
{
    public static class SqliteDataAccess
    {
        public static List<Dish> LoadDishes()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                //returns IEnumerable
                 var output = cnn.Query<Dish>("select * from Dishes", new DynamicParameters());
                //return list instead
                return output.ToList();
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            //go into app.config and return connection string with name of id, +only string part of that
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

    }
}
