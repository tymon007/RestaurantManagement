using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    internal class Rezerwacja
    {
        public int Id { get; set; }
        public string Stolik { get; set; }
        public DateTime DataOd { get; set; }
        public DateTime DataDo { get; set; }
        public string OsobaRezerwujaca { get; set; }
    }
}
