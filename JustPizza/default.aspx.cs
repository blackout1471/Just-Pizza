using System;
using JustPizza.sql;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JustPizza
{
    public partial class _default : System.Web.UI.Page
    {
        MenuDb menu = new MenuDb();

        protected void Page_Load(object sender, EventArgs e)
        {
            menuTable.DataSource = menu.MenuDt;
            menuTable.DataBind();
        }
    }
}