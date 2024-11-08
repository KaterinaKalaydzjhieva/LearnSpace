using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(SeedStudents());
        }

        private static List<Student> SeedStudents()
        {
            var students = new List<Student>();

            var student = new Student()
            {
                Id = 1,
                UserId = "a52dc824-b577-4862-ac67-29d391116793"
            };

            students.Add(student);

            student = new Student()
            {
                Id = 2,
                UserId = "08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"
            };

            students.Add(student);

            student = new Student()
            {
                Id = 3,
                UserId = "3cc698b0-736e-490a-97e3-3f343bf8bfd8"
            };

            students.Add(student);

            student = new Student()
            {
                Id = 4,
                UserId = "ebdc00b8-7106-4cbd-a482-da93c40103d3"
            };

            students.Add(student);

            return students;
        }
    }
}
