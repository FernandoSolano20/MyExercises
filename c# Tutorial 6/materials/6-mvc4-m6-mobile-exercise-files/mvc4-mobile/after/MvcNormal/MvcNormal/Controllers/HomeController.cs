using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace MvcNormal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to kick-start your ASP.NET MVC application.";

            return View();
        }

        [HttpGet]
        public ActionResult DisplayModes()
        {
            var model = DisplayModeProvider.Instance.Modes;
            return View(model);
        }

        [HttpPost]
        public ActionResult DisplayModes(string value)
        {
            switch(value)
            {               
                case "mobile":
                    HttpContext.SetOverriddenBrowser(BrowserOverride.Mobile);
                    break;

                case "desktop":
                    HttpContext.SetOverriddenBrowser(BrowserOverride.Desktop);
                    break;

                case "silk":
                    HttpContext.SetOverriddenBrowser(@"Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_6_3; en-us; Silk/1.1.0-80) AppleWebKit/533.16 (KHTML, like Gecko) Version/5.0 Safari/533.16 Silk-Accelerated=true");
                    break;

                default:
                    HttpContext.ClearOverriddenBrowser();
                    break;
            }

            return RedirectToAction("DisplayModes");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
