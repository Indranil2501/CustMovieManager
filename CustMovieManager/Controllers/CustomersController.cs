using CustMovieManager.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace CustMovieManager.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>() {
                new Customer{ Id = 1, Name = "Monica"},
                new Customer{ Id = 2, Name = "Fibi"},
                new Customer{ Id = 3, Name = "Ross"},
                new Customer{ Id = 4, Name = "Rachel"},
                new Customer{ Id = 5, Name = "Joey"},
                new Customer{ Id = 6, Name = "Chandler"}
            };

        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            if (!id.HasValue)
                return HttpNotFound();

            Customer customer = customers.Find(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}