using System.Windows.Forms;
using RestaurantManagement.Helpers;
namespace RestaurantManagement
{
    public partial class Form1 : Form
    {
        Helper helper = new Helper();
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

        private void textBox1_Click(object sender, EventArgs e)
        {
            helper.OpenOnScreenKeyboard();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            helper.OpenOnScreenKeyboard();
        }
    }
}