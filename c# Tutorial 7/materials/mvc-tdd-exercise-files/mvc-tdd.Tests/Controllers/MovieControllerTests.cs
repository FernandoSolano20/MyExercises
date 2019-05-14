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

    // when the movie controller index action executes
    //   it should render the default view
    //   it should pass a list of movies to the view


    public class MovieRepository : IMovieRepository
    {
        public IQueryable<Movie> FindAll()
        {
            return _ctx.MovieSet;
        }

        MoviesContext _ctx = new MoviesContext();
    }

    [TestClass]
    public class when_the_movie_controller_index_action_executes
    {
        [TestMethod]
        public void it_should_render_the_default_view()
        {
            var repository = new Mock<IMovieRepository>();
            var controller = new MovieController(repository.Object);

            var result = controller.Index();

            Assert.AreEqual("", result.ViewName);
        }

        [TestMethod]
        public void it_should_pass_movies_as_the_model()
        {
            var movies = new List<Movie>()
            {
                new Movie { Title="foo" },
                new Movie { Title="bar" }
            }.AsQueryable();

            var repository = new Mock<IMovieRepository>();
            var controller = new MovieController(repository.Object);
            repository.Setup(r => r.FindAll())
                      .Returns(movies);

            var model = controller.Index().ViewData.Model as IEnumerable<Movie>;

            Assert.IsTrue(movies.SequenceEqual(model));
        }
    }
}
