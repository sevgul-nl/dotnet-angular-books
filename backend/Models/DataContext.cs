using System;
using Microsoft.EntityFrameworkCore;

namespace backend.Models{

    public class DataContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        public string DbPath { get; }

       // public DataContext()
       // {
       //     var folder = Environment.SpecialFolder.LocalApplicationData;
       //     var path = Environment.GetFolderPath(folder);
       //     DbPath = System.IO.Path.Join(path, "ebook.db");
       // }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite($"Data Source={DbPath}");
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<Book>().HasData(
                new Book {
                    BookId = 1,
                    Title = "Moby Dick",
                    Author = "Herman Melville",
                    Rating = 3
                },
                new Book {
                    BookId = 2,
                    Title = "A Tale of Two Cities",
                    Author = "Charles Dickens",
                    Rating = 3
                },
                new Book {
                    BookId = 3,
                    Title = "War and Peace",
                    Author = "Leo Tolstoy",
                    Rating = 3
                },
                new Book {
                    BookId = 4,
                    Title = "Jane Eyre",
                    Author = "Charlotte Brontë",
                    Rating = 3
                },
                new Book {
                    BookId = 5,
                    Title = "Ulysses",
                    Author = "James Joyce",
                    Rating = 3
                }
            );
        }
    

    
    
    }
}