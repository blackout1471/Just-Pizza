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
        public List<PizzaMenu> pizzaOrders
        {
            get
            {
                if (HttpContext.Current.Session["order"] == null)
                {
                    HttpContext.Current.Session["order"] = new List<PizzaMenu>();
                }
                return HttpContext.Current.Session["order"] as List<PizzaMenu>;
            }
            set
            {
                HttpContext.Current.Session["order"] = value;
            }
        }

        MenuDb menu;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {

                menu = new MenuDb();

                menuList.DataSource = menu.MenuDt;
                menuList.DataBind();
            }
        }

        protected void menuList_SelectedIndexChanged(object sender, EventArgs e)
        {

            int menuid = Int32.Parse(menuList.SelectedRow.Cells[0].Text);
            string pizzaName = menuList.SelectedRow.Cells[1].Text;
            string top = menuList.SelectedRow.Cells[2].Text;
            int price = Int32.Parse(menuList.SelectedRow.Cells[3].Text.Split(',')[0]);

            PizzaMenu pnew = new PizzaMenu(menuid, pizzaName, top, price);

            pizzaOrders.Add(pnew);
        }

        protected void orderNow_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Response.Redirect("./menuOrdered.aspx");
        }
    }
}