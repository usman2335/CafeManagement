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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=USMAN\SQLEXPRESS;Initial Catalog=CafeManagement;Integrated Security=True");
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
            String query = "Select * from Customer Where username = '" + usernameTxt.Text + "' AND password = '" + passwordTxt.Text + "'";
            cm = new SqlCommand(query, conn);
            SqlDataReader dr = cm.ExecuteReader();
            if(dr.HasRows)
            {
                Customer customer = new Customer();
                this.Close();
                customer.Show();
            }
            else
            {
                MessageBox.Show("Login Failed. Username and password do not match. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordTxt.Clear();
            }

            conn.Close();


            
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
    }
}
