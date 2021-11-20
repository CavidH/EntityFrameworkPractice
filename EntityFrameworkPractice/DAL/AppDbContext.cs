//   @author   Cavid Haciyev

using EntityFrameworkPractice.Models;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkPractice;

namespace EntityFrameworkPractice.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-9PAGU9P;Database=Shop;Trusted_Connection=True;"
                );
        }
    }
} 