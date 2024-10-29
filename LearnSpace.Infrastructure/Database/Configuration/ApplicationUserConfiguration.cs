using LearnSpace.Infrastructure.Database.Entities.Account;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnSpace.Infrastructure.Database.Configuration
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(SeedApplicationUsers());
        }

        private static List<ApplicationUser> SeedApplicationUsers()
        {
            var list = new List<ApplicationUser>
            {
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Admin",
                Email = "admin@abv.bg",
                NormalizedEmail = "ADMIN@ABV.BG",
                FirstName = "Admin",
                LastName = "Adminov",
                DateOfBirth = new DateTime(1980, 5, 10),
            },
            // Teachers
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "teacher1",
                Email = "teacher1@example.com",
                FirstName = "Alice",
                LastName = "Anderson",
                DateOfBirth = new DateTime(1980, 5, 10),
            },
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "teacher2",
                Email = "teacher2@example.com",
                FirstName = "Bob",
                LastName = "Brown",
                DateOfBirth = new DateTime(1982, 8, 21),
            },
            
            // Students
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "student1",
                Email = "student1@example.com",
                FirstName = "Charlie",
                LastName = "Clark",
                DateOfBirth = new DateTime(2005, 3, 14),
            },
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "student2",
                Email = "student2@example.com",
                FirstName = "Dana",
                LastName = "Davis",
                DateOfBirth = new DateTime(2006, 7, 19),
            },
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "student3",
                Email = "student3@example.com",
                FirstName = "Evan",
                LastName = "Evans",
                DateOfBirth = new DateTime(2005, 10, 22),
            },
            new ApplicationUser
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "student4",
                Email = "student4@example.com",
                FirstName = "Fiona",
                LastName = "Frank",
                DateOfBirth = new DateTime(2006, 2, 3),
            }
            };

            return list;
        }
    }
}
