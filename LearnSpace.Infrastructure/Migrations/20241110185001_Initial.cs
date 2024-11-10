using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubjectSpecialization = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teachers_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DateSent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ApplicationUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    TeacherId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assignments_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assignments_Teachers_TeacherId",
                        column: x => x.TeacherId,
                        principalTable: "Teachers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentsCourses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsCourses", x => new { x.StudentId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsCourses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<double>(type: "float", nullable: false),
                    DateGraded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"), 0, "b2f7ff1e-86ea-47be-a001-0756b19138c4", new DateTime(2006, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "student2@abv.bg", false, "Diana", "Atanasova", false, null, "STUDENT2@ABV.BG", "STUDENT2", "AQAAAAEAACcQAAAAEJaDhYavdto5Sx53YnJGBIoAK9bNIivaRHvqvl2cvzNZGtiGXok9uDUu4L5JlEnHJQ==", null, false, "e1011a6d-999c-418c-bcd2-926724047492", false, "student2" },
                    { new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"), 0, "73c3936e-58a2-4ca0-a29e-dd5858ac5df0", new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@abv.bg", false, "Admin", "Adminov", false, null, "ADMIN@ABV.BG", "ADMIN", "AQAAAAEAACcQAAAAEO+uIIxyh2QBPy6s2QowLLY4hyXHaudX0MeHKs8wwP7L4nkgakTfXNw98ICGN43e1g==", null, false, "067dc83e-899c-41ae-b60e-6f1eb88c1eda", false, "Admin" },
                    { new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"), 0, "2302580d-41a8-4882-8fe4-fb19cc308868", new DateTime(2005, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "student3@abv.bg", false, "Ema", "Ivanova", false, null, "STUDENT3@ABV.BG", "STUDENT3", "AQAAAAEAACcQAAAAEL6/+FtAxpNEeDIWV16NutpwPQmcJw6zx6NT65Y0NP+BFCNzL2vfpUoSy5GrY9ryYA==", null, false, "43c28a83-4516-419a-afbf-2dedc1f456e2", false, "student3" },
                    { new Guid("a52dc824-b577-4862-ac67-29d391116793"), 0, "e41196f9-44e5-48a9-8ba5-ac72a55c708f", new DateTime(2005, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "student1@abv.bg", false, "Vladislav", "Popov", false, null, "STUDENT1@ABV.BG", "STUDENT1", "AQAAAAEAACcQAAAAEKA4kYWcWjwUEdm+RjBHNAsauUT7e84PS+jTbltuSnm23L8mtuTqMHvlFcr5cj6Akg==", null, false, "090cd876-c03d-429c-9706-6c458fbafbef", false, "student1" },
                    { new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"), 0, "f81651c2-5b0d-4780-97ed-3495a2236a2a", new DateTime(1982, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "teacher2@abv.bg", false, "Grigor", "Georgiev", false, null, "TEACHER2@ABV.BG", "TEACHER2", "AQAAAAEAACcQAAAAECtt5pKgKASgt2ma4YIgxDUTT8brar4xc0CTvjTFhTBKsesyc2bl50rryFc1Icwk9w==", null, false, "9ba80610-e5a6-4833-95b4-25812a017339", false, "teacher2" },
                    { new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"), 0, "6470742d-8820-410a-8f98-8b509f559e30", new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "teacher1@abv.bg", false, "Ivan", "Ivanov", false, null, "TEACHER1@ABV.BG", "TEACHER1", "AQAAAAEAACcQAAAAEGvUvSOe+BUEUeX8RcbzsR5gT0qg0D7SNLQpI8oUq9WX59/D4/GC05SPMervvH0NSw==", null, false, "e6866dee-8b17-4449-acfe-e4eba69ae9b5", false, "teacher1" },
                    { new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"), 0, "7aa18aaf-5378-4213-b7d2-b571aec12893", new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "student4@abv.bg", false, "Alex", "Georgiev", false, null, "STUDENT4@ABV.BG", "STUDENT4", "AQAAAAEAACcQAAAAEBfwcsioShDArAGe8nsCNmwlOf+bm5Q/kkWeXicUELlOtt12WY2o6RSkwOAOyg2Vtw==", null, false, "fb7c83c9-d985-45fd-b0b0-1b208fcdeb46", false, "student4" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8"), new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6") },
                    { new Guid("5c07f155-602e-403b-bb86-5a786814f575"), new Guid("a52dc824-b577-4862-ac67-29d391116793") },
                    { new Guid("c6903087-71e5-41ba-80be-ed119b7902fc"), new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8") },
                    { new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f"), new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3") }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "ApplicationUserId", "SubjectSpecialization" },
                values: new object[,]
                {
                    { new Guid("047e49c7-8466-4419-88e3-1b6f7107d247"), new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"), "History" },
                    { new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694"), new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"), "Math" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name", "TeacherId" },
                values: new object[] { 1, "In this course you can learn the basic concepts of the 3D world with Math. Learn Geometry today!", "Geometry", new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name", "TeacherId" },
                values: new object[] { 2, "In this course you can learn the basic concepts of numbers around us. Learn Algebra today!", "Algebra", new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694") });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Name", "TeacherId" },
                values: new object[] { 3, "In this course you can learn how is a nationality formed and passed to the next generations. Learn Geometry today!", "Nationalism", new Guid("047e49c7-8466-4419-88e3-1b6f7107d247") });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CourseId", "Description", "DueDate", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "I need to make this test which will make 20% of your final score of the year!", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Test 101" },
                    { 2, 3, "Write a 500 words essey of the theme for the ages around 1400 a. C.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Esey for the middle years" }
                });

            migrationBuilder.InsertData(
                table: "StudentsCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 1, new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8") },
                    { 1, new Guid("5c07f155-602e-403b-bb86-5a786814f575") },
                    { 3, new Guid("c6903087-71e5-41ba-80be-ed119b7902fc") },
                    { 3, new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f") }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "AssignmentId", "DateGraded", "Score", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 11, 10, 20, 50, 1, 216, DateTimeKind.Local).AddTicks(360), 4.0, new Guid("5c07f155-602e-403b-bb86-5a786814f575") },
                    { 2, 1, new DateTime(2024, 11, 10, 20, 50, 1, 216, DateTimeKind.Local).AddTicks(393), 5.0, new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8") },
                    { 3, 2, new DateTime(2024, 11, 10, 20, 50, 1, 216, DateTimeKind.Local).AddTicks(396), 5.0, new Guid("c6903087-71e5-41ba-80be-ed119b7902fc") },
                    { 4, 2, new DateTime(2024, 11, 10, 20, 50, 1, 216, DateTimeKind.Local).AddTicks(398), 6.0, new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_CourseId",
                table: "Assignments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Assignments_TeacherId",
                table: "Assignments",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TeacherId",
                table: "Courses",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_AssignmentId",
                table: "Grades",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Grades_StudentId",
                table: "Grades",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ApplicationUserId",
                table: "Notifications",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_StudentId",
                table: "Notifications",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_TeacherId",
                table: "Notifications",
                column: "TeacherId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ApplicationUserId",
                table: "Students",
                column: "ApplicationUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentsCourses_CourseId",
                table: "StudentsCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ApplicationUserId",
                table: "Teachers",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "StudentsCourses");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Assignments");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
