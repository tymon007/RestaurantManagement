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

namespace RestaurantManagement
{
    public partial class ManageUser : Form
    {
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
            //query do zmiany roli pracownika       
        }

        private void buttonZmienStatus_Click(object sender, EventArgs e)
        {
            ValidateRow();
            //query do zmiany statusu usera przypisanego do pracownika, jak nie ma 
        }

        private void buttonUsunDane_Click(object sender, EventArgs e)
        {
            ValidateRow();
            //query do usuniecia danych nullable w bazie danych w tabeli rm_pracownik   
        }

        private void ManageUser_Load_1(object sender, EventArgs e)
        {
            foreach (var role in Enum.GetValues(typeof(User.Role)))
            {
                comboBoxRole.Items.Add(role.ToString()); 
            }

        }
    }
}
