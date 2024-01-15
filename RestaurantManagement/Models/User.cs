using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class User
    {
        public string Login;
        public string Haslo;
        public int UserID;
        public enum Rola
        {
            Pracownik = 0,
            Kierownik = 1,
            Administrator = 2
        }
    }
}
