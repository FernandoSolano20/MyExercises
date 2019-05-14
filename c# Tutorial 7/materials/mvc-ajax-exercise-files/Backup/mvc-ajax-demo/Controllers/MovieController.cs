using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MovieTheaterDomain;

namespace mvc_ajax_demo.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/

        public ActionResult Index(string query)
        {

            if (query == "error")
            {
                throw new InvalidOperationException();
            }

            var ctx = new MoviesContext();
            var movies = ctx.MovieSet
                            .Where(m => m.Title.StartsWith(query) || query == null)
                            .OrderByDescending(m => m.ReleaseDate)
                            .Take(10)
                            .ToList();

            if (Request.IsAjaxRequest())
            {
                return PartialView("_MovieTable", movies);
            }

            return View("Index", movies);      
        }

        public string SearchCandidates(string q, int limit)
        {
            var ctx = new MoviesContext();
            var movies = ctx.MovieSet
                            .Where(m => m.Title.StartsWith(q))
                            .OrderByDescending(m => m.ReleaseDate)
                            .Take(limit)
                            .Select(m => m.Title);

            return String.Join(Environment.NewLine, movies.ToArray());

        }

        public ActionResult Create()
        {
            return View("Create");
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create([Bind(Include="Title, ReleaseDate")] Movie newMovie)
        {
            if (String.IsNullOrEmpty(newMovie.Title))
            {
                ModelState.AddModelError("Title", "Title must be populated");
            }
            return View("Create", newMovie);
        }
    
    }




}
