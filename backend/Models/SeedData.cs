using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend
{
    public class SeedData
    {
        public static void Do(DataContext context)
        {

            context.Database.Migrate();

            if (context.Books.Count() == 0)
            {
                context.Books.AddRange(
                    new Book
                    {
                        BookId = 1,
                        Title = "Moby Dick",
                        Author = "Herman Melville",
                        Rating = 3
                    },
                    new Book
                    {
                        BookId = 2,
                        Title = "A Tale of Two Cities",
                        Author = "Charles Dickens",
                        Rating = 3
                    },
                    new Book
                    {
                        BookId = 3,
                        Title = "War and Peace",
                        Author = "Leo Tolstoy",
                        Rating = 3
                    },
                    new Book
                    {
                        BookId = 4,
                        Title = "Jane Eyre",
                        Author = "Charlotte Brontë",
                        Rating = 3
                    },
                    new Book
                    {
                        BookId = 5,
                        Title = "Ulysses",
                        Author = "James Joyce",
                        Rating = 3
                    }
                );
                if (context.Reviews.Count() == 0)
                {
                    context.Reviews.AddRange();
                }
                context.SaveChanges();
            }
        }
    }
}
