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
            

        }
    }
}