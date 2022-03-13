using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ITMO.ASPnet.WebMVCR1.Models;

namespace ITMO.ASPnet.WebMVCR1.Controllers
{
    public class MyController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index(string hel) 
        { 
            int hour = DateTime.Now.Hour; 
            string Greeting = ModelClass.ModelHello() + ", " + hel; 
            return Greeting;
        }
    }
}