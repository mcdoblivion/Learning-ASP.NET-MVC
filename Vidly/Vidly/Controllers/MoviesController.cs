﻿using System;
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

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        public ActionResult ListAll()
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

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(month + "/" + year);
        }
    }
}