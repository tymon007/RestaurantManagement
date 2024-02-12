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
using RestaurantManagement.Models;
using RestaurantManagement.Service;

namespace RestaurantManagement
{
    public partial class Raports : Form
    {
        DatabaseHandler dbHandler = new DatabaseHandler();
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

        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            Main mainform = new Main();
            Hide();
            mainform.Show();
        }

        private void buttonOdswiezDane_Click(object sender, EventArgs e)
        {
            List<Raporty.GodzinyPracownikow> godzinyPracownikow = dbHandler.PobierzRaportGodzinPracownikow();
            var dataSource = godzinyPracownikow.Select(g => new {
                Imię = g.imie,
                Nazwisko = g.nazwisko,
                Rola = g.rola,
                Dostępny = g.godzinyDostepny,
                Urlop = g.godzinyUrlop,
                Niedostępny = g.godzinyNiedostepny
            }).ToList();
            dataGridViewGodzinyPracownikow.DataSource = dataSource;


            List<Raporty.NajpopularniejszeDania> najpopularniejszeDania = dbHandler.PobierzRankingNajpopularniejszychDan();
            var dataSourceDania = najpopularniejszeDania.Select(g => new
            {
                Nazwa = g.nazwaDania,
                Sprzedano = g.iloscSztuk,
                Udział = g.udzialProcentowy + " %"
            }).ToList();
            dataGridViewPopularnoscDan.DataSource = dataSourceDania;

            
            List<Raporty.PrzychodMiesieczny> przychodMiesieczny = dbHandler.PobierzPrzychodMiesieczny();
            var dataSourcePrzychod = przychodMiesieczny.Select(g => new {
                Miesiąc = g.miesiac,
                Przychód = $"{g.przychod:C}" 
            }).ToList();
            dataGridViewRocznyPrzychod.DataSource = dataSourcePrzychod;


            List<Raporty.PodzialPrzychodu> podzialPrzychodu = dbHandler.PobierzPodzialPrzychodu();
            var dataSourcePodzial = podzialPrzychodu.Select(g => new {
                Przychod_Na_Miejscu = g.przychodNaMiejscu + " zł",
                Udzial_Na_Miejscu = g.udzialNaMiejscu + " %",
                Ilosc_Zamowien_Na_Miejscu = g.iloscNaMiejscu,
                Przychod_Na_Wynos = g.przychodNaWynos + " zł",
                Udzial_Na_Wynos = g.udzialNaWynos + " %",
                Ilosc_Zamowien_Na_Wynos = g.iloscNaWynos
            }).ToList();
            dataGridViewPodzialPrzychodu.DataSource = dataSourcePodzial;

            ChangeColumnNames();
        }
        private void ChangeColumnNames()
        {
            // Sprawdzenie i zmiana nazw kolumn
            if (dataGridViewPodzialPrzychodu.Columns["Przychod_Na_Miejscu"] != null)
                dataGridViewPodzialPrzychodu.Columns["Przychod_Na_Miejscu"].HeaderText = "Przychód na miejscu";

            if (dataGridViewPodzialPrzychodu.Columns["Udzial_Na_Miejscu"] != null)
                dataGridViewPodzialPrzychodu.Columns["Udzial_Na_Miejscu"].HeaderText = "Udział";

            if (dataGridViewPodzialPrzychodu.Columns["Ilosc_Zamowien_Na_Miejscu"] != null)
                dataGridViewPodzialPrzychodu.Columns["Ilosc_Zamowien_Na_Miejscu"].HeaderText = "Ilość na miejscu";

            if (dataGridViewPodzialPrzychodu.Columns["Przychod_Na_Wynos"] != null)
                dataGridViewPodzialPrzychodu.Columns["Przychod_Na_Wynos"].HeaderText = "Przychód na wynos";

            // Zakładając, że mamy unikalne identyfikatory dla kolumn "Udział" i "Ilość" dla na wynos
            if (dataGridViewPodzialPrzychodu.Columns["Udzial_Na_Wynos"] != null)
                dataGridViewPodzialPrzychodu.Columns["Udzial_Na_Wynos"].HeaderText = "Udział";

            if (dataGridViewPodzialPrzychodu.Columns["Ilosc_Zamowien_Na_Wynos"] != null)
                dataGridViewPodzialPrzychodu.Columns["Ilosc_Zamowien_Na_Wynos"].HeaderText = "Ilość na wynos";
        }

    }
}
