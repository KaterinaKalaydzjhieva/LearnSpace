using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    public partial class AddDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourses_Students_StudentId",
                table: "StudentsCourses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8de49587-9a62-469e-9153-7bc3d3f707ee", "AQAAAAEAACcQAAAAECQY94kzCpK1vBm3+NPn/F3gsxZGNIw8jg82tiQhFQQkLlkKqui6dEenIidbtIMZ4A==", "599689e1-3dda-438f-bdf4-81f44a5c14f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a8feb43-d45f-4343-add5-8b383de1ed08", "AQAAAAEAACcQAAAAELbhEP0CXLXgZQunUnuzdgHpHBuFEXa8INArKS1EjE+bd9x9oG16nPas76Zaxj/x9Q==", "22a7834b-4e41-4738-997d-84f61cc80757" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4690fe2-de42-45e9-aa9e-f695803a6340", "AQAAAAEAACcQAAAAEDvJmdcAsTIzw+llAby2WuevnqLxXeW5Ry9OLgIyeITDqEvJ0rybzz9nGHgiTMJcZA==", "9632bee9-d796-4a04-a461-a17ba4b08e53" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9398ef19-63d7-4380-a7a0-7e0efc10578e", "AQAAAAEAACcQAAAAEK1gf9qW7lBopAj7C73AZmD1G4x2ApjvDidm9r0cxDPkMp2Wc2heMjFkQDWdEytZUQ==", "4ef339dc-5cfb-4e90-91f4-deee3d4f731a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17745335-47a5-4ab4-877d-ab0dc4fdbcf6", "AQAAAAEAACcQAAAAEAdA3UO4cTrY1TjSMewMIQ4/I86ChdGhDivUpAf6UEIUzNJaHYvy9kpdRUBEo7DYWw==", "421f474f-36c5-4dff-adfd-75e81c304767" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "135d2520-7288-47a2-8f1e-c1c25c079223", "AQAAAAEAACcQAAAAECf1SYoRP0+VOP0EzlFTkbBtqDjxjKEUiZ2QaP4FUmD7Qc0slMoywyNUESqSaOVg/w==", "665da40b-a09c-4061-ad70-80021a7c9fba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c2079aa-b48c-4aa0-8a1c-c87a419363b5", "AQAAAAEAACcQAAAAEJlCDKrZXSaBgqe9CsCqnchhmWt8Dsdrfb5vpQd9BPj0+Ypb9GvyCrzd0Dj9cSHTzA==", "412d741c-33c2-49aa-be49-7639f2778898" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20ba228f-3b64-4b12-9862-c02e3c0b26fd", "AQAAAAEAACcQAAAAEP0XodhKCLuJq1pSHdx55oMVWPb+bIWFbr+FY1pC11Cagu4RAmfnrz15WE+a2DpLYg==", "c5d14d91-ac83-4772-b9de-3c3cb58e9cc4" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 23, 18, 21, 806, DateTimeKind.Local).AddTicks(7282));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 23, 18, 21, 806, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 23, 18, 21, 806, DateTimeKind.Local).AddTicks(7339));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 23, 18, 21, 806, DateTimeKind.Local).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 23, 18, 21, 806, DateTimeKind.Local).AddTicks(7348));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 21, 18, 21, 806, DateTimeKind.Utc).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 21, 18, 21, 806, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 21, 18, 21, 806, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 21, 18, 21, 806, DateTimeKind.Utc).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 21, 18, 21, 806, DateTimeKind.Utc).AddTicks(6790));

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourses_Students_StudentId",
                table: "StudentsCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourses_Students_StudentId",
                table: "StudentsCourses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e1f7889-1be5-4b31-b356-251d991d9c8e", "AQAAAAEAACcQAAAAENtOEOsDRHRG7ijMm8gNH4Yvq4XmnKWwA52GTKUi5iw92+a5LWQCFG6XVmxTO7+64g==", "581b32b8-8a53-4dc8-9012-11f54279139a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "184b4d50-cb34-45d2-a85a-63337a3a81d3", "AQAAAAEAACcQAAAAELWmsjDkw93dRqbJJ1LZMKtJGlqxv/63bhL/tDEe5iv+4Yman9PYAFE2lmqp5N4kTQ==", "783d3fa9-7a98-4fc5-a1a6-f177f63341e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e73b780-1240-493b-9328-838d962776ab", "AQAAAAEAACcQAAAAEG+7ZDhhN7SQF//EpqNeIC8RMlD3fYmaBD7cXbakW84clP5AmaxVwApyCA1Q9Dvtkw==", "5d5f336d-8b41-46e2-b036-880e59e413c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25ab17a3-f622-4e28-adc8-7e992084160e", "AQAAAAEAACcQAAAAECgUJKxUzY+GJx2QYhjS+xTYoSrZfhZ5q2Rg0wYA+Pil0RSz8fKCUNycwLQhPpLf9Q==", "6f4c0d70-8340-4cee-8f42-8364d53d731e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "530fb095-0756-4ca8-95d4-e7a3a1bb3056", "AQAAAAEAACcQAAAAEOmQZq1J/gqffJlw2O58XPx0gEUneH0awtIxfkBLnMuKrs+inRFhciqkfKpDVR/jnA==", "81e5c346-aea3-4b30-b8b9-8a2c5b941631" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa9bd63b-b854-43b6-8d45-1b14692121b8", "AQAAAAEAACcQAAAAELKcB0JiC/i5HBijXst4pzZbYYpA3Lj5dICk+6Iq1OCf2h3uNPva9w+pHEHY7h0XvA==", "222d7572-9b47-46f2-b4c7-210e1b42d56a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b79f178-ff27-49f0-93dd-dced5afdae97", "AQAAAAEAACcQAAAAENT6jjDY9LBX/F3TM9B+EyYSb0Mu7zDqbCgU5Lr5MpqVNHH5AzY7ZlJeeklRPfZjow==", "23e015e5-090f-4cf1-ad85-8f3c0cb92974" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb3b9678-2311-45a3-b7dc-0168aaafa9ae", "AQAAAAEAACcQAAAAED1pUcSalPE8Bm4EYWZFC5Qeg/lV0IjPaLi6f9/54yQbQSmLwRP2IR6/yT5T7OYo9A==", "9f06e15d-2dba-44db-af69-f904106e2e57" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 22, 47, 34, 417, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 22, 47, 34, 417, DateTimeKind.Local).AddTicks(5497));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 22, 47, 34, 417, DateTimeKind.Local).AddTicks(5504));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 22, 47, 34, 417, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 18, 22, 47, 34, 417, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 20, 47, 34, 417, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 20, 47, 34, 417, DateTimeKind.Utc).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 20, 47, 34, 417, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 20, 47, 34, 417, DateTimeKind.Utc).AddTicks(4712));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 18, 20, 47, 34, 417, DateTimeKind.Utc).AddTicks(4715));

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourses_Students_StudentId",
                table: "StudentsCourses",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
