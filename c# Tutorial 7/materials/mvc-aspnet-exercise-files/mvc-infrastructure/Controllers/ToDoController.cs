using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using mvc_infrastructure.Models;

namespace mvc_infrastructure.Controllers
{
    public class ToDoController : Controller
    {
        //
        // GET: /ToDo/

        public ActionResult Index()
        {
            ViewData["createMessage"] = TempData["createMessage"];            
            return View(ToDoList.Items);
        }

        //
        // GET: /ToDo/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ToDo/Create

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(ToDo newItem)
        {

            if (ModelState.IsValid)
            {
                ToDoList.Items.Add(newItem);

                var cookie = new HttpCookie("createMessage", "...");
                Response.Cookies.Add(cookie);

                TempData["createMessage"] = "You added " + newItem.Title + " to the list";
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}
