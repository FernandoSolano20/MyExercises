using System;
using System.Linq;
using mvc_tdd.Models;


namespace mvc_tdd.Tests.Controllers
{
    public interface IMovieRepository
    {
        IQueryable<Movie> FindAll();
    }
}
