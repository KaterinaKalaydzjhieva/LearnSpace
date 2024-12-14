using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    public partial class RemovedGradesStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee855b2d-f344-4e84-a838-6dc178b29fec", "AQAAAAEAACcQAAAAEBRj5EhT9hqQbZ84+VIuMo88CM3XqehZmAVyFvN5vHk2z/+NGnBr1+D62vzg6Roj9g==", "28f418fd-02f6-4c9e-aae4-3b3617890dec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4cd79fdc-367c-4fd9-97ad-10a4f887f9ef", "AQAAAAEAACcQAAAAECM1Uds9HZhUFVKm+7pfo7xHxQ2iK+2L6simWPvq0gdQ31kNl3QxaUNu/DtM3Br13w==", "750b613c-75ba-42f0-930a-6117a4c4923f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c0dace8-e127-4a60-bcf4-9d22a5e6915f", "AQAAAAEAACcQAAAAEFj59EQcqWrNC3FOdeBeKB74iWtVGX9EOHeiEE5n+1DH4gZds4yDAc5HaYn2wgd6nw==", "e5a32cb5-dea3-4bc2-9d57-35ba719e6ece" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7809cf20-6bb5-4cf3-8a89-70622f5e2d9e", "AQAAAAEAACcQAAAAEHUp0dfRQrAq4ZSDEET6fk+666wlWRpniTfoRaRI0rMDM3Nz6I719cjc9vc+dadmuA==", "2f4a73a3-6e47-4633-8100-8cab46ffe057" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f847713c-3c3b-4f28-82a4-7c8277c6fce5", "AQAAAAEAACcQAAAAEMHouKVeuGmgBUh+bDp4HMCxkKvzR3GRMEyKm1ifSTp4P9FCk6XzqOKRqd7dT2Vl8A==", "dd5274d5-a01f-47c3-b66d-80b40eb1b3c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbcfcd43-5de0-4ff0-a82f-8d589f8573c3", "AQAAAAEAACcQAAAAEEFsjBr+5wpBU/1okBki36OGrOKpUDLaqt5b/mrO5fqQyyMhYycydz/G/7ictyqtHw==", "37917c47-1d9f-4acb-8dc9-f8c82a06e131" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5717e403-ee12-4a27-b122-86c14193452f", "AQAAAAEAACcQAAAAEFJmO50eGZ/lQuV5WzFK+Qc6xLDDgP3BgqJq9y4ve3IhanxODSnC12RxtmGl/Zs3ow==", "fc02ad32-03d0-4112-82ee-6b92541bb25d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de0bcbc5-9c06-4ed8-8b82-28fb84f165b4", "AQAAAAEAACcQAAAAEILAAqKL6b5DZL/TNNbRf7zCybjkUirDGCBxbtE2iGr5zb57tHu5E+/KpPV6BV8FYQ==", "0174ca38-3ebe-4a1e-aad3-9d9743a90832" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 12, 51, 39, 122, DateTimeKind.Local).AddTicks(4900));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 12, 51, 39, 122, DateTimeKind.Local).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 12, 51, 39, 122, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 12, 51, 39, 122, DateTimeKind.Local).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateGraded",
                value: new DateTime(2024, 12, 14, 12, 51, 39, 122, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 10, 51, 39, 122, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 10, 51, 39, 122, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 10, 51, 39, 122, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 10, 51, 39, 122, DateTimeKind.Utc).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 14, 10, 51, 39, 122, DateTimeKind.Utc).AddTicks(4825));
        }
    }
}
