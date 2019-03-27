using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustPizza.classes
{
    public class Topping
    {
        public int Price
        {
            get
            {
                return this.price;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        private int price;
        private string name;
        private int id;

        public Topping(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }


    }
}