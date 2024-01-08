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
        DayPicker daypicker = new DayPicker();

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
            daypicker.UpdateDaysComboBox(comboBoxRok,comboBoxMiesiac,comboBoxDzien);
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCzasPracy.Hide();
            daypicker.UpdateMonthsComboBox(comboBoxRok, comboBoxMiesiac, comboBoxDzien);
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
