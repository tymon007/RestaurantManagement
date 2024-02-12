using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagement.Models;

namespace RestaurantManagement
{
    public partial class Main : Form
    {
        User LoggedInUser = FormLogin.loggedInUser;
        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (LoggedInUser.Rola.Equals("Pracownik", StringComparison.OrdinalIgnoreCase))
            {
                buttonRaporty.Enabled = false;
                buttonZarzadzanie.Enabled = false;
                buttonRaporty.Hide();
                buttonZarzadzanie.Hide();
            }
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
            label_time.Text = DateTime.Now.ToString("HH:mm:ss");
            User user = FormLogin.loggedInUser;
            label_welcome.Text = "Witaj " + user.Login + "!";
        }

        private static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            //label_time.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form noweZamowienie = new NoweZamowienie();
            noweZamowienie.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new FormLogin();
            Form1.Show();
        }

        private void label_time_Click(object sender, EventArgs e)
        {

        }

        private void label_welcome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Rezerwacje = new Rezerwacje();
            Hide();
            Rezerwacje.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Profil = new Grafik();
            this.Hide();
            Profil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form ManageOrder = new ManageOrder();
            this.Hide(); ManageOrder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Raports raportform = new Raports();
            this.Hide();
            raportform.Show();
        }
    }
}
