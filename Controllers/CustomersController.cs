using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr2.ViewModels;
using LibApp_Gr2.Models;


namespace LibApp_Gr2.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = getCustomers();

            return View(customers);
        }

        public IActionResult Details (int id)
        {
            var customer = getCustomers().SingleOrDefault(c =>c.Id == id);
            
            if(customer == null)
            {
                return Content("User not found");
            }

            return View(customer);
        }
        private IEnumerable<Customer> getCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Jan Kowalski"},
                new Customer {Id = 2, Name = "Monika Nowak"}
            };
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
