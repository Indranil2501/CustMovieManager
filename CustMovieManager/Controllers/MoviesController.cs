using CustMovieManager.Models;
using CustMovieManager.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CustMovieManager.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            
            Movie movie = new Movie()
            {
                Id = 1,
                Name = "Harry Potter and The Chamber of Secrets"
            };
            List<Customer> customers = new List<Customer>() {
                new Customer{ Id = 1, Name = "Monica"},
                new Customer{ Id = 2, Name = "Fibi"},
                new Customer{ Id = 3, Name = "Ross"},
                new Customer{ Id = 4, Name = "Rachel"},
                new Customer{ Id = 5, Name = "Joey"},
                new Customer{ Id = 6, Name = "Chandler"}
            };

            RandomMovieViewModel viewModel = new RandomMovieViewModel() {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);

            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        public ActionResult Index()
        {
            List<Movie> movies = new List<Movie>() {
                new Movie() { Id = 1, Name = "Harry Potter and The Chamber of Secrets" },
                new Movie() { Id = 2, Name = "Harry Potter and The Deathly Hallows" },
                new Movie() { Id = 3, Name = "Lord Of The Rings - The Fellowship of the Ring" }
            };
            return View(movies);
        }

        public ActionResult Edit(int id)
        {
            return Content("id: " + id);
        }

        [Route("movies/released/{year:regex(^\\d{4}$)}/{month:regex(^\\d{2}$):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}