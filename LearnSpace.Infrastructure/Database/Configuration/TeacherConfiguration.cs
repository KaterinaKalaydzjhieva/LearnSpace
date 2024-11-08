using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasData(SeedStudents());
        }

        private static List<Teacher> SeedStudents() 
        {
            var teachers = new List<Teacher>();

            var teacher = new Teacher()
            { 
                Id = 1,
                SubjectSpecialization = "Math",
                UserId = "bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"
            };

            teachers.Add(teacher);

            teacher = new Teacher()
            {
                Id = 2,
                SubjectSpecialization = "History",
                UserId = "bc5f8df5-6115-4344-897b-73e185df4bff"
            };

            teachers.Add(teacher);

            return teachers;
        }
    }
}
