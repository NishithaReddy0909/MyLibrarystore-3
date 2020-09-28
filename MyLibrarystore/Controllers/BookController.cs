using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibrarystore.Models;
using MyLibrarystore.Repository;

namespace MyLibrarystore.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _bookRepos = null;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }
        [HttpGet]
        public IActionResult CreateBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBook(BookDetails book)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.CreateBook(book);
            return RedirectToAction("Index", "Book");
        }
        [HttpPost]
        public ActionResult DeleteBook(int Id) 
        {
            _bookRepos.DeleteBook(Id);
            return RedirectToAction("Index", "Book"); 
        }
        [HttpGet]
        public IActionResult UpdateBook(int Id)
        {
            var book = _bookRepos.GetBookById(Id);
            return View(book);
        }
        [HttpPost]
        public IActionResult UpdateBook(BookDetails book,int? id)
        {
            if (!ModelState.IsValid)
            {

                return View();
            }
            _bookRepos.UpdateBook(id, book);

            return RedirectToAction("Index", "Book");

        }
        public IActionResult anusha()
        {
            return View();
        }
    }
}
