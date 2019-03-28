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

        public List<Topping> Toppings
        {
            get
            {
                if (HttpContext.Current.Session["Toppings"] == null)
                {
                    HttpContext.Current.Session["Toppings"] = new List<Topping>();
                }
                return HttpContext.Current.Session["Toppings"] as List<Topping>;
            }
            set
            {
                HttpContext.Current.Session["Toppings"] = value;
            }
        }

        List<Topping> toppingsDbList = new List<Topping>();

        ToppingDb tDb = new ToppingDb();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                toppingsDbList = tDb.GetToppings();

                toppingList.DataSource = toppingsDbList;
                toppingList.DataBind();
            }
        }

        protected void toppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tid = Int32.Parse(toppingList.SelectedRow.Cells[0].Text);
            string tname = toppingList.SelectedRow.Cells[1].Text;
            int tprice = Int32.Parse(toppingList.SelectedRow.Cells[2].Text.Split('K')[0]);

            Topping tnew = new Topping(tid, tname, tprice);

            Toppings.Add(tnew);

            if (toppingsText.Text != "")
                toppingsText.Text += ", " + tnew.Name;
            else
                toppingsText.Text += tnew.Name;

        }

        protected void AddPizza_Click(object sender, EventArgs e)
        {
            if (Toppings.Count == 0)
                return;

            Pizza curPizza = new Pizza(999, "Custom Pizza", Toppings);

            this.CustomPizzaOrders.Add(curPizza);

            Toppings = null;
            toppingsText.Text = "";
        }

        protected void orderNow_Click(object sender, EventArgs e)
        {
            this.Toppings = null;
            HttpContext.Current.Response.Redirect("./menuOrdered.aspx");
        }
    }
}