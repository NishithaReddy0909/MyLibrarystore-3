using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLibrarystore.Models;

namespace MyLibrarystore.Repository
{
    public class MockBookRepository :IBookRepository
    {
        public BookDetails GetBookById(int id)
        {
            var books = GetBooks();
            return books.FirstOrDefault(x => x.Id == id);

        }

       public IEnumerable<BookDetails> GetBooks()
        {
            return new List<BookDetails>
            {
                new BookDetails{Id=1,BookName="2 States",Author="Chethan Bhagat",ISBN="1336357",PublishedDate=Convert.ToDateTime("09/04/1998")},
                 new BookDetails{Id=2,BookName="Worls India",Author="Rufson",ISBN="13946747",PublishedDate=Convert.ToDateTime("07/04/1987")},
                  new BookDetails{Id=3,BookName="Wings of World",Author="Abdul kalam",ISBN="16733277",PublishedDate=Convert.ToDateTime("09/04/1995")},
            };
        }
        public void CreateBook(BookDetails book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book));
            }

        }
      

      
        public void UpdateBook( int? Id,BookDetails book)
        {
            throw new NotImplementedException();
        }

      

        public void DeleteBook(int Id)
        {
            throw new NotImplementedException();
        }

       
    }
}
