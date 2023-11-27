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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

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
    }
}
