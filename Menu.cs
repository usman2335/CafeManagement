using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static CafeManagement.Login;

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
            MenuGrid.DataSource = table;

            NameList.Items.Clear();
            int count = MenuGrid.RowCount;

            for (int i = 0; i < count - 1; i++)
            {
                NameList.Items.Add(MenuGrid.Rows[i].Cells[0].Value.ToString());
            }



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
            MenuGrid.DataSource = table;

            int count = MenuGrid.RowCount;

            NameList.Items.Clear();

            for(int i =0;i<count-1;i++)
            {
                NameList.Items.Add(MenuGrid.Rows[i].Cells[0].Value.ToString());
            }
            

            reader.Close();
            conn.Close();
        }

        private void AddC_button_Click(object sender, EventArgs e)
        {
            conn.Open();
            string menuItem = NameList.SelectedItem.ToString();

            string priceQuery = "select ItemPrice from menu where ProductID = (select ProductID from Product where ProductName = @name)";
            cm = new SqlCommand(priceQuery, conn);
            cm.Parameters.AddWithValue("@name", menuItem);
            int price = Convert.ToInt32(cm.ExecuteScalar());

            if(QtyNum.Value > 0)
            {
                
                CartGrid.Rows[CartGrid.Rows.Count - 1].Cells[0].Value = menuItem;
                CartGrid.Rows[CartGrid.Rows.Count - 1].Cells[1].Value = price;
                CartGrid.Rows[CartGrid.Rows.Count - 1].Cells[2].Value = QtyNum.Value;
                CartGrid.Rows.Add();

            }



            conn.Close();
        
    }

        private void QtyNum_ValueChanged(object sender, EventArgs e)
        {
            conn.Open();

            string menuItem = NameList.SelectedItem.ToString();
            string priceQuery = "select ItemPrice from menu where ProductID = (select ProductID from Product where ProductName = @name)";
            cm = new SqlCommand(priceQuery, conn);
            cm.Parameters.AddWithValue("@name", menuItem);

            int price = Convert.ToInt32(cm.ExecuteScalar());

            int total = Convert.ToInt32(QtyNum.Value) * price;

            PriceTxt.Text = total.ToString();

            conn.Close();
        }

        private void MenuGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BG_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriceTxt.Clear();
            QtyNum.Value = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ViewBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            int custID = SharedData.PassedVariable;
            DateTime today = DateTime.Now;
            string placeOrderQuery = "insert into Orders values (@total,@date,@id)";
            cm = new SqlCommand(placeOrderQuery, conn);
            cm.Parameters.AddWithValue("@total", totalTxt.Text);
            cm.Parameters.AddWithValue("@date", today);
            cm.Parameters.AddWithValue("@id", custID);

            int rows = cm.ExecuteNonQuery();
            if(rows > 0)
            {
                MessageBox.Show("Order Placed!");
            }


            


        }
    }
}
