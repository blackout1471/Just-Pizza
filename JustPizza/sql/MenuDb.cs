using System;
using System.Collections.Generic;
using System.Data;
using JustPizza.classes;

namespace JustPizza.sql
{
    public class MenuDb : DataConnection
    {

        public MenuDb()
        {
           this.ConnectionString = "Data Source=192.168.6.4;Persist Security Info=True;User ID=sa;Password=!Admin123;Database=PizzaDB";
           // this.ConnectionString = "Server=localhost;Database=PizzaDB;Trusted_Connection=True;";

        }

        public List<PizzaMenu> GetMenu()
        {
            PizzaDb pizDb = new PizzaDb();

            string menuCmd = "SELECT * FROM Menu";
            List<PizzaMenu> tmpMenu = new List<PizzaMenu>();

            DataTable menuDt = this.GetData(menuCmd);

            for (int i = 0; i < menuDt.Rows.Count; i++)
            {
                Pizza curPiz = pizDb.GetPizza(Int32.Parse(menuDt.Rows[i][1].ToString()));

                int menuid = Int32.Parse(menuDt.Rows[i][0].ToString());

                PizzaMenu pizMenu = new PizzaMenu(menuid, curPiz.Id, curPiz.Name, curPiz.Toppings);

                tmpMenu.Add(pizMenu);
            }

            return tmpMenu;
        }

        /// <summary>
        /// Deletes a menu item from the database based on the parameter given.
        /// And the pizza that was in the menu
        /// </summary>
        /// <param name="menuid"></param>
        public void DeleteMenuItem(int menuid)
        {
            PizzaDb pizDb = new PizzaDb();

            string getPizzaCmd = "SELECT PizzaId FROM Menu WHERE id = " + menuid;
            string delCmd = "DELETE FROM Menu WHERE id = " + menuid;

            int pizzaId = Int32.Parse(this.GetData(getPizzaCmd).Rows[0][0].ToString()); // Get pizza id

            // Delete From Menu
            this.DeleteData(delCmd);

            // Delete the pizza
            pizDb.DeletePizza(pizzaId);
        }

        /// <summary>
        /// Insert menu into database
        /// </summary>
        /// <param name="newPizza"></param>
        public void AddpizzaToMenu(PizzaMenu newPizza)
        {
            string insPizToMenuCmd = "INSERT INTO Menu VALUES ('" + newPizza.MenuId + "', '" + newPizza.Id + "')";

            this.InsertData(insPizToMenuCmd);
        }

    }
}