using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement
{
    public partial class Profil : Form
    {
        private void UpdateDaysComboBox()
        {
            // Pobierz wybrane rok i miesiąc
            int selectedYear = (int)comboBoxRok.SelectedItem;
            int selectedMonth = comboBoxMiesiac.SelectedIndex + 1;

            // Oblicz liczbę dni w danym miesiącu
            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

            // Wyczyść i dodaj dni do trzeciego ComboBox
            comboBoxDzien.Items.Clear();
            for (int day = 1; day <= daysInMonth; day++)
            {
                comboBoxDzien.Items.Add(day);
            }
        }
        private void UpdateMonthsComboBox()
        {
            int selectedYear = (int)comboBoxRok.SelectedItem;
            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            if (selectedYear == currentYear)
            {
                for (int monthToAdd = currentMonth; monthToAdd <= 12; monthToAdd++)
                {
                    comboBoxMiesiac.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthToAdd));
                }
            }
            else
            {
                for (int month = 1; month <= 12; month++)
                {
                    comboBoxMiesiac.Items.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(month));
                }
            }
        }
        public Profil()
        {
            InitializeComponent();

            comboBoxRok.Items.Add(DateTime.Now.Year);
            comboBoxRok.Items.Add(DateTime.Now.Year + 1);
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

        private void Profil_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxMiesiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRok.SelectedItem == null)
            {
                MessageBox.Show("Nalezy najpierw wybrac rok");
                comboBoxMiesiac.SelectedItem = null;
                return;
            }
            UpdateDaysComboBox();
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMonthsComboBox();
        }
    }
}
