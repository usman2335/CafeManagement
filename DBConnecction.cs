﻿using System;
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
            SqlConnection conn = new SqlConnection(@"Data Source=USMAN\SQLEXPRESS;Initial Catalog=CafeFinal;Integrated Security=True");
            return conn;
        }
    }
}