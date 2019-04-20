using crud_codefirst_2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace crud_codefirst_2.DAL
{
    public class BookContext : DbContext
    {
        public BookContext() : base("name=DbConnectionString")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BookContext>(null);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Book> Book { get; set; }


    }
}