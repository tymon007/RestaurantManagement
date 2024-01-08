using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class Zamowienia
    {
        //Zhermetyzowqac klasy!!!
        public class ZamowienieElement
        {
            public int produkt_ilosc;
            public int produkt_id;
            public string? produkt_nazwa;
            public double produkt_cena;

            public object DataGridViewModel => new
            {
                Ilość = produkt_ilosc,
                Nazwa = produkt_nazwa,
                Cena = produkt_cena + " zł",
                Suma = produkt_ilosc*produkt_cena + " zł"
            };
        }
        public class ZarzadzanieZamowieniami
        {
            public DateTime DataZlozenia;
            public DateTime GodzinaRealizacji;
            public bool Zrealizowano;
            public List<ZamowienieElement> PozycjeZamowienia;
            public double Wartosc;
            public bool NaMiejscu;
            public string? Stolik;
            public string? Adres;

            public object DataGridViewModel => new
            {
                DataZlozenia = DataZlozenia.ToString("MM:dd"),
                GodzinaZlozenia = DataZlozenia.ToString("t"),
                GodzinaRealizacji = GodzinaRealizacji.ToString("t"),
                Zrealizowano = Zrealizowano, //!!!Przy robieniu funkcji wyswietlajacej to pole obiektu w dgv trzeba bedzie true i false zamienic na Zrealizowano i Nie zrealizowano
                PozycjeZamowienia = PozycjeZamowienia,
                Wartosc = Wartosc,
                NaMiejscu = NaMiejscu, //!!!Przy robieniu funkcji wyswietlajacej to pole obiektu w dgv trzeba bedzie true i false zamienic na Na miejscu i Na wynos
                Stolik = Stolik,
                Adres = Adres,
            };
        }
    }
}
