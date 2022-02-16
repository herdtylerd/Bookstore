using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {

        private BookstoreContext BContext { get; set; }

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, BookstoreContext blah)
        {
            BContext = blah;
        }

        public IActionResult Index()
        {
            var books = BContext.Books.ToList();

            return View(books);
        }
    }
}
