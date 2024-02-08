using Org.BouncyCastle.Bcpg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class GrafikWpis
    {
        public int Id { get; set; }
        public int userId;
        public DateTime data; //w kodzie trzeba dac wlasciwosc .Date np DateTime.Now.Date 
        public TimeSpan godzinaOd; // uzywa sie np tak.: new TimeSpan(8, 0, 0) -  wtedy jest 08:00
        public TimeSpan godzinaDo;
        public Pracownik pracownik;
        public string stan;
    }
}
