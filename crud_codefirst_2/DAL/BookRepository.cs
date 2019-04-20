using crud_codefirst_2.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace crud_codefirst_2.DAL
{
    public class BookRepository : IBookRepository
    {
        private BookContext _context;

        public BookRepository(BookContext bookContext)
        {
            this._context = bookContext;
        }
        public IEnumerable<Book> GetBooks()
        {
            return _context.Book.ToList();
        }

        public Book GetBookByID(int id)
        {
            return _context.Book.Find(id);
        }

        public void InsertBook(Book book)
        {
            _context.Book.Add(book);
        }

        public void DeleteBook(int bookID)
        {
            Book book = _context.Book.Find(bookID);
            _context.Book.Remove(book);
        }

        public void UpdateBook(Book book)
        {
            _context.Entry(book).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}