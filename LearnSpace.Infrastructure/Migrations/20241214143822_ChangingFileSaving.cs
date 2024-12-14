using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    public partial class ChangingFileSaving : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Submissions");

            migrationBuilder.AddColumn<byte[]>(
                name: "FileContent",
                table: "Submissions",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Submissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileType",
                table: "Submissions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c136c2de-5c94-4fbe-abf5-a5bbf7f6ab33", "AQAAAAEAACcQAAAAEE5n/GqdDERTjjQG71ROG7J54uN0d0j+QqIG7w1d9PTAFNvtQcMP020xBZcFnfjveg==", "4f2e4b36-516e-4874-aef8-aee8afa0eb57" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc5a8662-a736-4730-b2e2-1523decea5b0", "AQAAAAEAACcQAAAAEMvqIPTtW5Tct/k8dI5E3GqFKITQrI6lGqQhTJrpWYEYu6KwD1MtSVHY4UYtAYv62w==", "bad6ac52-52a5-41d6-b2c8-cadae0f410f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5c57c34-82cc-43ec-9db9-1ec12fd1e325", "AQAAAAEAACcQAAAAEHkQc5DLORYia3r6swemtJ2Qy4B0rV7KHwabEwp2fcaCr8LV8eGLJ965hbEDivGm2A==", "14027479-345b-4b3b-80ae-f5ac92e8c343" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9adf68e-2e54-4a8b-858b-268f58bd1c4d", "AQAAAAEAACcQAAAAENYB1iQu8B4BkQXzMpJMDg1m6PM06whM9vW8C3+Jdycd6vT9qno6jwaDxiPFWA9tCw==", "29b746ae-835d-4b40-b49c-4762638e0337" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb8ced5d-3761-4b06-af1f-16618f5efcbb", "AQAAAAEAACcQAAAAEFmqysFBgZIrmVBwuzFQicasJ6rd3jmv3gDtfOrDjJW2/U1df1K+Y+E4oZg+t0J0EA==", "aa9fd615-40c5-4556-ad17-639b3383d1a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe8a4b95-2485-4fc1-9f8d-657138865943", "AQAAAAEAACcQAAAAEDP5//lY5+VJ2Fw4TwQT/NzWj7s3KR7yjHFOrpL7K2hrYL/C8YtoDh51j7H2XJjaqg==", "5d0047fb-261a-440c-a6c6-370615720e9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f15bae6b-5616-470f-b6a0-f39995e87b6b", "AQAAAAEAACcQAAAAECAfEdy1ucNQ35W2a0gMXUdrbUazHLzOc4k0fngqZT7gO4m3+sk29nAUGIse4TcmZg==", "08ad05fd-2e3e-45ab-bda8-3021796bc0cc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95077269-6db9-4a22-8189-7dff97c4f32f", "AQAAAAEAACcQAAAAENAnm26n5nT2JPECGnsJKd53k+XO1x/LeBbIXr/b4XJr2ZRGQzH7OK32PhXBa0JjCw==", "55d4da29-955e-4a75-afec-422c4159cfb3" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 16, 38, 22, 101, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 16, 38, 22, 101, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 16, 38, 22, 101, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 16, 38, 22, 101, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 16, 38, 22, 101, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FileContent", "FileName", "FileType", "SubmittedOn" },
                values: new object[] { new byte[0], "task1", "txt", new DateTime(2024, 12, 14, 14, 38, 22, 101, DateTimeKind.Utc).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FileContent", "FileName", "FileType", "SubmittedOn" },
                values: new object[] { new byte[0], "task2", "txt", new DateTime(2024, 12, 14, 14, 38, 22, 101, DateTimeKind.Utc).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FileContent", "FileName", "FileType", "SubmittedOn" },
                values: new object[] { new byte[0], "task3", "txt", new DateTime(2024, 12, 14, 14, 38, 22, 101, DateTimeKind.Utc).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FileContent", "FileName", "FileType", "SubmittedOn" },
                values: new object[] { new byte[0], "task4", "txt", new DateTime(2024, 12, 14, 14, 38, 22, 101, DateTimeKind.Utc).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FileContent", "FileName", "FileType", "SubmittedOn" },
                values: new object[] { new byte[0], "task5", "txt", new DateTime(2024, 12, 14, 14, 38, 22, 101, DateTimeKind.Utc).AddTicks(1617) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileContent",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "FileType",
                table: "Submissions");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Submissions",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "FilePath", "SubmittedOn" },
                values: new object[] { "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task1.txt", new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FilePath", "SubmittedOn" },
                values: new object[] { "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task2.txt", new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FilePath", "SubmittedOn" },
                values: new object[] { "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task3.txt", new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FilePath", "SubmittedOn" },
                values: new object[] { "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task4.txt", new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FilePath", "SubmittedOn" },
                values: new object[] { "D:\\Programing Files\\C#\\LearnSpace\\LearnSpace\\wwwroot\\uploads\\submissions\\task5.txt", new DateTime(2024, 12, 14, 11, 38, 5, 319, DateTimeKind.Utc).AddTicks(6783) });
        }
    }
}
