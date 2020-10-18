using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Titanic" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 1" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie {Name = "Srek"},
                new Movie {Name = "Srek"},
                new Movie {Name = "Srek"},
                new Movie {Name = "Srek"},
                new Movie {Name = "Srek"},
                new Movie {Name = "Srek"}
            };
            var moviesViewModel = new MoviesViewModel
            {
                ListMovies = movies
            };
            return View(moviesViewModel);
        }
    }
}