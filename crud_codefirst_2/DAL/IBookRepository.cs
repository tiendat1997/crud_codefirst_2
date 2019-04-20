using crud_codefirst_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_codefirst_2.DAL
{
    interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByID(int bookId);
        void InsertBook(Book book);
        void DeleteBook(int bookID);
        void UpdateBook(Book book);
        void Save();
    }
}
