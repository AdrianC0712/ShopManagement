using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.BFF.DataBase
{
    internal class DataBaseConnection
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=ADRIANPC;Initial Catalog=ShopManagement;Integrated Security=True;");

        public void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Connecting)
            { 
                sqlConnection.Close();
            }
        }
        public SqlConnection GetConnection()
        { 
            return sqlConnection;
        }
    }
}
