﻿// <auto-generated />
using System;
using LearnSpace.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    [DbContext(typeof(LearnSpaceDbContext))]
    [Migration("20241120192916_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.35")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "acf416e4-a540-4bde-a18e-07a249e144b8",
                            DateOfBirth = new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "admin@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Admin",
                            LastName = "Adminov",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@ABV.BG",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEHvwuBNPXGHDehwStciqt6zmLe9AfTBD6pT3rjpVbqYDN6jwJsD/l7y8sHMERYqNmA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2638293a-a872-40ab-8144-d1d9ce93f9ac",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c7ca3ee9-61da-4610-94c1-64c920c36ca9",
                            DateOfBirth = new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "teacher1@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Ivan",
                            LastName = "Ivanov",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEACHER1@ABV.BG",
                            NormalizedUserName = "TEACHER1",
                            PasswordHash = "AQAAAAEAACcQAAAAEKScOWemmuwkqOUNXiKytHZxE8QbcVOSJjOBcO6CF+7B5QSBETu1ea56TeYvgMoX0Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "8a8ddba1-9a87-4b0d-bc98-8fe78348aff0",
                            TwoFactorEnabled = false,
                            UserName = "teacher1"
                        },
                        new
                        {
                            Id = new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8a7eff8f-7d69-47c6-a969-b1699c27b904",
                            DateOfBirth = new DateTime(1982, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "teacher2@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Grigor",
                            LastName = "Georgiev",
                            LockoutEnabled = false,
                            NormalizedEmail = "TEACHER2@ABV.BG",
                            NormalizedUserName = "TEACHER2",
                            PasswordHash = "AQAAAAEAACcQAAAAEPMCUJ2hGaQNUEA90Z61/j1LvNvgQk03HUNjusAYs5NSf47bEfYi+vphUUJDbB01fQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "d5ae5f94-af35-4c96-b93f-714b144252ba",
                            TwoFactorEnabled = false,
                            UserName = "teacher2"
                        },
                        new
                        {
                            Id = new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7639a27c-391c-44f2-a0a6-4e6351e555cc",
                            DateOfBirth = new DateTime(2005, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "student1@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Vladislav",
                            LastName = "Popov",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT1@ABV.BG",
                            NormalizedUserName = "STUDENT1",
                            PasswordHash = "AQAAAAEAACcQAAAAEKyjOnYSevZ9eHu1BLSZaUsBT+jgTC2wOt+zdEb4Wx+6mCbIoj24a8UZ8eTDRoK4og==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "56f70534-74ce-40c1-90d2-cb7c1220bd55",
                            TwoFactorEnabled = false,
                            UserName = "student1"
                        },
                        new
                        {
                            Id = new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "80c7fc35-1312-42ac-958b-5a25c9f83edb",
                            DateOfBirth = new DateTime(2006, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "student2@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Diana",
                            LastName = "Atanasova",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT2@ABV.BG",
                            NormalizedUserName = "STUDENT2",
                            PasswordHash = "AQAAAAEAACcQAAAAEJwOlcd36eYJv03CMvxmsS+Lh+Xie6Yu8/kpjhCISw51qt/R7whfa4TU+Zee/5xU7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4bdf9117-a797-49ad-8922-bf2a0716f095",
                            TwoFactorEnabled = false,
                            UserName = "student2"
                        },
                        new
                        {
                            Id = new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2624e144-abfc-4941-8882-6e027860ee7b",
                            DateOfBirth = new DateTime(2005, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "student3@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Ema",
                            LastName = "Ivanova",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT3@ABV.BG",
                            NormalizedUserName = "STUDENT3",
                            PasswordHash = "AQAAAAEAACcQAAAAENtFsGA3DyyyGlZL0Gc7idij9r0gR8capU/Iz0wJw1iMHGF6f2gKzQj0uG6INr6+/g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5df0b586-3a03-4fb0-b826-51c425b6ee8b",
                            TwoFactorEnabled = false,
                            UserName = "student3"
                        },
                        new
                        {
                            Id = new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c805dc10-5530-4dbc-815b-ed3d649ad8c6",
                            DateOfBirth = new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "student4@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "Alex",
                            LastName = "Georgiev",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT4@ABV.BG",
                            NormalizedUserName = "STUDENT4",
                            PasswordHash = "AQAAAAEAACcQAAAAEMR08UtgqkGsRD/SEDbnGKulrsjF2nlR8UoYmP7Wm0KNjncVMfGIBsDTWYcQMvPy9A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "4cd5f5ba-53cd-4c5f-869b-554e3d33b689",
                            TwoFactorEnabled = false,
                            UserName = "student4"
                        });
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique();

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5c07f155-602e-403b-bb86-5a786814f575"),
                            ApplicationUserId = new Guid("a52dc824-b577-4862-ac67-29d391116793")
                        },
                        new
                        {
                            Id = new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8"),
                            ApplicationUserId = new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6")
                        },
                        new
                        {
                            Id = new Guid("c6903087-71e5-41ba-80be-ed119b7902fc"),
                            ApplicationUserId = new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8")
                        },
                        new
                        {
                            Id = new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f"),
                            ApplicationUserId = new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3")
                        });
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SubjectSpecialization")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694"),
                            ApplicationUserId = new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                            SubjectSpecialization = "Math"
                        },
                        new
                        {
                            Id = new Guid("047e49c7-8466-4419-88e3-1b6f7107d247"),
                            ApplicationUserId = new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                            SubjectSpecialization = "History"
                        });
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Assignment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Assignments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Description = "I need to make this test which will make 20% of your final score of the year!",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Test 101"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 3,
                            Description = "Write a 500 words essey of the theme for the ages around 1400 a. C.",
                            DueDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Esey for the middle years"
                        });
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "In this course you can learn the basic concepts of the 3D world with Math. Learn Geometry today!",
                            Name = "Geometry",
                            TeacherId = new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694")
                        },
                        new
                        {
                            Id = 2,
                            Description = "In this course you can learn the basic concepts of numbers around us. Learn Algebra today!",
                            Name = "Algebra",
                            TeacherId = new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694")
                        },
                        new
                        {
                            Id = 3,
                            Description = "In this course you can learn how is a nationality formed and passed to the next generations. Learn Geometry today!",
                            Name = "Nationalism",
                            TeacherId = new Guid("047e49c7-8466-4419-88e3-1b6f7107d247")
                        });
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AssignmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateGraded")
                        .HasColumnType("datetime2");

                    b.Property<double>("Score")
                        .HasColumnType("float");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AssignmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("Grades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AssignmentId = 1,
                            DateGraded = new DateTime(2024, 11, 20, 21, 29, 15, 911, DateTimeKind.Local).AddTicks(1547),
                            Score = 4.0,
                            StudentId = new Guid("5c07f155-602e-403b-bb86-5a786814f575")
                        },
                        new
                        {
                            Id = 2,
                            AssignmentId = 1,
                            DateGraded = new DateTime(2024, 11, 20, 21, 29, 15, 911, DateTimeKind.Local).AddTicks(1584),
                            Score = 5.0,
                            StudentId = new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8")
                        },
                        new
                        {
                            Id = 3,
                            AssignmentId = 2,
                            DateGraded = new DateTime(2024, 11, 20, 21, 29, 15, 911, DateTimeKind.Local).AddTicks(1587),
                            Score = 5.0,
                            StudentId = new Guid("c6903087-71e5-41ba-80be-ed119b7902fc")
                        },
                        new
                        {
                            Id = 4,
                            AssignmentId = 2,
                            DateGraded = new DateTime(2024, 11, 20, 21, 29, 15, 911, DateTimeKind.Local).AddTicks(1589),
                            Score = 6.0,
                            StudentId = new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f")
                        },
                        new
                        {
                            Id = 5,
                            AssignmentId = 2,
                            DateGraded = new DateTime(2024, 11, 20, 21, 29, 15, 911, DateTimeKind.Local).AddTicks(1592),
                            Score = 5.0,
                            StudentId = new Guid("5c07f155-602e-403b-bb86-5a786814f575")
                        });
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<Guid?>("ApplicationUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateSent")
                        .HasColumnType("datetime2");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("StudentId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.StudentCourse", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentsCourses");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("5c07f155-602e-403b-bb86-5a786814f575"),
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8"),
                            CourseId = 1
                        },
                        new
                        {
                            StudentId = new Guid("c6903087-71e5-41ba-80be-ed119b7902fc"),
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f"),
                            CourseId = 3
                        },
                        new
                        {
                            StudentId = new Guid("5c07f155-602e-403b-bb86-5a786814f575"),
                            CourseId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.Student", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", "ApplicationUser")
                        .WithOne("Student")
                        .HasForeignKey("LearnSpace.Infrastructure.Database.Entities.Account.Student", "ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.Teacher", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Assignment", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Course", "Course")
                        .WithMany("Assignments")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.Teacher", null)
                        .WithMany("Assignments")
                        .HasForeignKey("TeacherId");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Course", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.Teacher", "Teacher")
                        .WithMany("Courses")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Grade", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Assignment", "Assignment")
                        .WithMany("Grades")
                        .HasForeignKey("AssignmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.Student", "Student")
                        .WithMany("Grades")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignment");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Notification", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", null)
                        .WithMany("Notifications")
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.StudentCourse", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Course", "Course")
                        .WithMany("CourseStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.ApplicationUser", b =>
                {
                    b.Navigation("Notifications");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.Student", b =>
                {
                    b.Navigation("Grades");

                    b.Navigation("StudentCourses");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Account.Teacher", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("Courses");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Assignment", b =>
                {
                    b.Navigation("Grades");
                });

            modelBuilder.Entity("LearnSpace.Infrastructure.Database.Entities.Course", b =>
                {
                    b.Navigation("Assignments");

                    b.Navigation("CourseStudents");
                });
#pragma warning restore 612, 618
        }
    }
}