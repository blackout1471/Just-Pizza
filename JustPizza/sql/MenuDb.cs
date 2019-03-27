using System;
using System.Data;

namespace JustPizza.sql
{
    public class MenuDb : DataConnection
    {
        public DataTable MenuDt
        {
            get
            {
                return this.menuDt;
            }
        }

        private DataTable menuDt;


        public MenuDb()
        {
           this.ConnectionString = "Data Source=192.168.6.4;Persist Security Info=True;User ID=sa;Password=!Admin123;Database=PizzaDB";
          //  this.ConnectionString = "Server=localhost;Database=PizzaDB;Trusted_Connection=True;";

            this.menuDt = new DataTable();

            this.UpdateMenuLocal();
        }

        /// <summary>
        /// Update the menu locally
        /// </summary>
        private void UpdateMenuLocal()
        {
            DataTable tmpMenu = new DataTable();

            string menuString = "SELECT Menu.Id as MenuId, MAX(Pizzas.PName) as pizzaName, STRING_AGG(Toppings.TName, ', ') as Toppings, SUM(Toppings.price) as TotalPrice FROM Menu" +
                                " INNER JOIN Pizzas ON Pizzas.Id = Menu.PizzaId" +
                                " INNER JOIN PizzaToppings ON PizzaToppings.PizzaId = Pizzas.Id" +
                                " INNER JOIN Toppings ON Toppings.Id = PizzaToppings.ToppingId" +
                                " GROUP BY Menu.Id;";

            tmpMenu = this.GetData(menuString);

            this.menuDt = tmpMenu;
        }

        /// <summary>
        /// Returns the menu as a string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string builder = "";
            int cols = this.menuDt.Columns.Count;

            foreach (DataRow row in this.menuDt.Rows)
            {
                for (int i = 0; i < cols; i++)
                {
                    builder += row[i] + " ";
                }
                builder += Environment.NewLine;
            }

            return builder;
        }




    }
}