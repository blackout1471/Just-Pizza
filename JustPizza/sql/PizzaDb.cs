using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using JustPizza.classes;

namespace JustPizza.sql
{
    public class PizzaDb : DataConnection
    {

        public PizzaDb()
        {
            //this.ConnectionString = "Data Source=192.168.6.4;Persist Security Info=True;User ID=sa;Password=!Admin123;Database=PizzaDB";
            this.ConnectionString = "Server=localhost;Database=PizzaDB;Trusted_Connection=True;";
        }

        /// <summary>
        /// Returns a pizza from its id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Pizza GetPizza(int id)
        {
            string pizzaCmd = "SELECT id, PName" +
                               " FROM Pizzas" +
                               " WHERE id = " + id.ToString();

            string toppingCmd = "SELECT Toppings.Id, Toppings.TName, Toppings.price" +
                                " FROM PizzaToppings"+
                                " INNER JOIN Toppings ON Toppings.Id = PizzaToppings.ToppingId"+
                                " WHERE PizzaToppings.PizzaId = " + id.ToString();

            DataTable tmpt = this.GetData(pizzaCmd);
            DataTable tmpTop = this.GetData(toppingCmd);


            int pid = Int32.Parse(tmpt.Rows[0][0].ToString());
            string name = tmpt.Rows[0][1].ToString();

            Pizza rtnPizza = new Pizza(pid, name);


            List<Topping> top = new List<Topping>();

            for (int i = 0; i < tmpTop.Rows.Count; i++)
            {
                DataRow t = tmpTop.Rows[i];

                int tid = Int32.Parse(t[0].ToString());
                string tname = t[1].ToString();
                int tprice = Int32.Parse(t[2].ToString().Split(',')[0]);

                Topping c = new Topping(tid, tname, tprice);

                top.Add(c);
            }

            rtnPizza.Toppings = top;

            return rtnPizza;
            
        }

        /// <summary>
        /// Get all pizzas with a name
        /// </summary>
        /// <returns></returns>
        public List<Pizza> GetPizzas()
        {
            List<Pizza> rtnList = new List<Pizza>();

            string pizzaCmd = "SELECT Id" +
                               " FROM Pizzas"+
                               " WHERE Id IS NOT NULL";

            DataTable allP = this.GetData(pizzaCmd);

            for (int i = 0; i < allP.Rows.Count; i++)
            {
                int pid = Int32.Parse(allP.Rows[i][0].ToString());

                Pizza curPiz = this.GetPizza(pid);

                rtnList.Add(curPiz);
            }

            return rtnList;
        }
    }
}