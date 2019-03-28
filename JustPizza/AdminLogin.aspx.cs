using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using JustPizza.sql;

namespace JustPizza
{
    public partial class AdminPage : System.Web.UI.Page
    {
        AdminPageLogin AdminPageLogin = new AdminPageLogin();
      


        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// Login button, send information to dataconnection to check if login is true.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
          

            if (AdminPageLogin.LoginCheck(usernameTxt.Text, passwordTxt.Text) == true)
            {
               //Redirect site
                loginConfirmation.Text = "Login success";
                Session["Login"] = "True";
                Response.Redirect("AdminPage.aspx");
                
            }
            else
            {
               
                loginConfirmation.Text = "Login failed";
            }
        }


    }
}