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
using RestaurantManagement.Service;
using RestaurantManagement.Models;

namespace RestaurantManagement
{
    public partial class ManageOrder : Form
    {
        private readonly DatabaseHandler databaseHandler;

        ZarzadzanieZamowieniami zarzadzanieZamowieniami = new ZarzadzanieZamowieniami();
        List<ZarzadzanieZamowieniami> listaZamowien = new List<ZarzadzanieZamowieniami>();

        private Button selectedButtonMiejsceWynos;
        private Button selectedButtonZrealizowanoNieZrealizowano;
        public ManageOrder()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler();
            buttonGotowe.Visible = false;
            buttonUsun.Visible = false;
            
            labelSkunks.Hide();
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
            selectedButtonMiejsceWynos.BackColor = Color.Silver;
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
            selectedButtonMiejsceWynos.BackColor = Color.Silver;
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
            selectedButtonZrealizowanoNieZrealizowano.BackColor = Color.Silver;
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
            selectedButtonZrealizowanoNieZrealizowano.BackColor = Color.Silver;
            buttonZrealizowano.BackColor = Color.White;
        }

        private void buttonFiltruj_Click(object sender, EventArgs e)
        {
            labelSkunks.Hide();
           


            if (selectedButtonZrealizowanoNieZrealizowano == buttonNieZrealizowano)
            {
                buttonGotowe.Show();
                buttonUsun.Show();
            }
            else
            {
                buttonGotowe.Hide();
                buttonUsun.Show();
            }
            if(selectedButtonMiejsceWynos is null && selectedButtonZrealizowanoNieZrealizowano is null)
            {
                labelSkunks.Show();
            }

            int forma = 0;
            int realizacja = 0;

            if (selectedButtonMiejsceWynos == null)
            {
                forma = 0;
            }
            else if (selectedButtonMiejsceWynos == buttonNaMiejscu)
            {
                forma = 1;
            }
            else if (selectedButtonMiejsceWynos == buttonNaWynos)
            {
                forma = 2;
            }


            if (selectedButtonZrealizowanoNieZrealizowano == null)
            {
                realizacja = 0;
            }
            else if (selectedButtonZrealizowanoNieZrealizowano == buttonNieZrealizowano)
            {
                realizacja = 1;
            }
            else if (selectedButtonZrealizowanoNieZrealizowano == buttonZrealizowano)
            {
                realizacja = 2;
            }


            List<ZarzadzanieZamowieniami> zamowienia = databaseHandler.GetZamowienia(realizacja, forma);
            zamowienia.Reverse(); //od najwiekszych ID sortowane zeby najnowsze zamowineia byly na gorze

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("IDZamowienia", "ID Zamówienia");
            dataGridView1.Columns.Add("DataZlozenia", "Data Złożenia");
            dataGridView1.Columns.Add("GodzinaZlozenia", "Godzina Złożenia");
            dataGridView1.Columns.Add("Status_zamowienia", "Status Zamówienia");
            dataGridView1.Columns.Add("Cena", "Cena");
            dataGridView1.Columns.Add("Adres", "Adres");
            dataGridView1.Columns.Add("GodzinaRealizacji", "Godzina Realizacji");

            DataGridViewButtonColumn btnPozycje = new DataGridViewButtonColumn();
            btnPozycje.Name = "Pozycje";
            btnPozycje.HeaderText = "Pozycje";
            btnPozycje.Text = "Pokaż";
            btnPozycje.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnPozycje);

            foreach (var zamowienie in zamowienia)
            {
                int rowIndex = dataGridView1.Rows.Add();
                Adres adres = new Adres();
                List<ZamowienieElement> pozycje = new List<ZamowienieElement>();
                pozycje = databaseHandler.GetZamowienieElements(zamowienie.IDZamowienia);
                if (zamowienie.Adres.HasValue)
                {
                    adres = databaseHandler.GetAddressById(zamowienie.Adres.Value);
                    zamowienie.AdresString = adres.adres;
                }
                else
                {
                    zamowienie.AdresString = string.Empty;
                }
                zamowienie.PozycjeZamowienia = pozycje;

                String listaPozycji = "";
                foreach (var pozycja in pozycje)
                {
                    listaPozycji += pozycja + " ";
                }

                dataGridView1.Rows[rowIndex].Cells["IDZamowienia"].Value = zamowienie.IDZamowienia;
                dataGridView1.Rows[rowIndex].Cells["DataZlozenia"].Value = zamowienie.DataZlozenia.ToShortDateString();
                dataGridView1.Rows[rowIndex].Cells["GodzinaZlozenia"].Value = zamowienie.GodzinaZlozenia.ToString(@"hh\:mm");
                dataGridView1.Rows[rowIndex].Cells["Status_zamowienia"].Value = zamowienie.Status_zamowienia;
                dataGridView1.Rows[rowIndex].Cells["Cena"].Value = zamowienie.Cena + " zł";
                dataGridView1.Rows[rowIndex].Cells["Adres"].Value = zamowienie.AdresString;
                dataGridView1.Rows[rowIndex].Cells["GodzinaRealizacji"].Value = zamowienie.GodzinaRealizacji.HasValue
                    ? zamowienie.GodzinaRealizacji.Value.ToString(@"hh\:mm"): string.Empty;
                dataGridView1.Rows[rowIndex].Cells["Pozycje"].Value = listaPozycji;
            }

        }

        private void buttonGotowe_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridView1.SelectedRows[0].Cells["IDZamowienia"].Value;
                databaseHandler.ZrealizujZamowienie(orderId);
                buttonFiltruj_Click(sender, e);
                //dataGridView1.SelectedRows[0].Cells["Status_zamowienia"].Value = "Zrealizowane";
                //dataGridView1.SelectedRows[0].Cells["GodzinaRealizacji"].Value = DateTime.Now.ToString(@"hh\:mm");
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz, który chcesz zrealizować.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridView1.SelectedRows[0].Cells["IDZamowienia"].Value;
                databaseHandler.UsunZamowienie(orderId);

                buttonFiltruj_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć wiersz, który chcesz usunąć.", "Brak zaznaczenia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Pozycje" && e.RowIndex >= 0)
            {
                int idZamowienia = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDZamowienia"].Value);

                var pozycje = databaseHandler.GetZamowienieElements(idZamowienia);

                StringBuilder sb = new StringBuilder();
                foreach (var pozycja in pozycje)
                {
                    sb.AppendLine($"{pozycja.produkt_nazwa} | {pozycja.produkt_ilosc} | {pozycja.produkt_cena} zł");
                }
                MessageBox.Show(sb.ToString(), "Pozycje zamówienia", MessageBoxButtons.OK);
            }
        }
    }
}
