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
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DCKBU0Q\SQLEXPRESS;Initial Catalog=Final;Integrated Security=True");
            return conn;
        }
    }
}