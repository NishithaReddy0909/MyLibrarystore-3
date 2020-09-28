using MyLibrarystore.Data;
using MyLibrarystore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace MyLibrarystore.Repository
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext _dbContext = null;
        public BookRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<BookDetails> GetBooks()
        {
            return _dbContext.Books.ToList();
        }
        public BookDetails GetBookById(int id)
        {
            return _dbContext.Books.ToList().SingleOrDefault(x => x.Id == id);
        }

        public void CreateBook(BookDetails book)
        {

            _dbContext.Books.Add(book);
            _dbContext.SaveChanges();
        }


        public void UpdateBook(int? Id, BookDetails book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }
            if (Id == null)
            {
                throw new ArgumentNullException(nameof(Id));
            }
            var bookInDB = _dbContext.Books.SingleOrDefault(x => x.Id == Id.Value);

            bookInDB.BookName = book.BookName;
            bookInDB.Author = book.Author;
            bookInDB.ISBN = book.ISBN;
            bookInDB.PublishedDate = book.PublishedDate;
            bookInDB.Genre = book.Genre;
            _dbContext.SaveChanges();

        }
        //_dbContext.Entry(book).State = EntityState.Modified;

    
        public void Dispose()
        {
            if (_dbContext != null)
            {
                _dbContext.Dispose();
            }
        }

        public void DeleteBook(int id)
        {
            var book = _dbContext.Books.FirstOrDefault(x=>x.Id==id);
             _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();


        }

       
    }
}

