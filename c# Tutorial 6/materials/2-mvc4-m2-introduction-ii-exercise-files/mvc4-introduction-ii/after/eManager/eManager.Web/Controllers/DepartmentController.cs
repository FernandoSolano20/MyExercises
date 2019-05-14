  using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eManager.Domain;

namespace eManager.Web.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentDataSource _db;

        public DepartmentController(IDepartmentDataSource db)
        {
            _db = db;
        }


        public ActionResult Detail(int id)
        {
            //que me de de la tabla departemts solamente del obj departments el id donde sea igual al parametro
            var model = _db.Departments.Single(d => d.Id == id);
            return View(model);
        }
    }
}
