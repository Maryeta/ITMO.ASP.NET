using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using ITMO.ASP.NET.MyApp.Models;
using System.Data.Entity;

namespace ITMO.ASP.NET.MyApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Database.SetInitializer(new StudentsDbInitializer());
        }
    }
}