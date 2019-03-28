using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JustPizza.sql
{
    public class AdminPageLogin : DataConnection
    {
   

        public bool LoginCheck(string loginName, string loginPassword)
        {
            this.ConnectionString = $"Data Source=192.168.6.4;Persist Security Info=True;User ID={loginName};Password={loginPassword};Database=PizzaDB";
            if (Login() == true)
            {
                
                return true;
            }
            else
            {
               
                return false;
            }
        }
    }
}