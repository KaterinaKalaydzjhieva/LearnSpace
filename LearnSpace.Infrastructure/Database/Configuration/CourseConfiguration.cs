using LearnSpace.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasData(SeedCourses());
        }

        private static List<Course> SeedCourses() 
        {
            var courses = new List<Course>();

            var course = new Course()
            { 
                Id = 1,
                Name = "Geometry",
                Description =  "In this course you can learn the basic concepts of the 3D world with Math. Learn Geometry today!",
                TeacherId = Guid.Parse("5e846435-c18b-4df9-b4a2-b6d9d0414694")
            };

            courses.Add(course);

            course = new Course()
            {
                Id = 2,
                Name = "Algebra",
                Description = "In this course you can learn the basic concepts of numbers around us. Learn Algebra today!",
                TeacherId = Guid.Parse("5e846435-c18b-4df9-b4a2-b6d9d0414694")
            };

            courses.Add(course);

            course = new Course()
            {
                Id = 3,
                Name = "Nationalism",
                Description = "In this course you can learn how is a nationality formed and passed to the next generations. Learn Geometry today!",
                TeacherId = Guid.Parse("047e49c7-8466-4419-88e3-1b6f7107d247")
            };

            courses.Add(course);

            return courses;
        }
    }
}
