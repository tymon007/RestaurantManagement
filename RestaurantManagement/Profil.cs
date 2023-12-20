using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Profil : Form
    {
        public Profil()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form Main = new Main();
            this.Close();
            this.Hide();
            Main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
