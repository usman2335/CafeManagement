using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeManagement
{
    public partial class PastOrders : Form
    {
        public PastOrders()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cmd = new SqlCommand();
       

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string viewQuery = "select * from CustomerOrderView where CustomerID = @ID";
            int id = 1;
            cmd = new SqlCommand(viewQuery, conn);
            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            PastOrdersGrid.DataSource = dt;
            dr.Close();
            conn.Close();
        }
    }
}
