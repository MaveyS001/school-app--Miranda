using Microsoft.EntityFrameworkCore;
using SchoolApp.Models;

namespace SchoolApp.Data
{
    public class SchoolAppContext : DbContext
    {
        public SchoolAppContext(DbContextOptions<SchoolAppContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(s => s.StudentNo).IsRequired(false);
                entity.Property(s => s.Name).IsRequired(false);
                entity.Property(s => s.Email).IsRequired(false);
                entity.Property(s => s.Phone).IsRequired(false);
                entity.Property(s => s.Age).IsRequired(false);
                entity.Property(s => s.BirthDate).IsRequired(false);
            });
        }
    }
}