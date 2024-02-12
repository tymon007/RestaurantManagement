using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Mozilla;
using RestaurantManagement.Models;

namespace RestaurantManagement.Models
{
    public class Raporty
    {
        public class NajpopularniejszeDania
        {
            public string nazwaDania;
            public int iloscSztuk;
            public double udzialProcentowy;
        }

        public class GodzinyPracownikow
        {
            public string imie;
            public string nazwisko;
            public string rola;
            public int godzinyDostepny;
            public int godzinyUrlop;
            public int godzinyNiedostepny;
        }

        public class PrzychodMiesieczny
        {
            public string miesiac;
            public double przychod;
        }

        public class PodzialPrzychodu
        {
            public double przychodNaMiejscu;
            public double udzialNaMiejscu;
            public int iloscNaMiejscu;
            public double przychodNaWynos;
            public double udzialNaWynos;
            public int iloscNaWynos;
        }
    }
}
