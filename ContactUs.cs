using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CafeManagement
{
    public partial class ContactUs : Form
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void Usman_insta_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/usmannnnnnn_/");
        }

        private void Mujtaba_insta_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/itzz._._.m/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            this.Hide();
            form.Show();
        }

        private void muji_email_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcSDbFhNKffqTrjNGDkFBBlFjvlXJjGCWTHgHBQZFWjsFKpXGbkvRWxNsxVgxZSQsRGMNWZMN");
        }

        private void Usman_email_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mail.google.com/mail/u/0/#inbox?compose=GTvVlcSDZPKpMmXRxpvWkdWCdNRBVvzdBjxBmQZhJbKmGQKJptNmmnnGVhdfRkhsvgBPLLRwNKMpn");

        }

        private void HomeLabel_Click(object sender, EventArgs e)
        {
            Customer form = new Customer();
            this.Hide();
            form.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            this.Hide();
            form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AboutUs form = new AboutUs();
            this.Hide();
            form.Show();
        }
    }
}
