using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
           // builder.HasData(SeedStudents());
        }

        //private static List<Student> SeedStudents()
        //{
        //    return new List<Student>
        //{
        //    new Student { Id = 1, ApplicationUserId = 3 },  // Linking to Charlie Clark
        //    new Student { Id = 2, ApplicationUserId = 4 },  // Linking to Dana Davis
        //    new Student { Id = 3, ApplicationUserId = 5 },  // Linking to Evan Evans
        //    new Student { Id = 4, ApplicationUserId = 6 }   // Linking to Fiona Frank
        //};
        //}
    }
}
