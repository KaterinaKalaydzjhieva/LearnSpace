﻿using LearnSpace.Infrastructure.Database.Entities.Account;
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
            //Admin (1)
                new ApplicationUser
                {
                    Id = "2d522f0f-1d26-429e-8bef-0098f10d96e9",
                    UserName = "Admin",
                    Email = "admin@abv.bg",
                    NormalizedEmail = "ADMIN@ABV.BG",
                    FirstName = "Admin",
                    LastName = "Adminov",
                    DateOfBirth = new DateTime(1980, 5, 10),
                },
            // Teachers (2)
                new ApplicationUser
                {
                    Id = "bdc70ff8-a02a-428f-ad1c-b5ba645a45e1",
                    UserName = "teacher1",
                    Email = "teacher1@abv.bg",
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    DateOfBirth = new DateTime(1980, 5, 10),
                },
                new ApplicationUser
                {
                    Id = "bc5f8df5-6115-4344-897b-73e185df4bff",
                    UserName = "teacher2",
                    Email = "teacher2@abv.bg",
                    FirstName = "Grigor",
                    LastName = "Georgiev",
                    DateOfBirth = new DateTime(1982, 8, 21),
                },
            
            // Students (4)
                new ApplicationUser
                {
                    Id = "a52dc824-b577-4862-ac67-29d391116793",
                    UserName = "student1",
                    Email = "student1@abv.bg",
                    FirstName = "Vladislav",
                    LastName = "Popov",
                    DateOfBirth = new DateTime(2005, 3, 14),
                },
                new ApplicationUser
                {
                    Id = "08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6",
                    UserName = "student2",
                    Email = "student2@abv.bg",
                    FirstName = "Diana",
                    LastName = "Atanasova",
                    DateOfBirth = new DateTime(2006, 7, 19),
                },
                new ApplicationUser
                {
                    Id = "3cc698b0-736e-490a-97e3-3f343bf8bfd8",
                    UserName = "student3",
                    Email = "student3@abv.bg",
                    FirstName = "Ema",
                    LastName = "Ivanova",
                    DateOfBirth = new DateTime(2005, 10, 22),
                },
                new ApplicationUser
                {
                    Id = "ebdc00b8-7106-4cbd-a482-da93c40103d3",
                    UserName = "student4",
                    Email = "student4@abv.bg",
                    FirstName = "Alex",
                    LastName = "Georgiev",
                    DateOfBirth = new DateTime(2006, 2, 3),
                }
            };

            return list;
        }
    }
}
