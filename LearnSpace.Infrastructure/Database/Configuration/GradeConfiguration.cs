using LearnSpace.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasData(SeedGrades());
        }

        private static List<Grade> SeedGrades() 
        {
            var grades = new List<Grade>();

            var grade = new Grade() 
            {
                Id = 1,
                Score = 4,
                DateGraded = DateTime.Now,
                StudentId = 1,
                AssignmentId = 1
            };

            grades.Add(grade);

            grade = new Grade()
            {
                Id = 2,
                Score = 5,
                DateGraded = DateTime.Now,
                StudentId = 2,
                AssignmentId = 1
            };

            grades.Add(grade);

            grade = new Grade()
            {
                Id = 3,
                Score = 5,
                DateGraded = DateTime.Now,
                StudentId = 3,
                AssignmentId = 2
            };

            grades.Add(grade);

            grade = new Grade()
            {
                Id = 4,
                Score = 6,
                DateGraded = DateTime.Now,
                StudentId = 4,
                AssignmentId = 2
            };

            grades.Add(grade);

            return grades;
        }
    }
}
