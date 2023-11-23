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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=USMAN\SQLEXPRESS;Initial Catalog=CafeManagement;Integrated Security=True");
        SqlCommand cm = new SqlCommand();
        private void welcomeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void LName_TextChanged(object sender, EventArgs e)
        {

        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            string fName = Fname.Text, lName = LName.Text, username = usernameTxt.Text, password = passwordTxt.Text;
            string reEnter = reEnterPassword.Text;
            if(password!= reEnter)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                passwordTxt.Clear();
                reEnterPassword.Clear();
            }
            else
            {
                conn.Open();
                
                String queryUser = "Select * from Customer Where username = @user";
                cm = new SqlCommand(queryUser, conn);
                cm.Parameters.AddWithValue("@user", username);
                SqlDataReader dr = cm.ExecuteReader();
                if(dr.HasRows)
                {
                    MessageBox.Show("Username already exists. Please try again.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    passwordTxt.Clear();
                    reEnterPassword.Clear();
                }
                else
                {
                    dr.Close();
                    String query = "SELECT TOP 1 customerId FROM Customer ORDER BY customerId DESC";
                    cm = new SqlCommand(query, conn);
                    int id = Convert.ToInt32(cm.ExecuteScalar());
                    Console.Write(id);
                    id++;


                    String queryInsert = "Insert into Customer(customerId,firstName,lastName,username,password) values (@custId,@fname,@lname,@user,@pass)";
                    cm = new SqlCommand(queryInsert, conn);
                    cm.Parameters.AddWithValue("@custId", id);
                    cm.Parameters.AddWithValue("@fname", fName);
                    cm.Parameters.AddWithValue("@lname", lName);
                    cm.Parameters.AddWithValue("@user", username);
                    cm.Parameters.AddWithValue("@pass", password);


                    int rowsAffected = cm.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Congratulations, your account has been successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                dr.Close();
                conn.Close();




            }


        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void signinLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
