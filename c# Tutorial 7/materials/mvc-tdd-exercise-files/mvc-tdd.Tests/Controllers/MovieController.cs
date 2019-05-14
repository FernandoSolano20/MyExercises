using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using mvc_tdd.Models;
using Moq;

namespace mvc_tdd.Tests.Controllers
{
    public class MovieController : Controller
    {
        public MovieController(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public ViewResult Index()
        {
            var movies = _movieRepository.FindAll();
            return View(movies);
        }

        IMovieRepository _movieRepository;
    }
}
