﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;
using Task5RestoHelper;
using Task5RestoHelper.Models;
using System.Data.SqlClient;

namespace Task5RestoHelper
{
    public class SqliteDataAccess : IOrderSave
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


        public void Save(OrderInfo info)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                //var output = cnn.Execute("insert into Orders (date, details, totalVat, totalNoVat) values (@Date1, @Details1, @TotalVat, @TotalNoVat", info);
                int rowsAffected = cnn.Execute("INSERT INTO Orders (date, totalVat, totalNoVat) values (@Date1, @TotalVat, @TotalNoVat)", info);

            }

        }
    }
}
