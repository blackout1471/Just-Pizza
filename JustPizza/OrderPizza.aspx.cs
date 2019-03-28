using System;
using JustPizza.sql;
using JustPizza.classes;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JustPizza
{
    public partial class OrderPizza : System.Web.UI.Page
    {
        public List<Pizza> CustomPizzaOrders
        {
            get
            {
                if (HttpContext.Current.Session["CustomOrder"] == null)
                {
                    HttpContext.Current.Session["CustomOrder"] = new List<Pizza>();
                }
                return HttpContext.Current.Session["CustomOrder"] as List<Pizza>;
            }
            set
            {
                HttpContext.Current.Session["CustomOrder"] = value;
            }
        }

        MenuDb menu;
        List<PizzaMenu> dataSource;

        protected void Page_Load(object sender, EventArgs e)
        {
            menu = new MenuDb();

            dataSource = menu.GetMenu();

            if (!this.IsPostBack)
            {

                

                menuList.DataSource = dataSource;
                menuList.DataBind();
            }
        }

        protected void menuList_SelectedIndexChanged(object sender, EventArgs e)
        {

            PizzaMenu curSel = dataSource[menuList.SelectedIndex];

            Pizza piz = new Pizza(curSel.Id, curSel.Name, curSel.Toppings);

            CustomPizzaOrders.Add(piz);
        }

        protected void orderNow_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("./menuOrdered.aspx");
        }
    }
}