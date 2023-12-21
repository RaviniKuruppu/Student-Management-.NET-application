using Microsoft.EntityFrameworkCore;
using StudentManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Infastructure
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to Many (Student and Subject)
            modelBuilder.Entity<Student>()
             .HasMany(s => s.Subject)
             .WithMany(s => s.Student)
             .UsingEntity(j => j.ToTable("Enrollments"));
        }
    }
}
