using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace SampleWebFormsApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            var path = Server.MapPath("//Images");
            var data = new ProductDatabase().GetAllProducts(path);
            Application["AllProducts"] = data;
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }
    }
}