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

        /// <summary>
        /// Delete a topping based on id
        /// </summary>
        /// <param name="id"></param>
        public void DeleteTopping(int id)
        {
            string delTopCmd = "DELETE FROM Toppings WHERE Id=" + id;

            this.DeleteData(delTopCmd);
        }

        /// <summary>
        /// Updates a topping based on the topping
        /// </summary>
        /// <param name="updatedTopping"></param>
        public void UpdateTopping(Topping updatedTopping)
        {
            string updToppingCmd = "Update Toppings SET Tname='" + updatedTopping.Name + "', Price='" + updatedTopping.Price + "' WHERE Id=" + updatedTopping.Id;

            this.UpdateData(updToppingCmd);
        }

        /// <summary>
        /// Adds a topping to the database
        /// </summary>
        /// <param name="topping"></param>
        public void AddTopping(Topping topping)
        {
            string insTopping = "INSERT INTO Toppings VALUES ('" + topping.Name + "', '" + topping.Price + "')";

            this.InsertData(insTopping);
        }
    }
}