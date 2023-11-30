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
            this.button1.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.button1.ForeColor = System.Drawing.Color.Snow;

            this.button3.BackColor = System.Drawing.Color.Snow;                     // view items
            this.button3.ForeColor = System.Drawing.Color.FromArgb(200, 70, 77);

            this.button5.BackColor = System.Drawing.Color.Snow;                     // edit items
            this.button5.ForeColor = System.Drawing.Color.FromArgb(200, 70, 77);

            this.button4.BackColor = System.Drawing.Color.Snow;                    // delete items
            this.button4.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);


            EditItemPanel.Hide();
            AddItemPanel.Hide();
            ViewProductPanel.Show();
            DeletePanel.Hide();



            conn.Open();
            string viewProducts = "select * from Product";
            cm = new SqlCommand(viewProducts, conn);
            SqlDataReader reader = cm.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            productViewGrid.DataSource = table;
            reader.Close();
            conn.Close();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            EditItemPanel.Hide();
            AddItemPanel.Show();
            ViewProductPanel.Hide();
            DeletePanel.Hide();

            this.button1.BackColor = System.Drawing.Color.Snow;                     // view items
            this.button1.ForeColor = System.Drawing.Color.FromArgb(200, 70, 77);    

            this.button3.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);    // add items
            this.button3.ForeColor = System.Drawing.Color.Snow;

            this.button5.BackColor = System.Drawing.Color.Snow;                     // edit items
            this.button5.ForeColor = System.Drawing.Color.FromArgb(200, 70, 77);

            this.button4.BackColor = System.Drawing.Color.Snow;                    // delete items
            this.button4.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);
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
                    MessageBox.Show("Product couldn't be added. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productName.Clear();
                    productPrice.Clear();
                }
            }
            else
            {
                MessageBox.Show("Product already exists.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                productName.Clear();
                productPrice.Clear();
                
            }
            dr.Close();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editViewBtn_Click(object sender, EventArgs e)
        {

            conn.Open();
            string prodName = editTextBox.Text;
            string viewProducts = "select * from Product where ProductName = @name";
            cm = new SqlCommand(viewProducts, conn);
            cm.Parameters.AddWithValue("@name", prodName);
            SqlDataReader reader = cm.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            EditProdGridView.DataSource = table;


            reader.Close();
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddItemPanel.Hide();
            ViewProductPanel.Hide();
            DeletePanel.Hide();
            EditItemPanel.Show();

            this.button1.BackColor = System.Drawing.Color.Snow;                     // view items
            this.button1.ForeColor = System.Drawing.Color.FromArgb(200, 70, 77);

            this.button3.BackColor = System.Drawing.Color.Snow;                     // add items
            this.button3.ForeColor = System.Drawing.Color.FromArgb(200, 70, 77);

            this.button4.BackColor = System.Drawing.Color.Snow;                    // delete items
            this.button4.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.button5.BackColor = System.Drawing.Color.FromArgb(100,10,50);
            this.button5.ForeColor = System.Drawing.Color.Snow;


        }

        private void submitEditBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string prodName = editNameTxt.Text , price = EditPriceTxt.Text;
            string editQuery = "update Product set ProductName = @newname, UnitPrice = @newprice where ProductName = @oldname";
            cm = new SqlCommand(editQuery, conn);
            cm.Parameters.AddWithValue("@newname", prodName);
            cm.Parameters.AddWithValue("@newprice", price);
            cm.Parameters.AddWithValue("@oldname",editTextBox.Text);
            int rows = cm.ExecuteNonQuery();
            if (rows > 0)
            {
                MessageBox.Show("Product edited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                editNameTxt.Clear();
                EditPriceTxt.Clear();
            }
            else
            {
                MessageBox.Show("Product couldn't be edited. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                editNameTxt.Clear();
                EditPriceTxt.Clear();
            }

            editTextBox.Clear();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddItemPanel.Hide();
            ViewProductPanel.Hide();
            EditItemPanel.Hide();
            DeletePanel.Show();

            this.button1.BackColor = System.Drawing.Color.Snow;                    // view items
            this.button1.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.button3.BackColor = System.Drawing.Color.Snow;                   // add items
            this.button3.ForeColor = System.Drawing.Color.FromArgb(200, 70, 77);

            this.button5.BackColor = System.Drawing.Color.Snow;  
            this.button5.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);  // edit items

            this.button4.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.button4.ForeColor = System.Drawing.Color.Snow;

        }

        private void Viewitems_Click(object sender, EventArgs e)
        {

        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string prodName = deleteTxtBox.Text;
            string deleteCheckQuery = "select * from Product where ProductName = @name";
            cm = new SqlCommand(deleteCheckQuery, conn);
            cm.Parameters.AddWithValue("@name", prodName);
            SqlDataReader dr = cm.ExecuteReader();
            if(!dr.HasRows)
            {
                MessageBox.Show("Product does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dr.Close();
            }
            else
            {
                dr.Close();
                string deleteQuery = "delete from Product where ProductName = @name";
                cm = new SqlCommand(deleteQuery, conn);
                cm.Parameters.AddWithValue("@name", prodName);
                int rows = cm.ExecuteNonQuery();
                if(rows > 0)
                {
                    MessageBox.Show("Product Deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deleteTxtBox.Clear();
                }
                else
                {
                    MessageBox.Show("Product couldn't be deleted. Please try again.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    deleteTxtBox.Clear();
                }
            }
            dr.Close();
            conn.Close();

        }
    }
}
