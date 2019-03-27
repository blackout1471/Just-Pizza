using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustPizza.classes
{
    public class PizzaMenu
    {
        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public string Toppings
        {
            get
            {
                return this.toppings;
            }
        }

        public int ToppingsPrice
        {
            get
            {
                return this.toppingsPrice;
            }
        }

        private int id;
        private string name;
        private string toppings;
        private int toppingsPrice;

        public PizzaMenu(int id, string name, string toppings, int toppingsPrice)
        {
            this.id = id;
            this.name = name;
            this.toppings = toppings;
            this.toppingsPrice = toppingsPrice;
        }
    }
}