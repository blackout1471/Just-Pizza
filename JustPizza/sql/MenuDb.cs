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
           //this.ConnectionString = "Data Source=192.168.6.4;Persist Security Info=True;User ID=sa;Password=!Admin123;Database=PizzaDB";
            this.ConnectionString = "Server=localhost;Database=PizzaDB;Trusted_Connection=True;";

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



    }
}