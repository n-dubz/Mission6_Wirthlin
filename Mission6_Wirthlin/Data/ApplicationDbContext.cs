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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed three favorite movies
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
                    Title = "The Matrix",
                    Category = "Action",
                    Director = "The Wachowskis",
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