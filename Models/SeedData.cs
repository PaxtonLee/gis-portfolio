using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using gis_portfolio.Data;
using System;
using System.Linq;

namespace gis_portfolio.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new gis_portfolioContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<gis_portfolioContext>>()))
            {
                // Look for any movies.
                if (context.Post.Any())
                {
                    return;   // DB has been seeded
                }

                context.Post.AddRange(
                    new Post
                    {
                        Title = "First GIS Post",
                        short_desc = "This is a very short description about a new GIS post that I am making",
                        date = DateTime.Parse("2021-9-11"),
                        author = "escajedacj@hendrix.edu",
                        long_desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        photo ="~/css/Resources/moon.jpg",
                        display_name = "Connor Escajeda",
                    },

                    new Post
                    {
                        Title = "Second GIS Post",
                        short_desc = "This is a short description about a new GIS post that I am making",
                        date = DateTime.Parse("2021-12-11"),
                        author = "dsfsdafasdfsadfasdfasdfasdfasdfasdf",
                        long_desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        photo = "~/css/Resources/7285.jpg",
                        display_name = "Ethan Thomas"
                    },

                    new Post
                    {
                        Title = "Third GIS Post",
                        short_desc = "This is a very short description about a new GIS post that I am making",
                        date = DateTime.Parse("2021-1-11"),
                        author = "WilliamsCJ@hendrix.edu",
                        long_desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur.Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                        photo = "~/css/Resources/945975.jpg",
                        display_name = "Caleb Williams"
                    }

                );
                context.SaveChanges();
            }
        }
    }
}