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
using System.Xml.Linq;

namespace CafeManagement
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            BG_panel.Hide();
        }
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cm = new SqlCommand();

        string viewMenu = "select * from Menu";

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            this.Hide();
            form.Show();
        }

        // sorry for this one accidently clicked on the image 
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            ContactUs form = new ContactUs();
            this.Hide();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new AboutUs();
            this.Hide();
            aboutUs.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BG_panel.Show();
            this.button1.BackColor = System.Drawing.Color.FromArgb(100, 10, 50);
            this.button1.ForeColor = System.Drawing.Color.Snow;

            conn.Open();
            string showMenu = "select * from MenuItemView";

           
            cm = new SqlCommand(showMenu, conn);
            SqlDataReader reader = cm.ExecuteReader();

            DataTable table = new DataTable();

            table.Load(reader);
            dataGridView1.DataSource = table;

            

            reader.Close();
            conn.Close();

        }

        private void Cat_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            string type = comboBox1.Text;
            String q1 = "Select * from MenuItemView where Category = @Cat";

            cm = new SqlCommand(q1, conn);

            cm.Parameters.AddWithValue("@Cat", type);

            SqlDataReader reader = cm.ExecuteReader();
            DataTable table = new DataTable(); 
            table.Load(reader);
            dataGridView1.DataSource = table;

            reader.Close();
            conn.Close();
        }

        private void AddC_button_Click(object sender, EventArgs e)
        {

        }

        private void AddToTextBox(int changeBy)
        {
            int value;
            if (int.TryParse(Qtty_Box.Text, out value))
            {
                value = value + changeBy;
                Qtty_Box.Text = value.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Integer in TextBox!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            AddToTextBox(1);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            string input = Qtty_Box.Text;
            if (int.TryParse(input, out int quantity))
            {
                if(quantity > 0)
                    AddToTextBox(-1);
            }
        }
    }
}
