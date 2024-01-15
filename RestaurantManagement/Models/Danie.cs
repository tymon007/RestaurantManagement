using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement.Models
{
    public class Danie
    {
        public int ID;
        public string Nazwa;
        public double Cena;
        public string LinkDoZdjecia;
        public enum Kategoria
        {
            Burger = 0,
            Napoj = 1,
            Przekaska = 2
        }
    }
}
