using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JustPizza.sql;
using JustPizza.classes;

namespace JustPizza
{
    public partial class orderSelf : System.Web.UI.Page
    {
        PizzaDb pDb = new PizzaDb();
        List<Pizza> pList;

        protected void Page_Load(object sender, EventArgs e)
        {
            pList = pDb.GetPizzas();

            for (int i = 0; i < pList.Count; i++)
            {
                test.Text += pList[i].ToString() + "<br>";
            }
        }
    }
}