using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class CafeManager : Form
    {
        public CafeManager()
        {
            InitializeComponent();

        }
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cm = new SqlCommand();

        
        private void button1_Click(object sender, EventArgs e)
        {
            AddItemPanel.Hide();
            ViewProductPanel.Show();

            conn.Open();
            string viewProducts = "select * from Product";
            cm = new SqlCommand(viewProducts, conn);
            SqlDataReader reader = cm.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            productViewGrid.DataSource = table;
            conn.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            AddItemPanel.Show();
            ViewProductPanel.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            conn.Open();
            string prodName = productName.Text, prodPrice = productPrice.Text, prodCategory = productCategory.Text;
            string insertQuery = "insert into Product values (@name, @price, @category, null)"; // we will add vendor id to null, (joins or nested)
            string check = "select * from Product where ProductName = @name";
            cm = new SqlCommand(check, conn);
            cm.Parameters.AddWithValue("@name", prodName);
            cm.Parameters.AddWithValue("@price", prodPrice);
            cm.Parameters.AddWithValue("@category", prodCategory);
            SqlDataReader dr = cm.ExecuteReader();

            if (!dr.HasRows)
            {
                dr.Close();
                cm = new SqlCommand(insertQuery, conn);
                cm.Parameters.AddWithValue("@name", prodName);
                cm.Parameters.AddWithValue("@price", prodPrice);
                cm.Parameters.AddWithValue("@category", prodCategory);

                int rows = cm.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Product added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productName.Clear();
                    productPrice.Clear();
                }
                else
                {
                    MessageBox.Show("Product couldn't be added. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    productName.Clear();
                    productPrice.Clear();
                }
            }
            else
            {
                MessageBox.Show("Product already exists.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                productName.Clear();
                productPrice.Clear();
                dr.Close();
            }

            conn.Close();

        }

        private void AddItemPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
