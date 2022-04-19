using Microsoft.AspNetCore.Mvc;
using backend.Models;

namespace backend.Controllers
{
    public class BookController : Controller
    {
        private DataContext context { get; set; }
        public BookController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        [Route("Book/Add")]

        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Book());
        }
        [HttpGet]
        [Route("Book/Edit/{id}")]
        public IActionResult Edit(long id)
        {
            ViewBag.Action = "Edit";
            var book = context.Books.Find(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                if (book.BookId == 0)
                    context.Books.Add(book);
                else
                    context.Books.Update(book);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (book.BookId == 0) ? "Add" : "Edit";
                return View(book);
            }
        }
        [HttpGet]
        [Route("Book/Delete/{id}")]
        public IActionResult Delete(long id)
        {
            var book = context.Books.Find(id);
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            context.Books.Remove(book);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
}