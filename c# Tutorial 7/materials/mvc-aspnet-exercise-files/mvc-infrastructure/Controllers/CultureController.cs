using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using mvc_infrastructure.Models;

namespace mvc_infrastructure.Controllers
{
    [Authorize(Roles="Admin")]
    public class CultureController : Controller
    {

        public ActionResult Index()
        {
            CultureModel model = new CultureModel();
            model.Amount = 12.45M;
            model.Greeting = Resources.Views.Culture.Index.Greeting;

            return View(model);
        }
    }
}
