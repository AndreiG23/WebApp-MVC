using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Dapper;

namespace WebApp_MVC.DataAccessLayer
{
    public static class SqlDataAccess
    {
        public static string GetConnectionString(string connectionString = "MVCDatabaseEntities")
        {
            //return ConfigurationManager.ConnectionStrings[connectionString].ConnectionString;
            return "Data Source=DESKTOP-1P3VN9V\\SQLEXPRESS;Initial Catalog=MVCDatabase;Integrated Security=True;Application Name=EntityFramework";
        }

        public static List<T> LoadData<T>(string sql)
        {
            using(IDbConnection cnn = new SqlConnection(GetConnectionString())) 
            { 
                return cnn.Query<T>(sql).ToList();
            }
        }
    }
}