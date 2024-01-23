using System.Windows.Forms;
using RestaurantManagement.Helpers;
using RestaurantManagement.Service;

namespace RestaurantManagement
{
    public partial class FormLogin : Form
    {
        Helper helper = new Helper();
        public FormLogin()
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
            string username = textBox1.Text;
            string password = textBox2.Text;

            DatabaseHandler dbHandler = new DatabaseHandler();

            if (dbHandler.ValidateLogin(username, password))
            {

                this.Hide();
                Form Main = new Main();
                Main.Show();
            }
            else
            {
                MessageBox.Show("Niepoprawny login lub hasło.");
            }

            //pobrac z bazy dane usera i pracownika takie jak w Modelu Klasy User i Pracownik i utworzyc obiekt Pracownik (globalna zmienna)
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