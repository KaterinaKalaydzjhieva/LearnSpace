using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    public partial class ChangedFluentApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Courses_CourseId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Courses_CourseId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60f68138-867e-4a0c-a4d5-2deea53ff8ea", "AQAAAAEAACcQAAAAEAe/hr/hbNHawARn3S+KFZc10tgIVc359cEqUa5V7fQf8pTSOPB3mfnbmTQL10tK0A==", "abcf1cc5-d5d6-442c-b540-540a847c7ef4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "751291ac-5dcb-4892-9b44-f5218f4908c3", "AQAAAAEAACcQAAAAEL3vDqIakmUER115PI8o0jihV+cuvaijZRXIgBmLDAv1xfwlQwl56jzQc6VZ/f9afQ==", "d7863e90-953e-49be-b17c-702e042ef34c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c450b671-8ef0-4a8a-95cf-c49e1eb7f058", "AQAAAAEAACcQAAAAENo0zah4gWZv6s6AQtsXcy3hcd6ZvPXGlTuHBVZnyvXFxcsCTBPUuFwqy+THM5HdUA==", "730d1719-7547-4f94-a3d9-0294d96f6ad6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "82d26226-cf57-498f-a6e7-30e07344fd25", "AQAAAAEAACcQAAAAEORZC/Q7U4wHJKVliJBrpWOst1+Ww9lG8xq0Iu6c85Jdk9JiQPY4zwhy6BxDo2hnMw==", "31d0a5bb-e5b2-4974-9ff8-8806fa5251f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b4791d3-5c9c-4a4e-9aa0-3911a25ab124", "AQAAAAEAACcQAAAAEBHcMZN8k2cQnlYjle5r/t1VzzCq63ebC1WdVF3u6ugw2+g3QjPzZgENKXXUzJpGNA==", "52c2741d-96de-401c-b145-1650d89393f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cfc1934-ea5c-4ba6-a359-32776f912c29", "AQAAAAEAACcQAAAAECvH9aIRZLKqNEahm0saWeq0MyfMuQUE5pImkr/FnKREEYS3vxVLfT20P0SXId25yw==", "cf2db529-9bd1-42c3-90a3-cc049bf9a40b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ab70cc-3b33-45ad-897f-66b28b100196", "AQAAAAEAACcQAAAAEDfYMbZS+CtY9iVMPYcn8vCzdsDxW+DwlwVvdJds0kdtu7UVVYb477cut46IAtqaMw==", "4c79bcef-1138-4312-ba4e-b00698b6e821" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bc72ca89-9463-448a-b23c-6840b35d7e91", "AQAAAAEAACcQAAAAELg8kSjbUTw9D17rr+oveBEDhgQ2PmZdybRyEFJxLh0WvwE2MfAhRgVI11HWwBjXFg==", "afbefce5-f8a8-4d21-a7ea-76db191e9d3f" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 22, 26, 13, 951, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 22, 26, 13, 951, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 22, 26, 13, 951, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 22, 26, 13, 951, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 22, 26, 13, 951, DateTimeKind.Local).AddTicks(549));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 20, 26, 13, 951, DateTimeKind.Utc).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 20, 26, 13, 951, DateTimeKind.Utc).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 20, 26, 13, 951, DateTimeKind.Utc).AddTicks(140));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 20, 26, 13, 951, DateTimeKind.Utc).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 20, 26, 13, 951, DateTimeKind.Utc).AddTicks(143));

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Courses_CourseId",
                table: "Assignments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Courses_CourseId",
                table: "Grades",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assignments_Courses_CourseId",
                table: "Assignments");

            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Courses_CourseId",
                table: "Grades");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20513df5-6f65-4654-880e-7c827088fcaa", "AQAAAAEAACcQAAAAEBGiRbBDargdzj6TvPNLOT6yeWdOvpv0h8s6pMVROT52JCBt/6hSp0r8nNDEnAIefA==", "6b7679c2-cfdd-4e1e-a3e8-f2ac1690ec92" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f3c93c2-43a9-4366-975a-2902c6ba6ca0", "AQAAAAEAACcQAAAAEPRKM9+aw3c9RdpCW6DoruRNzpRdnHxi+Gi+4WAq7re4muXN+LJRCeqD9bxirpIYlA==", "3739d6cc-ad31-470b-8bd3-ae9a7ce28711" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05cd679c-4a34-4b61-b6e9-98f28fc9bee3", "AQAAAAEAACcQAAAAEAScsIPcX87xKm6MtT6GmqYuqALqobj8LhJo6+rdt7IcxzUaG/SJkSiNmtyQiDlVZw==", "e8777f89-6565-4498-ac6b-0c51d1110d7b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1904721-fcd5-499b-af04-58b9ee97125b", "AQAAAAEAACcQAAAAEOQ+mz8L5eVlUjNUW83NgHEWgOqXsIGrwX8/VGWTuqaJaBR1bmF2YAZolbyzE5bC/Q==", "b918550e-c71c-4a08-9319-3e1d414d95ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59719f59-6172-4115-8013-4168fbe1130a", "AQAAAAEAACcQAAAAEBdQJCtU60vmNksrSYAsvk+0j2jH6J+EP6Bf3vl9n+QqzkCxYxicjfEmsFftP3LDeA==", "19a1e52c-803a-4486-8b06-53bb6bd9231a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9eeb13b7-4ee3-47f9-bded-202d467dea69", "AQAAAAEAACcQAAAAEDqhDXrWWdxCKRYhu0FpKHjtN+wKsPQ1ZBRTEFg2z0dat4U7QXgiQu2qvD7rWTcqsA==", "5c3b6622-df1a-49f4-9c2d-9d2080b53e8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b77a0da-cca5-42b6-a987-39aa889fc18d", "AQAAAAEAACcQAAAAEHVUIc9Xu6EWhb0m0pxWYnnwlQ2mHXUioEHlhOuQp8owdVh/qNcty5JF//pHAZ+IUQ==", "012f4776-f6f1-4ee7-aa35-e8a4a3e990c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5f0e583-37f2-4694-8b44-56b861a809b0", "AQAAAAEAACcQAAAAEKO228oKAIdn/PAen7ILzXpv+/VLwptuENd0AaYoiOofbvBhVlhf37OBoTdkQBWe6w==", "02ba279a-94e3-41a2-95e7-084ace3f477a" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 17, 58, 58, 882, DateTimeKind.Utc).AddTicks(5837));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 17, 58, 58, 882, DateTimeKind.Utc).AddTicks(5846));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 17, 58, 58, 882, DateTimeKind.Utc).AddTicks(5848));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 17, 58, 58, 882, DateTimeKind.Utc).AddTicks(5849));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 17, 58, 58, 882, DateTimeKind.Utc).AddTicks(5851));

            migrationBuilder.AddForeignKey(
                name: "FK_Assignments_Courses_CourseId",
                table: "Assignments",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Courses_CourseId",
                table: "Grades",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentsCourses_Courses_CourseId",
                table: "StudentsCourses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
