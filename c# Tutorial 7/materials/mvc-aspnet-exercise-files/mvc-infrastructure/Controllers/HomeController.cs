using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mvc_infrastructure.Models;

namespace mvc_infrastructure.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        [OutputCache(Duration=30, VaryByParam="parameter")]
        public ActionResult Index(string parameter)
        {
            ViewData["Message"] = parameter ?? "";

            var model = new TimeModel();
            model.ControllerTime = DateTime.Now;
                        
            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
