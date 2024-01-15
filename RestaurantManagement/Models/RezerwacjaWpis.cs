using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class RezerwacjaWpis
    {
        public DateTime DataRezerwacji;
        public TimeSpan GodzinaOd;
        public TimeSpan GodzinaDo;
        public string Stolik;
        public string? Osoba;
        public string? Telefon;

        public object DataGridViewModel => new
        {
            DataRezerwacji = DataRezerwacji,
            GodzinaOd = GodzinaOd,
            GodzinaDo = GodzinaDo,
            Stolik = Stolik,
            Osoba = Osoba,
            Telefon = Telefon
        };
    }
}
