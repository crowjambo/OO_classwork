using System;
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

        // singular look up where Id matches
        public static Dish LoadDish(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            { 
                return cnn.Query<Dish>("Select * From Dishes WHERE Id = @Id", new { id }).SingleOrDefault();
            }
        }

        //update
        public static void UpdateDishDb(Dish dish)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                string sqlQuery = "UPDATE Dishes SET DishName = @DishName, DishDescription = @DishDescription, Picture = @Picture, Price = @Price, Category = @Category WHERE Id = @Id";
                cnn.Execute(sqlQuery, dish);
    
            }
        }

        //create new
        public static void CreateNewDish(Dish dish)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Dishes (DishName, DishDescription, Picture, Price, Category) values (@DishName, @DishDescription, @Picture, @Price, @Category )", dish);

            }
        }

        //remove dish from DB
        public static void RemoveDish(int id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var sqlStatement = "DELETE FROM Dishes WHERE Id = @Id";
                cnn.Execute(sqlStatement, new { Id = id });

            }
        }


        public void Save(OrderInfo info)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {

                //var output = cnn.Execute("insert into Orders (date, details, totalVat, totalNoVat) values (@Date1, @Details1, @TotalVat, @TotalNoVat", info);
                int rowsAffected = cnn.Execute("INSERT INTO Orders (date, totalVat, totalNoVat) values (@Date1, @TotalVat, @TotalNoVat)", info);

            }

        }

        //login check (send nickname/password )
        public static User LoginUser(string nickname, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<User>("select * from Users WHERE nickname = @nickname AND password = @password", new { nickname, password }).SingleOrDefault();
                return output;
            }
        }

        public static int RegisterUser(string nickname, string password)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                try
                {
                    int rowsAffected = cnn.Execute("INSERT INTO Users (nickname, password, discountType, accessLevel) values (@nickname, @password, 0, 1)", new { nickname, password });
                    return rowsAffected;
                }
                catch(Exception ex)
                {
                    return 0;
                }
    
            }
        }
    }
}
