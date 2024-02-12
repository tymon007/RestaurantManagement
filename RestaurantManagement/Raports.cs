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
    public partial class Raports : Form
    {
        private void AddYearsToComboBox(ComboBox comboBox)
        {
            int aktualnyRok = (int)DateTime.Now.Year;
            comboBox.Items.Add(aktualnyRok);
            comboBox.Items.Add((aktualnyRok - 1));
        }

        DayPicker picker = new DayPicker();
        public Raports()
        {
            InitializeComponent();
        }

        private void Raports_Load(object sender, EventArgs e)
        {
            AddYearsToComboBox(comboBoxRok);
        }

        private void comboBoxRok_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMiesiac.SelectedItem = null;
            comboBoxMiesiac.Items.Clear();

            if (comboBoxRok.SelectedItem != null)
            {
                int wybranyRok = Convert.ToInt32(comboBoxRok.SelectedItem);
                int aktualnyRok = DateTime.Now.Year;
                int aktualnyMiesiac = DateTime.Now.Month;

                var cultureInfo = new CultureInfo("pl-PL");
                for (int miesiac = 1; miesiac <= 12; miesiac++)
                {
                    if (wybranyRok < aktualnyRok || (wybranyRok == aktualnyRok && miesiac <= aktualnyMiesiac))
                    {
                        string nazwaMiesiaca = cultureInfo.DateTimeFormat.GetMonthName(miesiac);
                        comboBoxMiesiac.Items.Add(nazwaMiesiaca);
                    }
                }

                if (wybranyRok == aktualnyRok)
                {
                    comboBoxMiesiac.SelectedIndex = aktualnyMiesiac - 1;
                }
            }
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Main mainform = new Main();
            Hide();
            mainform.Show();
        }
    }
}
