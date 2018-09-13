using CustMovieManager.Models;
using System.Collections.Generic;

namespace CustMovieManager.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}