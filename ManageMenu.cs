using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class ManageMenu : Form
    {
        public ManageMenu()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cm = null;

        private void button5_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Convert.ToInt32(productIDTxt.Text);
            string insertQuery = "INSERT INTO Menu (ItemPrice,ItemName,Category,ProductID) SELECT UnitPrice, ProductName, Category,ProductID FROM Product WHERE ProductID = @id;";
            string checkIfExistsQuery = "select * from Menu where ProductID = @id";
            cm = new SqlCommand(checkIfExistsQuery, conn);
            cm.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cm.ExecuteReader();

            if(dr.HasRows)
            {
                MessageBox.Show("Item already added to menu", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
            }
            else
            {
                dr.Close();
                cm = new SqlCommand(insertQuery, conn);
                cm.Parameters.AddWithValue("@id", id);
                int rows = cm.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Item added to menu", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            
            conn.Close();


        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            viewItemsGrid.Show();
            AddToMenuPanel.Show();

            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.AddBtn.ForeColor = System.Drawing.Color.Snow;

            this.RemoveBtn.BackColor = System.Drawing.Color.Snow; 
            this.RemoveBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);


            conn.Open();
            string viewProducts = "select * from Product";
            cm = new SqlCommand(viewProducts, conn);
            SqlDataReader reader = cm.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            viewItemsGrid.DataSource = table;
            reader.Close();
            conn.Close();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            AddToMenuPanel.Hide();
            viewItemsGrid.Show();
            RemoveFromMenuPanel.Show();

            this.AddBtn.BackColor = System.Drawing.Color.Snow;
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.RemoveBtn.ForeColor = System.Drawing.Color.Snow;

            conn.Open();
            string viewProducts = "select * from Menu";
            cm = new SqlCommand(viewProducts, conn);
            SqlDataReader reader = cm.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            viewItemsGrid.DataSource = table;
            reader.Close();
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            int id = Convert.ToInt32(removeTxt.Text);
            string insertQuery = "Delete from Menu where ProductID = @id";
            string checkIfExistsQuery = "select * from Menu where ProductID = @id";
            cm = new SqlCommand(checkIfExistsQuery, conn);
            cm.Parameters.AddWithValue("@id", id);
            SqlDataReader dr = cm.ExecuteReader();

            if (!dr.HasRows)
            {
                MessageBox.Show("Invalid ID. Product does not exist in Menu.", "Failure");
                dr.Close();
            }
            else
            {
                dr.Close();
                cm = new SqlCommand(insertQuery, conn);
                cm.Parameters.AddWithValue("@id", id);
                int rows = cm.ExecuteNonQuery();
                if (rows > 0)
                {
                    MessageBox.Show("Item removed from menu", "Success",MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }

            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CafeManager cm = new CafeManager();
            cm.Show();
        }
    }
}
