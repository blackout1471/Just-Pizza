﻿using JustPizza.classes;
using JustPizza.sql;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JustPizza.Css
{
    public partial class AdminPage : System.Web.UI.Page
    {
        MenuDb menu = new MenuDb();
     
        List<PizzaMenu> dataSource;


        /// <summary>
        /// Check if you are logged in if not redirect you to login screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            menu = new MenuDb();

            dataSource = menu.GetMenu();

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

        /// <summary>
        /// button that log you out.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Logout_click(object sender, EventArgs e)
        {

            Session["Login"] = null;
            Response.Redirect("AdminLogin.aspx");
        }

        /// <summary>
        /// Deleting pizza menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void DeletePizza(object sender, EventArgs e)
        {

            string menuString =menuList.SelectedRow.Cells[0].Text;

            int menuid = 0;

            Int32.TryParse(menuString,out menuid);
            Debug.Print(menuid.ToString());


           menu.DeleteMenuItem(menuid);
            
            //Skal kunne delete pizza from database.
            

        }





    }
}