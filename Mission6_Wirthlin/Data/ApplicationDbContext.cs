using Microsoft.EntityFrameworkCore;
using Mission6_Wirthlin.Models;

namespace Mission6_Wirthlin.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        // Seed initial data – add your three favorite movies.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>().HasData(
                new Movie 
                { 
                    MovieId = 1, 
                    Title = "Inception", 
                    Category = "Sci-Fi", 
                    Director = "Christopher Nolan", 
                    Rating = "PG-13", 
                    Edited = false 
                },
                new Movie 
                { 
                    MovieId = 2, 
                    Title = "The Godfather", 
                    Category = "Crime", 
                    Director = "Francis Ford Coppola", 
                    Rating = "R", 
                    Edited = false 
                },
                new Movie 
                { 
                    MovieId = 3, 
                    Title = "The Shawshank Redemption", 
                    Category = "Drama", 
                    Director = "Frank Darabont", 
                    Rating = "R", 
                    Edited = false 
                }
            );
        }
    }
}