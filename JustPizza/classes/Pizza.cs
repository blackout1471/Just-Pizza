using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustPizza.classes
{
    public class Pizza
    {
        public List<Topping> Toppings
        {
            get
            {
                return this.toppings;
            }
        }

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

        public int TotalPrice
        {
            get
            {
                int totalPrice = 0;
                for (int i = 0; i < this.toppings.Count; i++)
                {
                    totalPrice += this.toppings[i].Price;
                }

                return totalPrice;
            }
        }

        private List<Topping> toppings = new List<Topping>();

        private int id;
        private string name;
        private int startPrice = 36;

        public Pizza(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public Pizza(int id, string name, List<Topping> toppings)
        {
            this.id = id;
            this.name = name;
            this.toppings = toppings;
        }
    }
}