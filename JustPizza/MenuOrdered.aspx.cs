using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using JustPizza.classes;
using JustPizza.sql;

namespace JustPizza
{
    public partial class menuOrdered : System.Web.UI.Page
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

        protected void Page_Load(object sender, EventArgs e)
        {
            // Check that there is an order
            if (this.CustomPizzaOrders.Count == 0)
                this.Response.Redirect("./default.aspx");

            int priceAll = 0;

            menuList.DataSource = CustomPizzaOrders;
            menuList.DataBind();

            for (int i = 0; i < CustomPizzaOrders.Count; i++)
            {
                priceAll += this.CustomPizzaOrders[i].TotalPrice;
            }

            PriceInAll.Text = "Price in all: " + priceAll.ToString() + " Kr.";

            this.CustomPizzaOrders = null;
        }
    }
}