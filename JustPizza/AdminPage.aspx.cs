using JustPizza.classes;
using JustPizza.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JustPizza.Css
{
    public partial class AdminPage : System.Web.UI.Page
    {
        MenuDb menu = new MenuDb();
       

        protected void Page_Load(object sender, EventArgs e)
        {
      

            if (HttpContext.Current.Session["Login"] != null)
            {
                Page.Visible = true;
                menuList.DataSource = menu.GetMenu();
                menuList.DataBind();
            }
            else
            {
                Page.Visible = false;
                Response.Redirect("AdminLogin.aspx");
            }
        
        }


        protected void Logout_click(object sender, EventArgs e)
        {

            Session["Login"] = null;
            Response.Redirect("AdminLogin.aspx");
        }


        public void DeletePizza(object sender, EventArgs e)
        {
           
            //Skal kunne delete pizza from database.
            

        }





    }
}