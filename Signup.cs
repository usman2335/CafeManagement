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
        // DBConnecction.OpenConnection();
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cm = new SqlCommand();
        private void welcomeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Fname_TextChanged(object sender, MouseEventArgs e)
        {
            this.phoneTxt.Text = "";
        }
        private void Fname_Click(object sender, MouseEventArgs e)
        {
            this.Fname.Text = "";
        }

        private void LName_TextChanged(object sender, MouseEventArgs e)
        {
            this.LName.Text = "";
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            string fName = Fname.Text, lName = LName.Text, username = usernameTxt.Text, password = passwordTxt.Text, phone = phoneTxt.Text;
            string reEnter = reEnterPassword.Text;
            string type = comboBox1.Text;
            if (password != reEnter)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                passwordTxt.Clear();
                reEnterPassword.Clear();
            }
            else
            {

                String roleQuery = "Select top 1 userID from Users order by userID desc";
                String userInsert = "Insert into Users(username,password,role) values (@roleUsername,@rolePassword,@roleRole)";
                conn.Open();


                cm = new SqlCommand(roleQuery, conn);
                int userid = Convert.ToInt32(cm.ExecuteScalar());
                userid++;

                String queryUser = "Select * from Users Where username = @user";
                cm = new SqlCommand(queryUser, conn);
                cm.Parameters.AddWithValue("@user", username);
                SqlDataReader dr = cm.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("Username already exists. Please try again.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    passwordTxt.Clear();
                    reEnterPassword.Clear();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    cm = new SqlCommand(userInsert, conn);
                    cm.Parameters.AddWithValue("@userID", userid);
                    cm.Parameters.AddWithValue("@roleUsername", username);
                    cm.Parameters.AddWithValue("@rolePassword", password);
                    cm.Parameters.AddWithValue("@roleRole", type);
                    int rowsAffected = cm.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Congratulations, your account has been successfully created.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Registration failed. Please try again.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }

                DateTime date = DateTime.Today;

                if (type == "Cashier")
                {
                    conn.Open();



                    String queryInsert = "Insert into Cashier(FName,LName,PhoneNo,CManagerID,username,password,HireDate,userID) values (@fname,@lname,@phone,null,@user,@pass,@date,@userID)";

                    cm = new SqlCommand(queryInsert, conn);
                    cm.Parameters.AddWithValue("@fname", fName);
                    cm.Parameters.AddWithValue("@lname", lName);
                    cm.Parameters.AddWithValue("@phone", phone);
                    cm.Parameters.AddWithValue("@user", username);
                    cm.Parameters.AddWithValue("@pass", password);
                    cm.Parameters.AddWithValue("@date", date);
                    cm.Parameters.AddWithValue("@userID", userid);
                    cm.ExecuteNonQuery();
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                    dr.Close();
                    conn.Close();
                }

                else if (type == "Customer")
                {
                    conn.Open();
                    dr.Close();


                    String queryInsert = "Insert into Customer(FName,LName,username,password,LoyaltyPoints,RegisterationDate,OrderID,userID) values (@fname,@lname,@user,@pass,null,@date,null,@userID)";
                    cm = new SqlCommand(queryInsert, conn);
                    cm.Parameters.AddWithValue("@fname", fName);
                    cm.Parameters.AddWithValue("@lname", lName);
                    cm.Parameters.AddWithValue("@user", username);
                    cm.Parameters.AddWithValue("@pass", password);
                    cm.Parameters.AddWithValue("@date", date);
                    cm.Parameters.AddWithValue("@userID", userid);

                    int rowsAffected = cm.ExecuteNonQuery();

                    Login login = new Login();
                    this.Hide();
                    login.Show();
                    dr.Close();
                    conn.Close();

                }
                else if (type == "Inventory Manager")
                {
                    conn.Open();


                    dr.Close();
                    String queryInsert = "Insert into InventoryManager(FName,LName,PhoneNo,HireDate,CManagerID,InventoryID,username,password,userID) values (@fname,@lname,@phone,@date,null,null,@user,@pass,@userID)";
                    cm = new SqlCommand(queryInsert, conn);
                    cm.Parameters.AddWithValue("@fname", fName);
                    cm.Parameters.AddWithValue("@lname", lName);
                    cm.Parameters.AddWithValue("@user", username);
                    cm.Parameters.AddWithValue("@pass", password);
                    cm.Parameters.AddWithValue("@date", date);
                    cm.Parameters.AddWithValue("@phone", phone);
                    cm.Parameters.AddWithValue("@userID", userid);
                    int rowsAffected = cm.ExecuteNonQuery();

                    Login login = new Login();
                    this.Hide();
                    login.Show();
                    dr.Close();
                    conn.Close();


                }
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

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

        private void usernameTxt_click(object sender, MouseEventArgs e)
        {
            this.usernameTxt.Text = "";
        }

        private void passwordTxt_click(object sender, MouseEventArgs e)
        {
            this.passwordTxt.Text = "";
        }

        private void rePasswordTxt_click(object sender, MouseEventArgs e)
        {
            this.reEnterPassword.Text = "";
        }

        private void welcomeText1_Click(object sender, EventArgs e)
        {

        }

        private void reEnterPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginCBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
