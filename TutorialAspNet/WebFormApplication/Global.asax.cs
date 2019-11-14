using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace WebFormApplication
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            // Get when the application started.
            Application["ApplicationStartDateTime"] = DateTime.Now;
        }

        // Stores session specific information. (Same browser at a limited amount of time.)
        void Session_Start(object sender, EventArgs e)
        {
            // Get when the session started. 
            Session["SessionStartDateTime"] = DateTime.Now;
        }
    }
}