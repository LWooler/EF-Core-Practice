using Microsoft.EntityFrameworkCore;
using App.Models;

namespace App
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students {get; set; }
        public DbSet<Grade> Grades {get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlite("Data Source=School.db");
            base.OnConfiguring(options);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            var Grades = new Grade[] {
                new Grade { Id = 1, StudentId = 1, CourseName = "Track 302", Value = 99.50F },
                new Grade { Id = 2, StudentId = 2, CourseName = "Track 302", Value = 45.00F },
                new Grade { Id = 3, StudentId = 3, CourseName = "Track 302", Value = 87.25F },
                new Grade { Id = 4, StudentId = 1, CourseName = "Martial Arts 302", Value = 100.00F },
                new Grade { Id = 5, StudentId = 2, CourseName = "Martial Arts 302", Value = 98.99F },
                new Grade { Id = 6, StudentId = 4, CourseName = "Calculus 302", Value = 76.50F },
                new Grade { Id = 7, StudentId = 5, CourseName = "Calculus 302", Value = 88.00F }
            };
            var Students = new Student[] {
                new Student { Id = 1, FirstName = "Barry", LastName = "Allen", Age = 22, Classification = Classification.Freshman},
                new Student { Id = 2, FirstName = "Frank", LastName = "Castle", Age = 42, Classification = Classification.Sophmore},
                new Student { Id = 3, FirstName = "Clark", LastName = "Kent", Age = 29, Classification = Classification.Junior},
                new Student { Id = 4, FirstName = "Bruce", LastName = "Wayne", Age = 39, Classification = Classification.Senior},
                new Student { Id = 5, FirstName = "Gwen", LastName = "Stacy", Age = 19, Classification = Classification.Freshman},
                new Student { Id = 6, FirstName = "Peter", LastName = "Parker", Age = 19, Classification = Classification.Freshman}
            };
            

            modelBuilder.Entity<Student>().HasData(Students);
            modelBuilder.Entity<Grade>().HasData(Grades);
            base.OnModelCreating(modelBuilder);
        }
    }
}