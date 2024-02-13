using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantManagement.Models;
using static RestaurantManagement.Models.User;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using RestaurantManagement.Service;

namespace RestaurantManagement
{
    public partial class ManageUser : Form
    {
        private int LoggedInPracownikID;
        User LoggedInUser = FormLogin.loggedInUser;
        DatabaseHandler dbHandler = new DatabaseHandler();
        public void ValidateRow()
        {
            if (dataGridViewPracownicy.CurrentCell == null || dataGridViewPracownicy.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Prosze zaznaczyc pracownika");
                return;
            }

            int selectedRow = dataGridViewPracownicy.CurrentCell.RowIndex;
            for (int column = 0; column < 2; column++)
            {
                var value = dataGridViewPracownicy[column, selectedRow].Value;

                if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    MessageBox.Show($"Dane pracownika w wierszu {selectedRow + 1} są niepoprawne");
                    return;
                }
            }
        }
        public ManageUser()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Main mainform = new Main();
            Hide();
            mainform.Show();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonZmienRole_Click(object sender, EventArgs e)
        {
            ValidateRow();
            if(comboBoxRole.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano roli");
                return;
            }

            ////////////////////Obsluga ID
            int idPracownika = Convert.ToInt32(dataGridViewPracownicy.CurrentRow.Cells["ID"].Value);
            if (idPracownika == LoggedInPracownikID)
            {
                MessageBox.Show("Nie mozna zmienic własnej roli, skontaktuj się z innym administratorem");
                return;
            }
            ///////////////////////////////
            
            ///////////////////Obsluga Roli
            string wybranaRola = comboBoxRole.SelectedItem.ToString();
            if (comboBoxRole.SelectedItem.ToString() == "Administrator")
            {
                wybranaRola = "Admin";
            }

            string aktualnaRolaPracownika = dataGridViewPracownicy.CurrentRow.Cells["Rola"].Value.ToString();
            if (wybranaRola == aktualnaRolaPracownika)
            {
                MessageBox.Show("Pracownik ma już przypisaną te rolę");
                return;
            }
            ///////////////////////////////
            
            ///////////////////////////////Zmiana roli pracownika
            try
            {
                dbHandler.ZmienRolePracownika(idPracownika, wybranaRola);
                MessageBox.Show("Rola pracownika została zaktualizowana");
                DGVRefresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd: {ex.Message}");
            }
        }

        private void buttonZmienStatus_Click(object sender, EventArgs e)
        {
            ValidateRow();

            int idPracownika = Convert.ToInt32(dataGridViewPracownicy.CurrentRow.Cells["ID"].Value);
            if (idPracownika == LoggedInPracownikID)
            {
                MessageBox.Show("Nie mozna zmienic własnego statusu, skontaktuj się z innym administratorem");
                return;
            }

            string aktualnyStatus = dataGridViewPracownicy.CurrentRow.Cells["Status"].Value.ToString();

            int nowyStatus;
            if (aktualnyStatus == "Aktywny")
            {
                nowyStatus = 0; 
            }
            else
            {
                nowyStatus = 1; 
            }

            try
            {
                dbHandler.ZmienStatusPracownika(idPracownika, nowyStatus);
                MessageBox.Show("Status pracownika został zaktualizowany.");

                DGVRefresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Wystąpił błąd przy zmianie statusu: {ex.Message}");
            }
        }

        private void buttonUsunDane_Click(object sender, EventArgs e)
        {
            ValidateRow();
            int idPracownika = Convert.ToInt32(dataGridViewPracownicy.CurrentRow.Cells["ID"].Value);
            if (idPracownika == LoggedInPracownikID)
            {
                MessageBox.Show("Nie można usunąć danych własnego konta, skontaktuj się z innym administratorem");
                return;
            }

            var result = MessageBox.Show("Czy na pewno chcesz usunąć dane tego pracownika?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    dbHandler.UsunDanePracownika(idPracownika);
                    MessageBox.Show("Dane pracownika zostały usunięte.");

                    DGVRefresh();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wystąpił błąd przy usuwaniu danych: {ex.Message}");
                }
            }

        }

        private void ManageUser_Load_1(object sender, EventArgs e)
        {
            foreach (var role in Enum.GetValues(typeof(User.Role)))
            {
                comboBoxRole.Items.Add(role.ToString());
            }
            DGVRefresh();

        }

        private void DGVRefresh()
        {
            List<Pracownik> employees = dbHandler.GetAllEmployees();
            var employeeDisplayList = employees.Select(emp => new
            {
                ID = emp.Id,
                Status = emp.Uzytkownik.Status == 0 ? "Nieaktywny" : "Aktywny",
                Imię = emp.Imie,
                Nazwisko = emp.Nazwisko,
                Rola = emp.Uzytkownik.Rola,
                Płeć = emp.Plec,
                Wiek = emp.Wiek,
                DataRozpoczeciaPracy = emp.DataRozpoczeciaPracy?.ToShortDateString() ?? string.Empty
            }).ToList();
            foreach(var employee in employees)
            {
                if(employee.Uzytkownik.UserID == LoggedInUser.UserID)
                {
                    LoggedInPracownikID = employee.Id;
                }
            }

            dataGridViewPracownicy.DataSource = employeeDisplayList;

            dataGridViewPracownicy.Columns["DataRozpoczeciaPracy"].HeaderText = "Data Rozpoczęcia Pracy";
            dataGridViewPracownicy.Columns["ID"].HeaderText = "ID Pracownika";
        }
    }
}
