using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CafeManagement
{
    public static class DBConnecction
    {
         public static SqlConnection OpenConnection()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=USMAN\SQLEXPRESS;Initial Catalog=CafeManagement;Integrated Security=True");
            return conn;
        }
        public static void CloseConnection(SqlConnection conn)
        {
            conn.Close();
        }
    }
}
