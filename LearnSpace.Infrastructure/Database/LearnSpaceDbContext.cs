﻿using LearnSpace.Infrastructure.Database.Configuration;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnSpace.Infrastructure.Database
{
    public class LearnSpaceDbContext : IdentityDbContext<ApplicationUser>
    {
        public LearnSpaceDbContext(DbContextOptions<LearnSpaceDbContext> options)
                : base(options) 
        {
            Database.EnsureDeleted();  
            Database.EnsureCreated();  
        }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;
        public DbSet<Assignment> Assignments { get; set; } = null!;
        public DbSet<Grade> Grades { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<StudentCourse> StudentsCourses { get; set; } = null!;
        public DbSet<Notification> Notifications { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCourse>()
                   .HasKey(sc => new
                   {
                       sc.StudentId,
                       sc.CourseId
                   });
            builder.Entity<Notification>()
                    .HasOne(n => n.Student)
                    .WithMany() // Assuming no navigation property on Student for Notifications
                    .HasForeignKey(n => n.StudentId)
                    .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            builder.Entity<Notification>()
                    .HasOne(n => n.Teacher)
                    .WithMany() // Assuming no navigation property on Teacher for Notifications
                    .HasForeignKey(n => n.TeacherId)
                    .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
            builder.Entity<Assignment>()
                    .HasOne(a => a.Course)
                    .WithMany(c => c.Assignments)
                    .HasForeignKey(a => a.CourseId)
                    .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
            builder.Entity<StudentCourse>()
                    .HasOne(sc => sc.Student)
                    .WithMany(s => s.StudentCourses)
                    .HasForeignKey(sc => sc.StudentId)
                    .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            builder.Entity<StudentCourse>()
                    .HasOne(sc => sc.Course)
                    .WithMany(c => c.CourseStudents)
                    .HasForeignKey(sc => sc.CourseId)
                    .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete
            builder.Entity<Grade>()
                    .HasOne(g => g.Assignment)
                    .WithMany(a => a.Grades)
                    .HasForeignKey(g => g.AssignmentId)
                    .OnDelete(DeleteBehavior.Restrict); // Prevent cascading delete

            //Seeding

            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new AssignmentConfiguration());
            builder.ApplyConfiguration(new GradeConfiguration());
            builder.ApplyConfiguration(new StudentCourseConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
