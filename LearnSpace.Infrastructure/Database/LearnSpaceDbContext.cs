using LearnSpace.Infrastructure.Database.Configuration;
using LearnSpace.Infrastructure.Database.Entities;
using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearnSpace.Infrastructure.Database
{
    public class LearnSpaceDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public LearnSpaceDbContext(DbContextOptions<LearnSpaceDbContext> options)
        : base(options) { }

        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<Assignment> Assignments { get; set; } = null!;
        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<StudentCourse> StudentsCourses { get; set; } = null!;
        public virtual DbSet<Submission> Submissions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCourse>()
                   .HasKey(sc => new
                   {
                       sc.StudentId,
                       sc.CourseId
                   });
            //Courses
            builder.Entity<Course>()
                   .HasMany(c=>c.Assignments)
                   .WithOne(a=>a.Course)
                   .HasForeignKey(a=>a.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Course>()
                   .HasMany(c => c.Grades)
                   .WithOne(g => g.Course)
                   .HasForeignKey(g => g.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Course>()
                   .HasMany(c => c.CourseStudents)
                   .WithOne(cs => cs.Course)
                   .HasForeignKey(cs => cs.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Assignments
            builder.Entity<Assignment>()
                   .HasOne(a => a.Course)
                   .WithMany(c => c.Assignments)
                   .HasForeignKey(a => a.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            // Submissions
            builder.Entity<Submission>()
                   .HasOne(s => s.Assignment)
                   .WithMany(a => a.Submissions)
                   .HasForeignKey(s => s.AssignmentId)
                   .OnDelete(DeleteBehavior.Restrict);

            // StudentCourse
            builder.Entity<StudentCourse>()
                   .HasOne(sc => sc.Student)
                   .WithMany(s => s.StudentCourses)
                   .HasForeignKey(sc => sc.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<StudentCourse>()
                   .HasOne(sc => sc.Course)
                   .WithMany(c => c.CourseStudents)
                   .HasForeignKey(sc => sc.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            // ApplicationUser
            builder.Entity<ApplicationUser>()
                   .HasOne(u => u.Student)
                   .WithOne(s => s.ApplicationUser)
                   .HasForeignKey<Student>(s => s.ApplicationUserId);

            // Grades
            builder.Entity<Grade>()
                   .HasOne(g => g.Course)
                   .WithMany(c => c.Grades)
                   .HasForeignKey(g => g.CourseId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Grade>()
                   .HasOne(g => g.Student)
                   .WithMany(s => s.Grades)
                   .HasForeignKey(g => g.StudentId)
                   .OnDelete(DeleteBehavior.Restrict);

            //Seeding

            builder.ApplyConfiguration(new ApplicationUserConfiguration());
            builder.ApplyConfiguration(new TeacherConfiguration());
            builder.ApplyConfiguration(new StudentConfiguration());
            builder.ApplyConfiguration(new CourseConfiguration());
            builder.ApplyConfiguration(new StudentCourseConfiguration());
            builder.ApplyConfiguration(new AssignmentConfiguration());
            builder.ApplyConfiguration(new SubmissionConfiguration());
            builder.ApplyConfiguration(new GradeConfiguration());

            base.OnModelCreating(builder);
        }

    }
}
