using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Purchase> Purchases { get; set; }



    }

    public class BookDbInitializer : DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book { Name = "Кобзар", Author = "Т Шевченко", Price = 220 });
            db.Books.Add(new Book { Name = "Кайдашева сім'я", Author = "Н Левицький", Price = 150 });
            db.Books.Add(new Book { Name = "П'єса для чотирьох рук", Author = "І Донич", Price = 80 });

            base.Seed(db);
        }

    }
}