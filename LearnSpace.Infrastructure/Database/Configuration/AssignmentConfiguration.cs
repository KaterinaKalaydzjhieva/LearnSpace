using LearnSpace.Infrastructure.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
    {
        public void Configure(EntityTypeBuilder<Assignment> builder)
        {
            builder.HasData(SeedAssignments());
        }

        private static List<Assignment> SeedAssignments() 
        {
            var assignments = new List<Assignment>();

            var assignment = new Assignment()
            { 
                Id = 1,
                Title = "Test 101",
                Description = "I need to make this test which will make 20% of your final score of the year!",
                DueDate = DateTime.Parse("12/12/2024"),
                CourseId = 1,
            };

            assignments.Add(assignment);

            assignment = new Assignment()
            {
                Id = 2,
                Title = "Esey for the middle years",
                Description = "Write a 500 words essey of the theme for the ages around 1400 a. C.",
                DueDate = DateTime.Parse("12/12/2024"),
                CourseId = 3,
            };

            assignments.Add(assignment);

            return assignments;
        }
    }
}
