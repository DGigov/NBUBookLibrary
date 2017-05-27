using NbuBookLibrary.Models.BooksModels;
using System.Data.Entity;

namespace NbuBookLibrary.DbContexts
{
    public class BooksDb : DbContext
    {
        public BooksDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<Book> Books { get; set; }

        public DbSet<Author> Authors { get; set; }
    }
}