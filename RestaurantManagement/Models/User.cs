using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantManagement.Models;

namespace RestaurantManagement.Models
{
    public class User
    {
        public string Login;
        public string Haslo;
        public int UserID;
        public string Rola;
        public enum Role
        {
            Pracownik = 0,
            Administrator = 1
        }
        public int Status;
    }
}
