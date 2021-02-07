using EFCoreWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWebApi.EF {

    public class ApplicationDbContext : DbContext {

        /*------------------------ FIELDS REGION ------------------------*/
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> Owners { get; set; }

        /*------------------------ METHODS REGION ------------------------*/
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }

    }

}
