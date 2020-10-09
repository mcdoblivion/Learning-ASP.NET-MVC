using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer {Name = "Customer 1"},
            new Customer {Name = "Customer 2"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var customersViewModel = new CustomersViewModel
            {
                ListCustomers = customers
            };
            return View(customersViewModel);
        }

        [Route("customers/details/{index}")]
        public ActionResult Details(int? index)
        {
            if (!index.HasValue)
            {
                index = 1;
            }
            if (index > customers.Count)
            {
                return new HttpNotFoundResult();
            }
            var customer = customers.ElementAt((int)index - 1);
            return View(customer);
        }
    }
}