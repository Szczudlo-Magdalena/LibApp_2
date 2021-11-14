using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr2.Models;
using LibApp_Gr2.ViewModels;

namespace LibApp_Gr2.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Random()
        {
            var firstBook = new Book() { Name = "English dictionary" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Jan Kowalski"},
                new Customer { Name = "Piotr Nowak" }
            };

            var viewModel = new RandomBookViewModel
            {
                Book = firstBook,
                Customers = customers
            };

            return View(viewModel);
        }

        public IActionResult Edit(int bookId)
        {
            return Content("id=" + bookId);
        }

        public IActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (String.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("books/released/{year:regex(^\\d{{4}}$):min(1925):max(2021)}/{month:range(1,12)}")]
        public IActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}
