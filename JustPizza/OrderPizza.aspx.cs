using System;
using JustPizza.sql;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JustPizza
{
    public partial class OrderPizza : System.Web.UI.Page
    {
        MenuDb menu;

        List<int> pizzas;

        protected void Page_Load(object sender, EventArgs e)
        {
            pizzas = new List<int>();

            menu = new MenuDb();

            menuList.DataSource = menu.MenuDt;
            menuList.DataBind();
        }

    }
}