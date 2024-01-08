using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static RestaurantManagement.Models.Zamowienia;

namespace RestaurantManagement
{
    public partial class ManageOrder : Form
    {
        ZarzadzanieZamowieniami zarzadzanieZamowieniami = new ZarzadzanieZamowieniami();
        List<ZarzadzanieZamowieniami> listaZamowien = new List<ZarzadzanieZamowieniami>();

        private Button selectedButtonMiejsceWynos;
        private Button selectedButtonZrealizowanoNieZrealizowano;
        public ManageOrder()
        {
            InitializeComponent();
            buttonGotowe.Visible = false;
            buttonUsun.Visible = false;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form Main = new Main();
            this.Hide();
            Main.Show();
        }

        private void ManageOrder_Load(object sender, EventArgs e)
        {

        }

        private void buttonNaMiejscu_Click(object sender, EventArgs e)
        {
            if (selectedButtonMiejsceWynos == buttonNaMiejscu)
            {
                selectedButtonMiejsceWynos.BackColor = Color.White;
                selectedButtonMiejsceWynos = null;
                return;
            }
            selectedButtonMiejsceWynos = buttonNaMiejscu;
            selectedButtonMiejsceWynos.BackColor = Color.LightGreen;
            buttonNaWynos.BackColor = Color.White;

        }

        private void buttonNaWynos_Click(object sender, EventArgs e)
        {
            if (selectedButtonMiejsceWynos == buttonNaWynos)
            {
                selectedButtonMiejsceWynos.BackColor = Color.White;
                selectedButtonMiejsceWynos = null;
                return;
            }
            selectedButtonMiejsceWynos = buttonNaWynos;
            selectedButtonMiejsceWynos.BackColor = Color.LightGreen;
            buttonNaMiejscu.BackColor = Color.White;
        }

        private void buttonZrealizowano_Click(object sender, EventArgs e)
        {
            if (selectedButtonZrealizowanoNieZrealizowano == buttonZrealizowano)
            {
                selectedButtonZrealizowanoNieZrealizowano.BackColor = Color.White;
                selectedButtonZrealizowanoNieZrealizowano = null;
                return;
            }
            selectedButtonZrealizowanoNieZrealizowano = buttonZrealizowano;
            selectedButtonZrealizowanoNieZrealizowano.BackColor = Color.LightGreen;
            buttonNieZrealizowano.BackColor = Color.White;
        }

        private void buttonNieZrealizowano_Click(object sender, EventArgs e)
        {
            if (selectedButtonZrealizowanoNieZrealizowano == buttonNieZrealizowano)
            {
                selectedButtonZrealizowanoNieZrealizowano.BackColor = Color.White;
                selectedButtonZrealizowanoNieZrealizowano = null;
                return;
            }
            selectedButtonZrealizowanoNieZrealizowano = buttonNieZrealizowano;
            selectedButtonZrealizowanoNieZrealizowano.BackColor = Color.LightGreen;
            buttonZrealizowano.BackColor = Color.White;
        }

        private void buttonFiltruj_Click(object sender, EventArgs e)
        {
            //pobranie warunkow do query z selectedButtons
            //wyslanie query do bazy i zbindowanie danych do datagridview. Nie mozna wrzucac po indexach tylko trzeba zbindowac jak uczciwy polak
            //zeby przy sortowaniu sie nic zlego nie dzialo

            if (selectedButtonZrealizowanoNieZrealizowano == buttonNieZrealizowano)
            {
                //funkcja pobierajaca dane z bazy do dgv 
                buttonGotowe.Show();
                buttonUsun.Show();
            }
            else
            {
                buttonGotowe.Hide();
                buttonUsun.Hide();
            }

        }

        private void buttonGotowe_Click(object sender, EventArgs e)
        {
            if (listaZamowien.Count == 0)
            {
                MessageBox.Show("Brak zamowien do oznaczenia jako gotowe");
                return;
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (listaZamowien.Count == 0)
            {
                MessageBox.Show("Brak zamowien do usuniecia");
                return;
            }
        }
    }
}
