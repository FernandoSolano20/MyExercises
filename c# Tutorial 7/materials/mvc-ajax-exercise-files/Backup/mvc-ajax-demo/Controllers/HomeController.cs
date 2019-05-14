using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading;

namespace mvc_ajax_demo.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public string ServerTime()
        {
            Thread.Sleep(2000);
            return DateTime.Now.ToLongTimeString();        
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
