using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment11._1.Data
{
    public class BookContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=books.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(GetBooks());
            modelBuilder.Entity<Book>().HasKey(b => b.Id);
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Book>().Property(b => b.Author).IsRequired().HasMaxLength(100);
            modelBuilder.Entity<Book>().Property(b => b.PublishedYear).IsRequired();
        }

        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            Database.EnsureCreated(); // Ensures the database is created if it doesn't exist
        }

        private Book[] GetBooks()
        {
            return new Book[]
            {
                new Book { Id = 1, Title = "1984", Author = "George Orwell", PublishedYear = 1949 },
                new Book { Id = 2, Title = "To Kill a Mockingbird", Author = "Harper Lee", PublishedYear = 1960 },
                new Book { Id = 3, Title = "The Great Gatsby", Author = "F. Scott Fitzgerald", PublishedYear = 1925 },
                new Book { Id = 4, Title = "Pride and Prejudice", Author = "Jane Austen", PublishedYear = 1813 }
            };

        }
    }
}
