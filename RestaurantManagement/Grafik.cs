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
using RestaurantManagement.Helpers;

namespace RestaurantManagement
{
    public partial class Grafik : Form
    {
        Helper helper = new Helper();

        private void UpdateDaysComboBox()
        {
            // Pobierz wybrane rok
            int selectedYear = (int)comboBoxRok.SelectedItem;

            // Pobierz nazwę wybranego miesiąca
            string selectedMonthName = comboBoxMiesiac.SelectedItem.ToString();

            // Zamień nazwę miesiąca na liczbę
            int selectedMonth = DateTime.ParseExact(selectedMonthName, "MMMM", CultureInfo.CurrentCulture).Month;

            int currentDay = 1;
            if (selectedMonth == DateTime.Now.Month && selectedYear == DateTime.Now.Year)
            {
                currentDay = DateTime.Now.Day;
            }
            // Oblicz liczbę dni w danym miesiącu
            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

            // Wyczyść i dodaj dni do trzeciego ComboBox
            comboBoxDzien.Items.Clear();
            for (int day = currentDay; day <= daysInMonth; day++)
            {
                comboBoxDzien.Items.Add(day);
            }
        }
        private void UpdateMonthsComboBox()
        {
            comboBoxDzien.Items.Clear();
            comboBoxMiesiac.Items.Clear();
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
        public Grafik()
        {
            InitializeComponent();

            dateTimePickerOd.ShowUpDown = true;
            dateTimePickerOd.Format = DateTimePickerFormat.Custom;
            dateTimePickerOd.CustomFormat = "HH:mm";
            dateTimePickerDo.ShowUpDown = true;
            dateTimePickerDo.Format = DateTimePickerFormat.Custom;
            dateTimePickerDo.CustomFormat = "HH:mm";

            helper.SetTimePickers(dateTimePickerOd, dateTimePickerDo);

            panelCzasPracy.Hide();
            comboBoxRok.Items.Add(DateTime.Now.Year);
            comboBoxRok.Items.Add(DateTime.Now.Year + 1);
            comboBoxStatus.Items.AddRange(new string[]
            {
                "Dostepny",
                "Nieobecny",
                "Urlop"
            });
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
            panelCzasPracy.Hide();
            UpdateDaysComboBox();
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCzasPracy.Hide();
            UpdateMonthsComboBox();
        }

        private void comboBoxDzien_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCzasPracy.Show();
        }

        private void comboBoxDzien_Click(object sender, EventArgs e)
        {
            if (comboBoxMiesiac.SelectedItem == null || comboBoxRok.SelectedItem == null)
            {
                MessageBox.Show("Nalezy najpierw wybrac rok oraz miesiac");
                comboBoxDzien.SelectedItem = null;
                return;
            }

            //Przekonwertowanie roku, miesiaca, dnia z comboboxow na format daty obslugiwany przez baze danych
            //Pobranie danych z bazy danych dla wybranej daty:
            //  - status 
            //  - godzina od
            //  - godzina do
            // i wpierdolenie ich do przypisanych im formatek
        }

        private void comboBoxMiesiac_Click(object sender, EventArgs e)
        {
            if (comboBoxRok.SelectedItem == null)
            {
                MessageBox.Show("Nalezy najpierw wybrac rok");
                comboBoxMiesiac.SelectedItem = null;
                return;
            }
        }

        private void textBoxCzasPracyOd_Click(object sender, EventArgs e)
        {
            helper.OpenOnScreenKeyboard();
        }

        private void textBoxCzasPracyDo_Click(object sender, EventArgs e)
        {
            helper.OpenOnScreenKeyboard();
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            if (comboBoxStatus.SelectedItem == null)
            {
                MessageBox.Show("Nalezy wybrac status");
                return;
            }
            if (comboBoxStatus.SelectedItem.ToString() == "Dostepny")
            {
                if (dateTimePickerOd.Value >= dateTimePickerDo.Value)
                {
                    MessageBox.Show("Niepoprawny czas pracy");
                    helper.SetTimePickers(dateTimePickerOd, dateTimePickerDo);
                    return;
                }
                //wyslanie danych do bazy
                MessageBox.Show("Dodano godziny pracy");
                panelCzasPracy.Hide();
                return;
            }
            if (comboBoxStatus.SelectedItem.ToString() == "Urlop" || comboBoxStatus.SelectedItem.ToString() == "Nieobecny")
            {
                //wyslanie danych do bazy danych bez godziny od i do 
                //baza musi dzialac tak ze jak jej nie wyslesz godzin to null i chuj
                MessageBox.Show("Usunięto czas pracy i dodano wpis");
                panelCzasPracy.Hide();
                return;
            }
        }

        private void Profil_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
