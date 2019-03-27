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
            set
            {
                this.toppings = value;
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

        public static int GetStartPrice
        {
            get
            {
                return startPrice;
            }
        }

        private List<Topping> toppings = new List<Topping>();

        private int id;
        private string name;

        private static int startPrice = 36;

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

        public override string ToString()
        {
            string builder = "";

            builder += String.Format("Id: {0} Name: {1} [", this.id, this.name);

            int tPrice = startPrice;

            for (int i = 0; i < toppings.Count; i++)
            {
                if (i != toppings.Count-1)
                {

                    builder += toppings[i].Name + ",";
                }else
                {
                    builder += toppings[i].Name;
                }
                tPrice += toppings[i].Price;
            }

            builder += "] Price: " + tPrice;

            return builder;
        }
    }
}