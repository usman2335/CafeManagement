using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }
       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            ContactUs contactUs = new ContactUs();
            this.Hide();
            contactUs.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void MenuLabel_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }
        public string _textBox
        {
            set { label2.Text = value; }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            ContactUs form = new ContactUs(); 
            this.Hide();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs();
            this.Hide(); 
            form.Show();
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs();
            this.Hide();
            form.Show();
        }

        private void viewPastBtn_Click(object sender, EventArgs e)
        {
            PastOrders po = new PastOrders();
            this.Hide();
            po.Show();
        }
    }
}
