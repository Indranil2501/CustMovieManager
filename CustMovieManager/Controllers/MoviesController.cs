using CustMovieManager.Models;
using System;
using System.Web.Mvc;

namespace CustMovieManager.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            Movie movie = new Movie() { Id = 1, Name = "Harry Potter and The Chamber of Secrets"};
            //return View(movie);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});
        }

        public ActionResult Index(int? page, string sortBy)
        {
            if (!page.HasValue)
                page = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("page={0}&sortBy={1}", page, sortBy));
        }

        public ActionResult Edit(int id)
        {
            return Content("id: " + id);
        }


    }
}