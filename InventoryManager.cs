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
    public partial class InventoryManager : Form
    {
        public InventoryManager()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cm = null;

        private void InventoryManager_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewInventoryPanel.Show();
            viewInventoryGrid.Show();
            RemoveItemPanel.Hide();
            AddItemPanel.Hide();

            this.ViewBtn.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.ViewBtn.ForeColor = System.Drawing.Color.Snow;

            this.AddBtn.BackColor = System.Drawing.Color.Snow;
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.EditBtn.BackColor = System.Drawing.Color.Snow;
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.RemoveBtn.BackColor = System.Drawing.Color.Snow;
            this.RemoveBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);


            conn.Open();
            string viewInventory = "select * from Inventory";
            cm = new SqlCommand(viewInventory, conn);
            SqlDataReader reader = cm.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            viewInventoryGrid.DataSource = table;
            reader.Close();
            conn.Close();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string txt = checkInvText.Text;
            string invQuery = "select * from Inventory where ProductID = (select ProductID from Product where ProductName = @name)";  // subquery

            cm = new SqlCommand(invQuery, conn);
            cm.Parameters.AddWithValue("@name", txt);

            SqlDataReader reader = cm.ExecuteReader();
            if(reader.HasRows)
            {

                DataTable table = new DataTable();

                table.Load(reader);
                viewInventoryGrid.DataSource = table;
                reader.Close();
            }
            else
            {
                MessageBox.Show("Item does not exist in Inventory");
            }

            conn.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            conn.Open();
            string getQuery = "select ProductID from Product where ProductName = @name";
            string name = addText.Text;
            int qty = Convert.ToInt32(quantityTxt.Text);

            cm = new SqlCommand(getQuery, conn);
            cm.Parameters.AddWithValue("@name", name);
            int id = Convert.ToInt32(cm.ExecuteScalar());

            string insertQuery = "Insert into Inventory values (@quantity,@id)";
            cm = new SqlCommand(insertQuery, conn);
            cm.Parameters.AddWithValue("@quantity", qty);
            cm.Parameters.AddWithValue("@id", id);

            int rows = cm.ExecuteNonQuery();
            if(rows > 0)
            {
                MessageBox.Show("Item added to inventory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Item already added in inventory", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            int txt = Convert.ToInt32(RemoveTxt.Text);
            string deleteQuery = "Delete from Inventory where InventoryID = @id";
            cm = new SqlCommand(deleteQuery, conn);
            cm.Parameters.AddWithValue("@id", txt);

            int rows = cm.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Item removed from inventory", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Item doesn't exists in inventory", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            ViewInventoryPanel.Hide();
            RemoveItemPanel.Hide();
            AddItemPanel.Show();

            this.ViewBtn.BackColor = System.Drawing.Color.Snow;
            this.ViewBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.AddBtn.ForeColor = System.Drawing.Color.Snow;

            this.EditBtn.BackColor = System.Drawing.Color.Snow;
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.RemoveBtn.BackColor = System.Drawing.Color.Snow;
            this.RemoveBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            ViewInventoryPanel.Hide();
            RemoveItemPanel.Show();
            AddItemPanel.Hide();

            this.ViewBtn.BackColor = System.Drawing.Color.Snow;
            this.ViewBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.AddBtn.BackColor = System.Drawing.Color.Snow;
            this.AddBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.EditBtn.BackColor = System.Drawing.Color.Snow;
            this.EditBtn.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.RemoveBtn.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.RemoveBtn.ForeColor = System.Drawing.Color.Snow;
        }
    }
}
