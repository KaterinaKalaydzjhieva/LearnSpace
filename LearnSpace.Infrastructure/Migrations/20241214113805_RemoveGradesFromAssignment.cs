using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    public partial class RemoveGradesFromAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Grades_Assignments_AssignmentId",
                table: "Grades");

            migrationBuilder.DropIndex(
                name: "IX_Grades_AssignmentId",
                table: "Grades");

            migrationBuilder.DropColumn(
                name: "AssignmentId",
                table: "Grades");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c6c6117-9a03-4266-b7da-1f08d7ac07aa", "AQAAAAEAACcQAAAAEAfALVPDldl0nnkDs4xo18xLXXTjWmZiN8+YxoAeHW4G4xCqetvsfeKnN3Lb1KSYFg==", "bdae35d4-709b-4e3e-86da-e4eebc9444e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ec3d6cc-f24c-4b36-9b03-38da6c839cde", "AQAAAAEAACcQAAAAEK/Lpxj++eqe6xVAjQ7ZMM0IaxRh5MVWTn1Yga40dzd2B6BFJq9GVRmpNi4y6QFoIQ==", "f2018e91-4d43-4ae4-bec9-a6033bffc6c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5df39a1-0f74-4522-a37b-c164ed50e3a5", "AQAAAAEAACcQAAAAEKu4kzkNUVvDKdZZiN4A6Dk4+0TYg9d9e2UdnSbLmYX7X6uQrqlLPw9IKoFRxX8vLw==", "09400c64-a983-4e02-a5da-736c34788693" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2794cd3b-8b13-43c8-a3da-fcf464230f94", "AQAAAAEAACcQAAAAEBZakDxqdSrSeMduVHs04J44XmJlpPrD0KsvWEN5n9AprfQA/tPXzPVfhF1bOMVoTQ==", "19873add-f9be-48d9-af17-6adb5979a3af" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59ead421-a564-493d-b3a0-c7773f0de3b7", "AQAAAAEAACcQAAAAEPnsg4poUlqrSOz4ZB0fooMANDTDN5jUsuMh0NltWv6GtDJjH2WM+ftS9b9xQIGtLQ==", "76b26c9b-d643-465c-ad70-ee14271b09c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcd1eaf9-2dac-44b4-9052-1a6de6fc5379", "AQAAAAEAACcQAAAAECCdBsqyozN0fS9SMctp/HbpTZNMfUcyu5MFdDMmSCyKl2Q9/a8SJ3PFMxH6vqomag==", "8ffd6e16-20e8-456e-91bd-37f6c38f36a5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb0d7412-5c0d-4f52-8c00-33b78df3a4bc", "AQAAAAEAACcQAAAAEGZLxD/Bkn0TOMIL5sVvnqKJPU9v3uPAUMmGktspH8xnIgeAceQ/mS5IlQFrDF5g3g==", "04cd41d6-0036-4ead-ab33-d5280099127b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e52d6e87-dcdf-46e4-a4ec-16ea8be66837", "AQAAAAEAACcQAAAAENYuivqOf1TlAXNIDPU/bAHDCz8/JVbos6Qv5kK9rQ3P2/lUCjC5MbXmo+qzzOUhqA==", "0f170195-7fbe-46af-aee9-8006828e961f" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 38, 5, 319, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 38, 5, 319, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 38, 5, 319, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 38, 5, 319, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 38, 5, 319, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6775));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6782));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6783));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignmentId",
                table: "Grades",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04e6e3ec-1209-4f3c-8fb3-b766f3b0e953", "AQAAAAEAACcQAAAAEJ+j/qXZxRmwQ6EQwSdHGF87lwDYwE/nJzdzt2DVquJR4VBBIqbMFSZXO9OjwfFyDA==", "05f17793-6aad-4595-9051-0fb531a815a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9e4d980-d4ef-4a5b-9155-ab765c758978", "AQAAAAEAACcQAAAAEHZQu3vXCN4D4iJDgYySLllywdJcOtJI9W3cstgrDA/RJjQMWqikj+rBY0ZGKFF2sA==", "37087acf-a127-4d00-8cbb-9cae04b4192b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cbeeac1-630e-4c08-ae8c-c7b60c323dc0", "AQAAAAEAACcQAAAAEDC3PzTZ6/6OM9uyEKK+H4h8ZmXLaMt7UGeXvtRDVtZkOJzTD+1/LvIltWwtbOzXjg==", "851cba8f-963d-4c18-9c64-10c965ac4beb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eec9e5cc-48a4-4fa6-86cc-e855c1b69cff", "AQAAAAEAACcQAAAAEPCiyF0Df/uKaaHVVOT8vOEJBKJXksbE+2JyrVNG8FOUBddmae2G4GRXdd35r1wCyQ==", "553300b6-8715-470d-86b5-a36db3bed9fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86d3b0f6-4014-4103-a462-494c67fa9e2b", "AQAAAAEAACcQAAAAEIw97BNqoniQe8KP05zi3lWGPznkZWkkI6DFeh7nnflacT7Wge8zcE+Bv2wQ0qh8sg==", "2dc322cb-c8d7-42aa-b2fe-5511d5c8e9e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4cac1b8-cefb-42a7-9a7f-0c4185246e70", "AQAAAAEAACcQAAAAEFj1kqL1G1Uw5xIPDGA1+RUzBwh6/CZlSMIGV+HK4Kp2/9PYvnFD2b5YkiOibPtjzw==", "a8e6e16d-4556-4247-81cf-6142a81ac2ba" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8af0d68-c345-4242-9429-86f48769091c", "AQAAAAEAACcQAAAAEEjeKfMufDjThP1RuX4Bqx/jMFsO6ARr5aR1UUwzpI+FoFKicYbECVbro8ruAYvY5Q==", "1c7bfa30-5337-461c-b7c7-b78755283cc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84ca7510-f88c-4d83-aecf-0ceba1b8f86e", "AQAAAAEAACcQAAAAEPvGBScVWCJQDZ90Fj1KzS2vr3FZ+pSdwY+t51+tZuc6KyE5YQBCCw7mH2AxRRDjFQ==", "d812bd53-9f6d-4995-9995-9883a59ec0b1" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 34, 49, 865, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 34, 49, 865, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 34, 49, 865, DateTimeKind.Local).AddTicks(3747));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 34, 49, 865, DateTimeKind.Local).AddTicks(3750));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 13, 34, 49, 865, DateTimeKind.Local).AddTicks(3752));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 34, 49, 865, DateTimeKind.Utc).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 34, 49, 865, DateTimeKind.Utc).AddTicks(3629));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 34, 49, 865, DateTimeKind.Utc).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 34, 49, 865, DateTimeKind.Utc).AddTicks(3632));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 11, 34, 49, 865, DateTimeKind.Utc).AddTicks(3633));

            migrationBuilder.CreateIndex(
                name: "IX_Grades_AssignmentId",
                table: "Grades",
                column: "AssignmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Grades_Assignments_AssignmentId",
                table: "Grades",
                column: "AssignmentId",
                principalTable: "Assignments",
                principalColumn: "Id");
        }
    }
}
