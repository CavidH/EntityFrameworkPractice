//   @author   Cavid Haciyev

using EntityFrameworkPractice.Models;
using Microsoft.EntityFrameworkCore;
using EntityFrameworkPractice;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace EntityFrameworkPractice.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

     /*
      * Query log
      */
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseLoggerFactory(MyLoggerFactory)
                .UseSqlServer(@"Server=DESKTOP-9PAGU9P;Database=Shop;Trusted_Connection=True;"
            );
        }

        //static LoggerFactory object
        public static readonly ILoggerFactory MyLoggerFactory =
            LoggerFactory
                .Create(builder =>
                {
                    builder
                        .AddConsole();
                });
    }
}