using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class Pracownik
    {
        public int Id { get; set; }
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public User Uzytkownik { get; set; }
        public DateTime? DataRozpoczeciaPracy { get; set; }
        public string? Plec { get; set; }
        public int? Wiek { get; set; }
        public string? LinkDoZdjecia { get; set; }

        public Pracownik() { }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko}";
        }
    }
}
