using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibrarystore.Models;

namespace MyLibrarystore.Repository
{
   public interface IBookRepository
    {
        IEnumerable<BookDetails> GetBooks();

         BookDetails GetBookById(int id);
         void CreateBook(BookDetails book);
         void UpdateBook(int? Id, BookDetails book);
         void DeleteBook(int Id);
     
     
    }
}
