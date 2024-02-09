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

            public override string ToString()
            {
                return $"{produkt_nazwa} | {produkt_ilosc} | {produkt_ilosc*produkt_cena} zł";
            }
        }
        public class ZarzadzanieZamowieniami
        {
            public enum StatusZamowienia 
            {
                Przyjete = 0,
                Zrealizowane = 1,
                Wyslane = 2,
            }

            public int IDZamowienia;
            public double Cena;
            public string Status_zamowienia;
            public StatusZamowienia Status;
            public DateTime DataZlozenia;
            public DateTime? GodzinaRealizacji;
            public int User;
            public List<ZamowienieElement> PozycjeZamowienia;
            public bool NaMiejscu;
            public int? Adres;
            public int NumerZamowienia;

            public object DataGridViewModel => new
            {
                DataZlozenia = DataZlozenia.ToString("MM:dd"),
                GodzinaZlozenia = DataZlozenia.ToString("t"),
                GodzinaRealizacji = GodzinaRealizacji.HasValue ? GodzinaRealizacji.Value.ToString("t") : string.Empty, 
                PozycjeZamowienia = PozycjeZamowienia,
                NaMiejscu = NaMiejscu, //!!!Przy robieniu funkcji wyswietlajacej to pole obiektu w dgv trzeba bedzie true i false zamienic na Na miejscu i Na wynos
                Adres = Adres,
            };
            private string MiejsceWynos()
            {
                if (NaMiejscu == true)
                {
                    return "Na miejscu";
                }
                return $"Na wynos. Adres: {Adres}";
            }
            private (string pozycjeZamowienia, string wartoscZamowienia) PolaczPozycjeZamówienia()
            {
                StringBuilder pozycjeZamowienia = new StringBuilder();
                double wartoscZamowienia = 0;

                foreach (ZamowienieElement item in PozycjeZamowienia)
                {
                    pozycjeZamowienia.AppendLine(item.ToString());
                    wartoscZamowienia += item.produkt_cena * item.produkt_ilosc;
                }

                return (pozycjeZamowienia.ToString(), wartoscZamowienia.ToString("00.00"));
            }
            public double WartoscZamowienia()
            {
                double wartoscZamowienia = 0;

                foreach (ZamowienieElement item in PozycjeZamowienia)
                {
                    wartoscZamowienia += item.produkt_cena * item.produkt_ilosc;
                }

                return wartoscZamowienia;
            }
            public override string ToString()
            {
                return $"Data złożenia: {DataZlozenia.ToString("dd:MM:yyyy  HH:mm")}\n" +
                    MiejsceWynos() + "\n" + PolaczPozycjeZamówienia().pozycjeZamowienia + "\n" + 
                    "Wartość zamówienia: " + PolaczPozycjeZamówienia().wartoscZamowienia + " zł";
            }
        }
    }
}
