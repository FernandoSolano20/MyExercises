using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using mvc_ajax_demo.Models;

namespace mvc_ajax_demo.Controllers
{
    public class InstructorController : Controller
    {
        //
        // GET: /Instructor/

        public ActionResult Index()
        {
            return View();
        }

        public JsonResult InstructorNames()
        {
            var repository = new InstructorRepository();
            var names =
                    from i in repository.FindAll()
                    select new
                    {
                        ID = i.ID,
                        Name = i.Name
                    };
            return Json(names);
        }

        public JsonResult InstructorDetails(int id)
        {
            var repository = new InstructorRepository();
            var instructor = repository.FindByID(id);
            return Json(instructor);
        }
    }
}
