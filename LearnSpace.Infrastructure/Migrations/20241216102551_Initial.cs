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
                    GroupCapacity = table.Column<int>(type: "int", nullable: false),
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
                name: "Grades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateGraded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Grades_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Grades_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Submissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssignmentId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileContent = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SubmittedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Submissions_Assignments_AssignmentId",
                        column: x => x.AssignmentId,
                        principalTable: "Assignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Submissions_Students_StudentId",
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
                    { new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"), 0, "11be327e-894c-4408-8b66-387331e1738e", new DateTime(2006, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "student2@abv.bg", false, "Diana", "Atanasova", false, null, "STUDENT2@ABV.BG", "STUDENT2", "AQAAAAEAACcQAAAAELwHGfXY4AnMo9lWzE8GbF8vcSn2Ic9qrl//cI1E7bR1xOaMK+gZEUKORQ3i4rTlhw==", null, false, "08e84abe-6525-4538-845a-21c38f2c618f", false, "student2" },
                    { new Guid("267a7709-17b4-413c-9026-a6f365d59731"), 0, "c2e40334-5bd7-459a-a99c-b8807130f311", new DateTime(2006, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "student5@abv.bg", false, "Lili", "Samardjieva", false, null, "STUDENT5@ABV.BG", "STUDENT5", "AQAAAAEAACcQAAAAEOhL14MSTZ1cQBJIsO/YJPVD9RD5G9F3htZrkoe73LgtSE8nyeVATXtVZOCURUA0pA==", null, false, "d5b52fbc-4ee4-45d2-ada4-4a6f2b94258a", false, "student5" },
                    { new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"), 0, "61b66895-b2b5-449e-8730-e82513bce608", new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@abv.bg", false, "Admin", "Adminov", false, null, "ADMIN@ABV.BG", "ADMIN", "AQAAAAEAACcQAAAAEID4V7txnjSfNMhh1pJfcFIM+ydDypCJVi/VUmG6CoVZ/monFMn97YU5/hmW/T39EA==", null, false, "b2c874a2-8d61-4c69-87ed-d8f3ffd8ba4e", false, "Admin" },
                    { new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"), 0, "7e30d81d-192e-4727-8d0b-52c34b97cd9e", new DateTime(2005, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "student3@abv.bg", false, "Ema", "Ivanova", false, null, "STUDENT3@ABV.BG", "STUDENT3", "AQAAAAEAACcQAAAAECSuM0pRQmftdzdzVyJsNQ6kJI+cRaN/TNyA6gOxvcFu4Ob2yxQw+Lvt8IdGl6wL/Q==", null, false, "40e8c2d5-36ee-4855-a170-6263d3af5d51", false, "student3" },
                    { new Guid("a52dc824-b577-4862-ac67-29d391116793"), 0, "07d5690f-b11d-4d92-9a78-f9c1016bee29", new DateTime(2005, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "student1@abv.bg", false, "Vladislav", "Popov", false, null, "STUDENT1@ABV.BG", "STUDENT1", "AQAAAAEAACcQAAAAEPQHygINIiRAUpAdtivgAUrydEzA2GphhriT0Ij4wMc+xBffXOrhJT6cDcb9lqRsAw==", null, false, "68e8a96a-7b4a-45c9-a365-f5e3a3b92ec7", false, "student1" },
                    { new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"), 0, "8dec1b99-3765-42ea-b4dc-2b609048ba7e", new DateTime(1982, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "teacher2@abv.bg", false, "Grigor", "Georgiev", false, null, "TEACHER2@ABV.BG", "TEACHER2", "AQAAAAEAACcQAAAAEMh2ffDKeOj87T1QW72zxzpsrelDA5iF27iYYRkl4+a08xjf4dTImd70zT0ZoKEk8g==", null, false, "4ea73919-4923-4061-9d01-cc4b1fbe55d4", false, "teacher2" },
                    { new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"), 0, "51719789-61d5-479f-8c92-586c13e79fba", new DateTime(1980, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "teacher1@abv.bg", false, "Ivan", "Ivanov", false, null, "TEACHER1@ABV.BG", "TEACHER1", "AQAAAAEAACcQAAAAEAyq7Y5Pn+usCXmwUZY6R4s472YGmCq0vjneFyWRhfixO29pzbVrBnR0G0H1ACUrZQ==", null, false, "69ef1fd1-32b5-424d-bd39-88c14bf3547e", false, "teacher1" },
                    { new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"), 0, "3e0ff6c2-9796-4d78-affc-e2e5d07a1f57", new DateTime(2006, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "student4@abv.bg", false, "Alex", "Georgiev", false, null, "STUDENT4@ABV.BG", "STUDENT4", "AQAAAAEAACcQAAAAEFRbWN0k7h5jcUIew8XnLzlD2pL61hKjcdOLqtQE+sm+OjQtnuyYCn4i64xrNQS4Ng==", null, false, "49b03303-c710-453c-88ee-ab19b1891b56", false, "student4" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ApplicationUserId" },
                values: new object[,]
                {
                    { new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8"), new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6") },
                    { new Guid("5c07f155-602e-403b-bb86-5a786814f575"), new Guid("a52dc824-b577-4862-ac67-29d391116793") },
                    { new Guid("bb5432a1-ea56-450b-9db6-f7349faf28a6"), new Guid("267a7709-17b4-413c-9026-a6f365d59731") },
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
                columns: new[] { "Id", "Description", "GroupCapacity", "Name", "TeacherId" },
                values: new object[,]
                {
                    { 1, "In this course you can learn the basic concepts of the 3D world with Math. Learn Geometry today!", 20, "Geometry", new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694") },
                    { 2, "In this course you can learn the basic concepts of numbers around us. Learn Algebra today!", 25, "Algebra", new Guid("5e846435-c18b-4df9-b4a2-b6d9d0414694") },
                    { 3, "In this course you can learn how the new empires are formed and passed to the next generations. Join us!", 20, "Modern History", new Guid("047e49c7-8466-4419-88e3-1b6f7107d247") },
                    { 4, "In this course you can learn how the people in the ancient times have lived. Interested? Let's learn together!", 30, "Ancient History", new Guid("047e49c7-8466-4419-88e3-1b6f7107d247") },
                    { 5, "In this course you can learn how hard were the middle ages and why they are important. Join today!", 20, "Middle Ages", new Guid("047e49c7-8466-4419-88e3-1b6f7107d247") }
                });

            migrationBuilder.InsertData(
                table: "Assignments",
                columns: new[] { "Id", "CourseId", "Description", "DueDate", "TeacherId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Test your understanding of the core concepts of geometry, including identifying shapes, calculating angles, and writing geometric proofs. This assessment covers both basic and advanced topics to challenge your spatial reasoning and problem-solving skills.", new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Geometric Foundations: Shapes, Angles, and Proofs" },
                    { 2, 1, "This test focuses on applying geometric theorems to calculate areas, volumes, and properties of 2D and 3D shapes. Ideal for students ready to showcase their analytical abilities and mastery of geometric principles.", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Geometry Challenge: Area, Volume, and Theorems" },
                    { 3, 2, "Test your mastery of foundational algebra concepts, including solving equations, working with inequalities, and graphing linear and quadratic functions. Perfect for sharpening your analytical and computational skills.", new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Algebra Essentials: Equations, Inequalities, and Graphs" },
                    { 4, 2, "Put your algebra knowledge to the test with questions covering systems of equations, polynomial operations, and real-world applications. Designed to evaluate both theoretical understanding and practical problem-solving ability.", new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Algebra in Action: Systems, Polynomials, and Word Problems" },
                    { 5, 3, "Assess your understanding of key events in modern history, from political revolutions to world wars and the social transformations that shaped the 19th and 20th centuries. Test your knowledge of causes, consequences, and global impacts.", new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Modern History Milestones: Revolutions, Wars, and Transformations" },
                    { 6, 3, "Examine pivotal events and trends of the 20th century, from world wars to the civil rights movement and globalization. This test evaluates your understanding of historical causes, key figures, and lasting legacies.", new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Twentieth Century: Conflict, Progress, and Globalization" },
                    { 7, 4, "Explore the rise and fall of ancient civilizations, from Mesopotamia to Rome. This test covers key developments in governance, culture, and innovation that shaped early human history.", new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ancient Civilizations: Foundations of the Modern World" },
                    { 8, 4, "Dive into the fascinating world of ancient empires, legendary battles, and enduring myths. This assessment evaluates your knowledge of ancient societies, their achievements, and their lasting influence on humanity.", new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Empires and Myths: A Journey Through Ancient History" },
                    { 9, 5, "Test your knowledge of the medieval period, from the structure of feudal society to the influence of the Church and the everyday lives of people in the Middle Ages. Explore the events and ideas that defined this era.", new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The Middle Ages: Feudalism, Faith, and Fiefdoms" },
                    { 10, 5, "This test examines the major events and themes of the Middle Ages, including the Crusades, the growth of monarchies, and the cultural and intellectual achievements that emerged from this dynamic period.", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Medieval History: Crusades, Kingdoms, and Culture" }
                });

            migrationBuilder.InsertData(
                table: "Grades",
                columns: new[] { "Id", "CourseId", "DateGraded", "Description", "Score", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(5977), "You can do more.", 4.0, new Guid("5c07f155-602e-403b-bb86-5a786814f575") },
                    { 2, 2, new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6016), "You can do more.", 3.0, new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8") },
                    { 3, 3, new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6021), "You can do more.", 5.0, new Guid("c6903087-71e5-41ba-80be-ed119b7902fc") },
                    { 4, 4, new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6025), "You can do more.", 6.0, new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f") },
                    { 5, 5, new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6029), "You can do more.", 6.0, new Guid("bb5432a1-ea56-450b-9db6-f7349faf28a6") }
                });

            migrationBuilder.InsertData(
                table: "StudentsCourses",
                columns: new[] { "CourseId", "StudentId" },
                values: new object[,]
                {
                    { 2, new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8") },
                    { 3, new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8") },
                    { 1, new Guid("5c07f155-602e-403b-bb86-5a786814f575") },
                    { 2, new Guid("5c07f155-602e-403b-bb86-5a786814f575") },
                    { 1, new Guid("bb5432a1-ea56-450b-9db6-f7349faf28a6") },
                    { 5, new Guid("bb5432a1-ea56-450b-9db6-f7349faf28a6") },
                    { 3, new Guid("c6903087-71e5-41ba-80be-ed119b7902fc") },
                    { 4, new Guid("c6903087-71e5-41ba-80be-ed119b7902fc") },
                    { 4, new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f") },
                    { 5, new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f") }
                });

            migrationBuilder.InsertData(
                table: "Submissions",
                columns: new[] { "Id", "AssignmentId", "FileContent", "FileName", "FileType", "StudentId", "SubmittedOn" },
                values: new object[,]
                {
                    { 1, 2, new byte[] { 49, 50, 51, 49, 50, 52, 49, 50, 52, 50, 51, 52 }, "task1", "txt", new Guid("5c07f155-602e-403b-bb86-5a786814f575"), new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5692) },
                    { 2, 4, new byte[] { 113, 119, 100, 113, 101, 50, 113, 101, 119, 113, 101, 113, 119, 101, 119, 113, 100, 113, 119, 101, 113, 100 }, "task2", "txt", new Guid("18e76084-b8a6-4e78-bd26-143f33a05eb8"), new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5704) },
                    { 3, 6, new byte[] { 113, 119, 101, 113, 119, 101, 113, 119, 101, 115, 97, 100 }, "task3", "txt", new Guid("c6903087-71e5-41ba-80be-ed119b7902fc"), new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5705) },
                    { 4, 8, new byte[] { 113, 119, 100, 113, 119, 32, 113, 119, 100, 32, 113, 119, 100 }, "task4", "txt", new Guid("f4aa693d-305e-426b-950c-d02a8ca8b56f"), new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5707) },
                    { 5, 10, new byte[] { 113, 87, 69, 67, 119, 100, 119, 97, 100, 97, 119 }, "task5", "txt", new Guid("bb5432a1-ea56-450b-9db6-f7349faf28a6"), new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5708) }
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
                name: "IX_Grades_CourseId",
                table: "Grades",
                column: "CourseId");

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
                name: "IX_Submissions_AssignmentId",
                table: "Submissions",
                column: "AssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_StudentId",
                table: "Submissions",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Teachers_ApplicationUserId",
                table: "Teachers",
                column: "ApplicationUserId",
                unique: true);
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
                name: "Submissions");

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
