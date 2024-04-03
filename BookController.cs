using G_Prg_Book.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace G_Prg_Book.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> books = new List<Book>()
{
new Book { BookID = 1, BookTitle = "Book1", BookAuthors = "Author1", PublisherName = "Publisher1", Price =
2500, ISDN = "1234567890" }, new Book { BookID = 2, BookTitle = "Book2", BookAuthors = "Author2", PublisherName = "Publisher2", Price =
3500, ISDN = "1122334455" }, new Book { BookID = 3, BookTitle = "Book3", BookAuthors = "Author3", PublisherName = "Publisher3", Price =
4500, ISDN = "2233445566" }, new Book { BookID = 4, BookTitle = "Book4", BookAuthors = "Author4", PublisherName = "Publisher4", Price =
4400, ISDN = "3344556677" }, new Book { BookID = 5, BookTitle = "Book5", BookAuthors = "Author5", PublisherName = "Publisher5", Price =
7600, ISDN = "4455667788" }
};
        // GET: Book
        public ActionResult Index()
        {
            return View(books);
        }
        public ActionResult Edit(int id)
        {
            var book = books.FirstOrDefault(b => b.BookID == id);
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book updatedBook)
        {
            if (ModelState.IsValid)
            {
                var existingBook = books.FirstOrDefault(b => b.BookID
                == updatedBook.BookID);
                if (existingBook != null)
                {
                    existingBook.BookTitle = updatedBook.BookTitle;
                    existingBook.BookAuthors =
                    updatedBook.BookAuthors;
                    existingBook.PublisherName =
                    updatedBook.PublisherName;
                    existingBook.Price = updatedBook.Price;
                    existingBook.ISDN = updatedBook.ISDN;
                    return RedirectToAction("Index");
                }
            }
            return View("Index");
        }
    }
}