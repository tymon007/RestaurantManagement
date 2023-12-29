using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class DataGridViewModels
    {
        public class ZamowienieElement
        {
            public int produkt_ilosc;
            public int produkt_id;
            public string? produkt_nazwa;
            public double produkt_cena;

            public object ZamowienieElementDGV => new
            {
                Ilość = produkt_ilosc,
                Nazwa = produkt_nazwa,
                Cena = produkt_cena + " zł",
                Suma = produkt_ilosc*produkt_cena + " zł"
            };
        }
    }
}
