using Microsoft.EntityFrameworkCore;
using StudentPortal.Web.Models.Entities;

namespace StudentPortal.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Remove configuration that sets Student entity without a primary key
            // modelBuilder.Entity<Student>().HasNoKey();

            // Define Id as primary key explicitly
            modelBuilder.Entity<Student>().HasKey(s => s.Id);

            // You can also configure other entity configurations here if needed
        }
    }
}
