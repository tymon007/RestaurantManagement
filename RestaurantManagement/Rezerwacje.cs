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

    public partial class Rezerwacje : Form
    {
        private Button selectedButton;
        Helper helper = new Helper();
        DayPicker daypicker = new DayPicker();
        public Rezerwacje()
        {

            InitializeComponent();

            selectedButton = buttonDzis;
            selectedButton.BackColor = Color.Silver;

            //Wyslanie query do bazy z Rezerwacjami na dzis (od aktualnej godziny w przod) i umieszczenie w gridview
            //wyslanie query do bazy ze stolikami i wpisanie stolikow do comboboxStolik

            comboBoxStolik.Items.AddRange(new object[] //tymczasowo
            {
                "2A",
                "2B",
                "2C",
                "2D",
                "2E",
                "2F",
                "3A",
                "3B",
                "4A",
                "4B",
                "4C",
                "4D"
            });
            dateTimePickerOd.ShowUpDown = true;
            dateTimePickerOd.Format = DateTimePickerFormat.Custom;
            dateTimePickerOd.CustomFormat = "HH:mm";
            dateTimePickerDo.ShowUpDown = true;
            dateTimePickerDo.Format = DateTimePickerFormat.Custom;
            dateTimePickerDo.CustomFormat = "HH:mm";
            helper.SetTimePickers(dateTimePickerOd, dateTimePickerDo, 1);
            panelCzas.Hide();

            comboBoxRok.Items.Add(DateTime.Now.Year);
            comboBoxNRRok.Items.Add(DateTime.Now.Year);

            comboBoxRok.Items.Add(DateTime.Now.Year + 1);
            comboBoxNRRok.Items.Add(DateTime.Now.Year + 1);

            panelWyborDaty.Enabled = false;
        }

        private void comboBoxMiesiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            daypicker.UpdateDaysComboBox(comboBoxRok, comboBoxMiesiac, comboBoxDzien);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelCzas.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            Hide();
            main.Show();
        }

        private void comboBoxNRRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            daypicker.UpdateMonthsComboBox(comboBoxNRRok, comboBoxNRMiesiac, comboBoxNRDzien);
        }

        private void comboBoxNRMiesiac_SelectedIndexChanged(object sender, EventArgs e)
        {
            daypicker.UpdateDaysComboBox(comboBoxNRRok, comboBoxNRMiesiac, comboBoxNRDzien);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            if (comboBoxStolik.SelectedItem == null)
            {
                MessageBox.Show("W celu dokonania rezerwacji nalezy wybrac stolik");
                return;
            }
            if ((dateTimePickerDo.Value - dateTimePickerOd.Value).TotalMinutes < 30)
            {
                MessageBox.Show("Minimalny czas rezerwacji to 30 minut. Proszę ponownie wprowadzić czas");
                helper.SetTimePickers(dateTimePickerOd, dateTimePickerDo, 1);
                return;
            }

            DateTime dataOd = daypicker.CreateCombinedDate(comboBoxNRRok, comboBoxNRMiesiac, comboBoxNRDzien, dateTimePickerOd);
            DateTime dataDo = daypicker.CreateCombinedDate(comboBoxNRRok, comboBoxNRMiesiac, comboBoxNRDzien, dateTimePickerDo);

            if (dataOd.Date == DateTime.Today)
            {
                if (dataOd.TimeOfDay <= DateTime.Now.TimeOfDay)
                {
                    MessageBox.Show("Nie można dokonywać rezerwacji wstecz.");
                    return;
                }
            }

            string stolik = comboBoxStolik.SelectedItem.ToString();

            //Wyslac zapytanie do bazy czy jest wolny ten stolik w wybranym terminie, dane ponizej tymczasowe, po utworzeniu rezerwacji baza musi zwrocic idRezerwacji
            bool wolne = true;
            int idRezerwacji = 123456789;

            if (wolne)
            {
                MessageBox.Show($"Pomyślnie dokonano rezerwacji. \n\nSzczegóły rezerwacji:\n      ID Rezerwacji: {idRezerwacji}\n      Stolik: {stolik}\n" +
                    $"      Data: {dataOd.ToString("dd:MM:yyyy")}\n      Czas: {dataOd.ToString("HH:mm")} do {dataDo.ToString("HH:mm")}");
            }
            else if (!wolne)
            {
                MessageBox.Show("Wybrany stolik jest już zarezerwowany w tym terminie. Proszę wybrać inny termin lub zmienić stolik");
                return;
            }

        }

        private void buttonDzis_Click(object sender, EventArgs e)
        {
            if (selectedButton == buttonDzis)
            {
                return;
            }
            //Wyslanie query do bazy z Rezerwacjami na dzis (od aktualnej godziny w przod) i odswiezenie gridview

            selectedButton = buttonDzis;
            selectedButton.BackColor = Color.Silver;
            buttonWyborDate.BackColor = Color.White;
            comboBoxRok.Items.Clear();
            comboBoxMiesiac.Items.Clear();
            comboBoxDzien.Items.Clear();

            panelWyborDaty.Enabled = false;
        }

        private void buttonWyborDate_Click(object sender, EventArgs e)
        {
            if (selectedButton == buttonWyborDate)
            {
                return;
            }
            selectedButton = buttonWyborDate;
            selectedButton.BackColor = Color.Silver;
            buttonDzis.BackColor = Color.White;
            panelWyborDaty.Enabled = true;
            if(comboBoxRok.Items.Count>0)
            {
                return;
            }
            comboBoxRok.Items.Add(DateTime.Now.Year);
            comboBoxRok.Items.Add(DateTime.Now.Year+1);
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            daypicker.UpdateMonthsComboBox(comboBoxRok, comboBoxMiesiac, comboBoxDzien);
        }

        private void comboBoxDzien_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime dateForQuery = daypicker.CreateCombinedDateNoTime(comboBoxRok, comboBoxMiesiac, comboBoxDzien);
            MessageBox.Show(dateForQuery.ToString("dd.MM.yyyy"));
        }

    }
}
