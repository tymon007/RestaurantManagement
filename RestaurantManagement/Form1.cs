using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Main = new Main();
            Main.Show();
        }
    }
}