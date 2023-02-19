﻿using my_books.Data.Models;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context!.Books.Any())
                {
                    context.Books.AddRange(new Book
                    {
                        Title = "1st Book Tittle",
                        Description = "1st book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Biography",
                        Author = "First Author",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now
                    },
                    new Book
                    {
                        Title = "2nd Book Tittle",
                        Description = "2nd book Description",
                        IsRead = false,
                        Genre = "Biography",
                        Author = "Second Author",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
