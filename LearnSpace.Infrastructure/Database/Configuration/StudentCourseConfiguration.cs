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
                StudentId = Guid.Parse("5c07f155-602e-403b-bb86-5a786814f575"),
            };

            studentcourses.Add(studentcourse);

            studentcourse = new StudentCourse()
            {
                CourseId = 1,
                StudentId = Guid.Parse("18e76084-b8a6-4e78-bd26-143f33a05eb8"),
            };

            studentcourses.Add(studentcourse);

            studentcourse = new StudentCourse()
            {
                CourseId = 3,
                StudentId = Guid.Parse("c6903087-71e5-41ba-80be-ed119b7902fc"),
            };

            studentcourses.Add(studentcourse);

            studentcourse = new StudentCourse()
            {
                CourseId = 3,
                StudentId = Guid.Parse("f4aa693d-305e-426b-950c-d02a8ca8b56f"),
            };

            studentcourses.Add(studentcourse);

            return studentcourses;
        }
    }
}
