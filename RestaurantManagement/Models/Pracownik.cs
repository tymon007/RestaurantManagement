using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class Pracownik
    {
        public string? Imie;
        public string? Nazwisko;
        public User Uzytkownik;
        public DateTime? DataRozpoczeciaPracy;
        public string? Plec;
        public int? Wiek;
        public string? LinkDoZdjecia;

    }
}
