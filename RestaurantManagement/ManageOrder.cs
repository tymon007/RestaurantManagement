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
            buttonWyslano.Visible = false;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Form Main = new Main();
            this.Hide();
            Main.Show();
        }

        private void ManageOrder_Load(object sender, EventArgs e)
        {
            List<ZarzadzanieZamowieniami> zamowienia = databaseHandler.GetZamowienia();


            
            dataGridView1.Columns.Clear();

            
            dataGridView1.Columns.Add("IDZamowienia", "ID Zamówienia");
            dataGridView1.Columns.Add("DataZlozenia", "Data Złożenia");
            dataGridView1.Columns.Add("GodzinaZlozenia", "Godzina Złożenia");
            dataGridView1.Columns.Add("Status_zamowienia", "Status Zamówienia");
            dataGridView1.Columns.Add("Cena", "Cena");
            dataGridView1.Columns.Add("Adres", "Adres");
            dataGridView1.Columns.Add("GodzinaRealizacji", "Godzina Realizacji");
            dataGridView1.Columns.Add("Pozycje", "Pozycje");


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
                    zamowienie.AdresString = ""; 
                }
                zamowienie.PozycjeZamowienia = pozycje;

                String listaPozycji = "";
                foreach (var pozycja in pozycje)
                {
                    listaPozycji += pozycja + " ";
                }

                dataGridView1.Rows[rowIndex].Cells["IDZamowienia"].Value = zamowienie.IDZamowienia;
                dataGridView1.Rows[rowIndex].Cells["DataZlozenia"].Value = zamowienie.DataZlozenia.ToShortDateString();
                dataGridView1.Rows[rowIndex].Cells["GodzinaZlozenia"].Value = zamowienie.GodzinaZlozenia;
                dataGridView1.Rows[rowIndex].Cells["Status_zamowienia"].Value = zamowienie.Status_zamowienia;
                dataGridView1.Rows[rowIndex].Cells["Cena"].Value = zamowienie.Cena;
                dataGridView1.Rows[rowIndex].Cells["Adres"].Value = zamowienie.AdresString;
                dataGridView1.Rows[rowIndex].Cells["GodzinaRealizacji"].Value = zamowienie.GodzinaRealizacji;
                dataGridView1.Rows[rowIndex].Cells["pozycje"].Value = listaPozycji;//zamowienie.PozycjeZamowienia.ToString();
            }

            //dataGridView1.DataSource = databaseHandler.GetDishesData();

            //foreach (DataRow row in dataGridView1.Rows)
            //{
            //    // Map data from the database to existing columns in the DataGridView
            //    int dishID = Convert.ToInt32(row["DishID"]);
            //    dataGridView1.Rows.Add(
            //        dishID,
            //        row["DishName"].ToString(),
            //        row["DishDescription"].ToString(),
            //        Convert.ToDecimal(row["DishPrice"]),
            //        GetCategoryName(Convert.ToInt32(row["CategoryID"])), // Map to existing column "Category"
            //        GetChefName(Convert.ToInt32(row["ChefID"]))          // Map to existing column "Chef"
            //    );

            //    // Optionally modify values
            //    if (row["DishName"].ToString().Contains("Special"))
            //    {
            //        // Modify the value in the "Description" column for dishes with "Special" in the name
            //        dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Description"].Value = "Special Dish!";
            //    }
            //}

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
            //pobranie warunkow do query z selectedButtons
            //wyslanie query do bazy i zbindowanie danych do datagridview. Nie mozna wrzucac po indexach tylko trzeba zbindowac jak uczciwy polak
            //zeby przy sortowaniu sie nic zlego nie dzialo

            if (selectedButtonZrealizowanoNieZrealizowano == buttonNieZrealizowano)
            {
                //funkcja pobierajaca dane z bazy do dgv 
                buttonGotowe.Show();
                buttonUsun.Show();
                buttonWyslano.Show();
            }
            else
            {
                buttonGotowe.Hide();
                buttonUsun.Hide();
                buttonWyslano.Hide();
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
