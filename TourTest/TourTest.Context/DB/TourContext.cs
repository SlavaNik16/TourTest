using System.Data.Entity;
using TourTest.Context.Models;

namespace TourTest.Context.DB
{
    public class TourContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<User> Users { get; set; }

        public TourContext() : base("DefaultConnection")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
