using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustPizza.classes
{
    public class PizzaMenu : Pizza
    {
        public int MenuId
        {
            get
            {
                return this.menuId;
            }
        }

        int menuId;

        public PizzaMenu(int menuId, int pid, string name) : base(pid, name)
        {
            this.menuId = menuId;
        }

        public PizzaMenu(int menuId, int pid, string name, List<Topping> toppings) : base(pid, name, toppings)
        {
            this.menuId = menuId;
        }

        public override string ToString()
        {
            string tmp = base.ToString();

            return "MenuId " + this.menuId + " " + tmp;
        }
    }
}