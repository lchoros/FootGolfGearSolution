using FootGolfGearWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace FootGolfGearWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "FGB", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Pro Balls", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Accessories", DisplayOrder = 3 }
                );
        }
    }
}
