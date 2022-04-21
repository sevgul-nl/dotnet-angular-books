using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backend.Models;

namespace backend.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context { get; set; }

        public HomeController(DataContext ctx)
        {
            context = ctx;
        }

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        //[Route("Home/Index/{id?}")]
        public IActionResult Index()
        {
            var books = context.Books.OrderBy(m => m.Title).ToList();
            return View(books);
        }

        
        [Route("ng")]
        public List<Book> Placeholder()
        {
            return context.Books.OrderBy(m => m.Title).ToList();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
