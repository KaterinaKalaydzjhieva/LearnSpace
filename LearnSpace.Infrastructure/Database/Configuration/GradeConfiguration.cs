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
                StudentId = Guid.Parse("5c07f155-602e-403b-bb86-5a786814f575"),
                AssignmentId = 1
            };

            grades.Add(grade);

            grade = new Grade()
            {
                Id = 2,
                Score = 5,
                DateGraded = DateTime.Now,
                StudentId = Guid.Parse("18e76084-b8a6-4e78-bd26-143f33a05eb8"),
                AssignmentId = 1
            };

            grades.Add(grade);

            grade = new Grade()
            {
                Id = 3,
                Score = 5,
                DateGraded = DateTime.Now,
                StudentId = Guid.Parse("c6903087-71e5-41ba-80be-ed119b7902fc"),
                AssignmentId = 2
            };

            grades.Add(grade);

            grade = new Grade()
            {
                Id = 4,
                Score = 6,
                DateGraded = DateTime.Now,
                StudentId = Guid.Parse("f4aa693d-305e-426b-950c-d02a8ca8b56f"),
                AssignmentId = 2
            };

            grades.Add(grade);

			grade = new Grade()
			{
				Id = 5,
				Score = 5,
				DateGraded = DateTime.Now,
				StudentId = Guid.Parse("5c07f155-602e-403b-bb86-5a786814f575"),
				AssignmentId = 2
			};

			grades.Add(grade);

			return grades;
        }
    }
}
