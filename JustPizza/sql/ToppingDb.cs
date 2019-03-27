using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using JustPizza.classes;

namespace JustPizza.sql
{
    public class ToppingDb : DataConnection
    {
        public ToppingDb()
        {
            //this.ConnectionString = "Data Source=192.168.6.4;Persist Security Info=True;User ID=sa;Password=!Admin123;Database=PizzaDB";
            this.ConnectionString = "Server=localhost;Database=PizzaDB;Trusted_Connection=True;";
        }

        /// <summary>
        /// Retreive a topping from the sql server based on id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Topping GetTopping(int id)
        {
            string toppingCmd = "SELECT *" +
                                " FROM Toppings" +
                                " WHERE Id = " + id.ToString();

            DataTable tops = this.GetData(toppingCmd);
            DataRow curTop = tops.Rows[0];

            int tid = Int32.Parse(curTop[0].ToString());
            string name = curTop[1].ToString();
            int tprice = Int32.Parse(curTop[2].ToString().Split(',')[0]);

            return new Topping(tid, name, tprice);
        }

        /// <summary>
        /// Retrieve all toppings in the sql database
        /// </summary>
        /// <returns></returns>
        public List<Topping> GetToppings()
        {
            List<Topping> rtnList = new List<Topping>();

            string toppingsCmd = "SELECT Id FROM Toppings";

            DataTable ids = this.GetData(toppingsCmd);

            for (int i = 0; i < ids.Rows.Count; i++)
            {
                Topping curTop = this.GetTopping(Int32.Parse(ids.Rows[i][0].ToString()));

                rtnList.Add(curTop);
            }

            return rtnList;
        }
    }
}