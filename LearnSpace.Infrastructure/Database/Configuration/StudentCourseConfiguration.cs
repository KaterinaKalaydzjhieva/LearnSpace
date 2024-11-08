using LearnSpace.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasData(SeedStudentsCourses());
        }

        private static List<StudentCourse> SeedStudentsCourses() 
        {
            var studentcourses = new List<StudentCourse>();

            var studentcourse = new StudentCourse()
            { 
                CourseId = 1,
                StudentId = 1,
            };

            studentcourses.Add(studentcourse);

            studentcourse = new StudentCourse()
            {
                CourseId = 1,
                StudentId = 2,
            };

            studentcourses.Add(studentcourse);

            studentcourse = new StudentCourse()
            {
                CourseId = 3,
                StudentId = 3,
            };

            studentcourses.Add(studentcourse);

            studentcourse = new StudentCourse()
            {
                CourseId = 3,
                StudentId = 4,
            };

            studentcourses.Add(studentcourse);

            return studentcourses;
        }
    }
}
