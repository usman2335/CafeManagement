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
            String roleQuery = "Select top 1 userID from Users order by userID desc";
            String userInsert = "Insert into Users(userID,username,password,role) values (@userID,@roleUsername,@rolePassword,@roleRole)";
            conn.Open();
            cm = new SqlCommand(roleQuery, conn);

            int userid = Convert.ToInt32(cm.ExecuteScalar());
            userid++;

            conn.Close();
            DateTime date = DateTime.Today;
            if (password != reEnter)
            {
                MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                passwordTxt.Clear();
                reEnterPassword.Clear();
            }
            else
            {
               
                if (type == "Cashier")
                {
                    conn.Open();
                    String queryUser = "Select * from Cashier Where username = @user";
                    cm = new SqlCommand(queryUser, conn);
                    cm.Parameters.AddWithValue("@user", username);
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Username already exists. Please try again.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        passwordTxt.Clear();
                        reEnterPassword.Clear();
                    }
                    else
                    {
                        dr.Close();
                        String query = "SELECT TOP 1 CashierID FROM Cashier ORDER BY CashierID DESC";
                        cm = new SqlCommand(query, conn);
                        int id = Convert.ToInt32(cm.ExecuteScalar());
                        Console.Write(id);
                        id++;
                        


                        String queryInsert = "Insert into Cashier(CashierID,FName,LName,PhoneNo,CManagerID,username,password,HireDate) values (@cashID,@fname,@lname,@phone,null,@user,@pass,@date)";
                        
                        cm = new SqlCommand(queryInsert, conn);
                        cm.Parameters.AddWithValue("@cashID", id);
                        cm.Parameters.AddWithValue("@fname", fName);
                        cm.Parameters.AddWithValue("@lname", lName);
                        cm.Parameters.AddWithValue("@phone", phone);
                        cm.Parameters.AddWithValue("@user", username);
                        cm.Parameters.AddWithValue("@pass", password);
                        cm.Parameters.AddWithValue("@date", date);


                        int rowsAffected = cm.ExecuteNonQuery();

                      
                        cm = new SqlCommand(userInsert, conn);
                        cm.Parameters.AddWithValue("@userID", userid);
                        cm.Parameters.AddWithValue("@roleUsername", username);
                        cm.Parameters.AddWithValue("@rolePassword", password);
                        cm.Parameters.AddWithValue("@roleRole", type);
                        rowsAffected = cm.ExecuteNonQuery();

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
                        dr.Close();
                        conn.Close();
                    }
                }
                else if (type == "Customer")
                {
                    conn.Open();

                    String queryUser = "Select * from Customer Where username = @user";
                    cm = new SqlCommand(queryUser, conn);
                    cm.Parameters.AddWithValue("@user", username);
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
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


                        String queryInsert = "Insert into Customer(CustomerID,FName,LName,username,password,LoyaltyPoints,RegisterationDate,OrderID) values (@custId,@fname,@lname,@user,@pass,null,@date,null)";
                        cm = new SqlCommand(queryInsert, conn);
                        cm.Parameters.AddWithValue("@custId", id);
                        cm.Parameters.AddWithValue("@fname", fName);
                        cm.Parameters.AddWithValue("@lname", lName);
                        cm.Parameters.AddWithValue("@user", username);
                        cm.Parameters.AddWithValue("@pass", password);
                        cm.Parameters.AddWithValue("@date", date);


                        int rowsAffected = cm.ExecuteNonQuery();


                        cm = new SqlCommand(userInsert, conn);
                        cm.Parameters.AddWithValue("@userID", userid);
                        cm.Parameters.AddWithValue("@roleUsername", username);
                        cm.Parameters.AddWithValue("@rolePassword", password);
                        cm.Parameters.AddWithValue("@roleRole", type);
                        rowsAffected = cm.ExecuteNonQuery();

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
                        dr.Close();
                        conn.Close();

                    }

                }
                else if (type == "Inventory Manager")
                {
                    conn.Open();

                    String queryUser = "Select * from InventoryManager Where username = @user";
                    cm = new SqlCommand(queryUser, conn);
                    cm.Parameters.AddWithValue("@user", username);
                    SqlDataReader dr = cm.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Username already exists. Please try again.", "Failure", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        passwordTxt.Clear();
                        reEnterPassword.Clear();
                    }
                    else
                    {
                        dr.Close();
                        String query = "SELECT TOP 1 InvManagerID FROM InventoryManager ORDER BY InvManagerID DESC";
                        cm = new SqlCommand(query, conn);
                        int id = Convert.ToInt32(cm.ExecuteScalar());
                        Console.Write(id);
                        id++;


                        String queryInsert = "Insert into InventoryManager(InvManagerID,FName,LName,PhoneNo,HireDate,CManagerID,InventoryID,username,password) values (@InvMgrID,@fname,@lname,@phone,@date,null,null,@user,@pass)";
                        cm = new SqlCommand(queryInsert, conn);
                        cm.Parameters.AddWithValue("@InvMgrID", id);
                        cm.Parameters.AddWithValue("@fname", fName);
                        cm.Parameters.AddWithValue("@lname", lName);
                        cm.Parameters.AddWithValue("@user", username);
                        cm.Parameters.AddWithValue("@pass", password);
                        cm.Parameters.AddWithValue("@date", date);
                        cm.Parameters.AddWithValue("@phone", phone);


                        int rowsAffected = cm.ExecuteNonQuery();


                        cm = new SqlCommand(userInsert, conn);
                        cm.Parameters.AddWithValue("@userID", userid);
                        cm.Parameters.AddWithValue("@roleUsername", username);
                        cm.Parameters.AddWithValue("@rolePassword", password);
                        cm.Parameters.AddWithValue("@roleRole", type);
                        rowsAffected = cm.ExecuteNonQuery();

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
                        dr.Close();
                        conn.Close();
                    }

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
    }
}
