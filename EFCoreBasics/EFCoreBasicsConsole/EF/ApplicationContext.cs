using EFCoreBasicsConsole.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreBasicsConsole.EF {

    public class ApplicationContext : DbContext {

        /*------------------------ FIELDS REGION ------------------------*/
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseNpgsql(
                "Host=localhost;Database=EFCoreBasics;Username=postgres;Password=admin"
            );

        }

    }

}
