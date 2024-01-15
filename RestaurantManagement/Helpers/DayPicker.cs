using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagement.Helpers
{
    public class DayPicker
    {
        public DateTime CreateCombinedDate(ComboBox comboBoxRok, ComboBox comboBoxMiesiac, ComboBox comboBoxDzien,DateTimePicker DateTimePickerGodzina)
        {
            int rok = int.Parse(comboBoxRok.Text);
            int miesiac = DateTime.ParseExact(comboBoxMiesiac.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int dzien = int.Parse(comboBoxDzien.Text);

            DateTime combinedDate = new DateTime(rok, miesiac, dzien, DateTimePickerGodzina.Value.Hour, DateTimePickerGodzina.Value.Minute, 0);

            return combinedDate;
        }
        public DateTime CreateCombinedDateNoTime(ComboBox comboBoxRok, ComboBox comboBoxMiesiac, ComboBox comboBoxDzien)
        {
            int rok = int.Parse(comboBoxRok.Text);
            int miesiac = DateTime.ParseExact(comboBoxMiesiac.Text, "MMMM", CultureInfo.CurrentCulture).Month;
            int dzien = int.Parse(comboBoxDzien.Text);

            DateTime combinedDate = new DateTime(rok, miesiac, dzien);

            return combinedDate;
        }
        public void UpdateDaysComboBox(ComboBox comboBoxRok, ComboBox comboBoxMiesiac, ComboBox comboBoxDzien)
        {
            int selectedYear = (int)comboBoxRok.SelectedItem;

            string selectedMonthName = comboBoxMiesiac.SelectedItem.ToString();

            int selectedMonth = DateTime.ParseExact(selectedMonthName, "MMMM", CultureInfo.CurrentCulture).Month;

            int currentDay = 1;
            if (selectedMonth == DateTime.Now.Month && selectedYear == DateTime.Now.Year)
            {
                currentDay = DateTime.Now.Day;
            }
            int daysInMonth = DateTime.DaysInMonth(selectedYear, selectedMonth);

            comboBoxDzien.Items.Clear();
            for (int day = currentDay; day <= daysInMonth; day++)
            {
                comboBoxDzien.Items.Add(day);
            }
        }
        public void UpdateMonthsComboBox(ComboBox comboBoxRok, ComboBox comboBoxMiesiac, ComboBox comboBoxDzien)
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
    }
}
