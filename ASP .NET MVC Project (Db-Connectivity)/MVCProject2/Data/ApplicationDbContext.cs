using Microsoft.EntityFrameworkCore;
using MVCProject2.Models;

namespace MVCProject2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category{CategoryId = 1, name = "Action", DisplayOrder = 1},
                new Category{CategoryId = 2, name = "sci", DisplayOrder = 2},
                new Category{CategoryId = 3, name = "history", DisplayOrder = 3}
                );
            
        }
    }
}