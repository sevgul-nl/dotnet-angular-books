using Microsoft.AspNetCore.Mvc;
using backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace backend.Controllers
{
    [Route("Review")]
    public class ReviewController : Controller
    {
        private DataContext context { get; set; }
        public ReviewController(DataContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        [Route("/List/{id}")]
        public IActionResult List(long id)
        {
            //return Content("Review controller, List action id=" + id);
            ViewBag.Action = "List";

            var book = context.Books.Find(id);
            var reviews = context.Reviews.Where(r => r.BookId == id);
            book.Reviews = reviews.ToList();
            //Console.WriteLine("book review count=" + book.Reviews.Count);
            if (book.Reviews == null)
                book.Reviews = new List<Review>();
            return View(book);
        }
        [HttpGet]
        [Route("/Add/{id}")]
        public IActionResult Add(long id)
        {
            ViewBag.Action = "Add";
            var book = context.Books.Find(id);
            book.Reviews = new List<Review>();
            var nreview = new Review();
            nreview.BookId = book.BookId;
            book.Reviews.Add(nreview);
            return View("Edit", book);
        }
        [HttpGet]
        [Route("/Edit/{id}")]
        public IActionResult Edit(long id)
        {
            ViewBag.Action = "Edit";
            var review = context.Reviews.Find(id);
            var book = context.Books.Find(review.BookId);
            book.Reviews = new List<Review>();
            book.Reviews.Add(review);
            return View("Edit", book);
        }
        [HttpPost]
        [Route("/Edit/{id?}")]
        public IActionResult Edit(Review review, long id)
        {
            //Console.WriteLine("BookId = " + review.BookId);
            if (ModelState.IsValid && review.BookId > 0)
            {
                if (review.ReviewId == 0)
                    context.Reviews.Add(review);
                else
                    context.Reviews.Update(review);
                context.SaveChanges();
                return Redirect("/List/" + review.BookId);
            }
            else
            {
                ViewBag.Action = (review.ReviewId == 0) ? "Add" : "Edit";
                return View(review);
            }
        }
        [HttpGet]
        public IActionResult Delete(long id)
        {
            ViewBag.Action = "Delete";
            var review = context.Reviews.Find(id);
            var book = context.Books.Find(review.BookId);
            book.Reviews = new List<Review>();
            book.Reviews.Add(review);
            return View("Delete", book);
        }
        [HttpPost]
        public IActionResult Delete(Review review)
        {
            review = context.Reviews.Find(review.ReviewId);
            var bookId = review.BookId;
            context.Reviews.Remove(review);
            context.SaveChanges();
            return Redirect("/List/" + bookId);
        }

    }
}