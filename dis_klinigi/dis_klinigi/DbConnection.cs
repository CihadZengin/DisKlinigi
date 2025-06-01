using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace dis_klinigi
{
    internal class DbConnection
    {
        public static SqlConnection GetConnection()
        {
            string executionPath = AppDomain.CurrentDomain.BaseDirectory;
            string dbFilePath = Path.Combine(executionPath, "Veritabani.mdf");
            string connectionString = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={dbFilePath};Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}
