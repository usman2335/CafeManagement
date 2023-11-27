using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cm = new SqlCommand();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string username = usernameTxt.Text, password = passwordTxt.Text;
            String query = "Select * from Users Where username = '" + usernameTxt.Text + "' AND password = '" + passwordTxt.Text + "'";
            String roleQuery = "Select role from Users Where username = '" + usernameTxt.Text + "' AND password = '" + passwordTxt.Text + "'";
            String customerNameQuery = "Select FName from Customer Where username = '" + usernameTxt.Text + "' AND password = '" + passwordTxt.Text + "'";
            cm = new SqlCommand(roleQuery, conn);
            string role = Convert.ToString(cm.ExecuteScalar());
            cm = new SqlCommand(query, conn);
            SqlDataReader dr = cm.ExecuteReader();
           // cm = new SqlCommand(customerNameQuery, conn);
            //string custName = Convert.ToString(cm.ExecuteScalar());



            if(dr.HasRows)
            {
                if(role == "Customer")
                {

                    Customer customer = new Customer();
                    customer._textBox = "Welcome, "+ _textBox1;
                    this.Close();
                    customer.Show();
                }
                else if(role == "Cashier")
                {
                    Cashier cashier = new Cashier();
                    this.Close();
                    cashier.Show();
                }
                else if(role == "Inventory Manager")
                {
                    InventoryManager invManager = new InventoryManager();
                    this.Close();
                    invManager.Show();
                }

                else if(role == "Admin")
                {
                    CafeManager cafeManager = new CafeManager();
                    this.Hide();
                    cafeManager.Show();
                }
              
            }
            else
            {
                MessageBox.Show("Login Failed. Username and password do not match. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxt.Clear();
            }

            conn.Close();
        }

        public string _textBox1
        {
            get { return usernameTxt.Text; }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginText_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginCBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Signup signup = new Signup();
            signup.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
