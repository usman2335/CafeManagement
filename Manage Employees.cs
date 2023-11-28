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
    public partial class Manage_Employees : Form
    {
        public Manage_Employees()
        {
            InitializeComponent();
        }
        SqlConnection conn = DBConnecction.OpenConnection();
        SqlCommand cm = new SqlCommand();

        private void label3_Click(object sender, EventArgs e)
        {
            CafeManager cafeManager = new CafeManager();
            this.Hide();
            cafeManager.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            CafeManager cafeManager = new CafeManager();
            this.Hide();
            cafeManager.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //            CREATE VIEW EmployeeView AS
            //SELECT
            //    u.userID,
            //	u.role,
            //    COALESCE(c.FName, i.FName) AS FName,
            //    COALESCE(c.LName, i.FName) AS LName,
            //    COALESCE(c.PhoneNo, i.PhoneNo) AS PhoneNo,
            //    COALESCE(c.hireDate, i.hireDate) AS HireDate
            //FROM
            //    Users u
            //LEFT JOIN
            //    Cashier c ON u.userID = c.userID
            //LEFT JOIN
            //    InventoryManager i ON u.userID = i.userID
            //WHERE
            //    u.role IN('Cashier', 'Inventory Manager');



            //select* from EmployeeView

            ViewEmpPanel.Show();
            EditEmpPanel.Hide();  // subquery
            DeleteEmpPanel.Hide();

            this.button1.BackColor = System.Drawing.Color.FromArgb(100, 10, 50); // view employees
            this.button1.ForeColor = System.Drawing.Color.Snow;

            this.button3.BackColor = System.Drawing.Color.Snow; // edit employees
            this.button3.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.button4.BackColor = System.Drawing.Color.Snow; // delete employees
            this.button4.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);


            conn.Open();
            string viewEmpQuery = "select * from EmployeeView";
            cm = new SqlCommand(viewEmpQuery, conn);
            SqlDataReader reader = cm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);

            viewEmpGrid.DataSource = dt;
            reader.Close();
            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewEmpPanel.Hide();
            EditEmpPanel.Show();  // subquery
            DeleteEmpPanel.Hide();

            this.button1.BackColor = System.Drawing.Color.Snow; // view employees
            this.button1.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.button3.BackColor = System.Drawing.Color.FromArgb(100, 10, 50); //edit employees
            this.button3.ForeColor = System.Drawing.Color.Snow;

            this.button4.BackColor = System.Drawing.Color.Snow; // view employees
            this.button4.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewEmpPanel.Hide();
            EditEmpPanel.Hide();
            DeleteEmpPanel.Show();   // subquery

            this.button1.BackColor = System.Drawing.Color.Snow; // view employees
            this.button1.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.button3.BackColor = System.Drawing.Color.Snow; // edit employees
            this.button3.ForeColor = System.Drawing.Color.FromArgb(100, 10, 50);

            this.button4.BackColor = System.Drawing.Color.FromArgb(100, 10, 50); //delete employees
            this.button4.ForeColor = System.Drawing.Color.Snow;




        }
    }
}
