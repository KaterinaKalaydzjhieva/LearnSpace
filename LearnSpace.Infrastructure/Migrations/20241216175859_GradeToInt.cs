using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearnSpace.Infrastructure.Migrations
{
    public partial class GradeToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Score",
                table: "Grades",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

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
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6163), 4 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6202), 3 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6205), 5 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6208), 6 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 19, 58, 58, 882, DateTimeKind.Local).AddTicks(6210), 6 });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Score",
                table: "Grades",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("08d20ff4-ecdd-4b8a-8142-4cf42ee6adc6"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11be327e-894c-4408-8b66-387331e1738e", "AQAAAAEAACcQAAAAELwHGfXY4AnMo9lWzE8GbF8vcSn2Ic9qrl//cI1E7bR1xOaMK+gZEUKORQ3i4rTlhw==", "08e84abe-6525-4538-845a-21c38f2c618f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("267a7709-17b4-413c-9026-a6f365d59731"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2e40334-5bd7-459a-a99c-b8807130f311", "AQAAAAEAACcQAAAAEOhL14MSTZ1cQBJIsO/YJPVD9RD5G9F3htZrkoe73LgtSE8nyeVATXtVZOCURUA0pA==", "d5b52fbc-4ee4-45d2-ada4-4a6f2b94258a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2d522f0f-1d26-429e-8bef-0098f10d96e9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61b66895-b2b5-449e-8730-e82513bce608", "AQAAAAEAACcQAAAAEID4V7txnjSfNMhh1pJfcFIM+ydDypCJVi/VUmG6CoVZ/monFMn97YU5/hmW/T39EA==", "b2c874a2-8d61-4c69-87ed-d8f3ffd8ba4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3cc698b0-736e-490a-97e3-3f343bf8bfd8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e30d81d-192e-4727-8d0b-52c34b97cd9e", "AQAAAAEAACcQAAAAECSuM0pRQmftdzdzVyJsNQ6kJI+cRaN/TNyA6gOxvcFu4Ob2yxQw+Lvt8IdGl6wL/Q==", "40e8c2d5-36ee-4855-a170-6263d3af5d51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a52dc824-b577-4862-ac67-29d391116793"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07d5690f-b11d-4d92-9a78-f9c1016bee29", "AQAAAAEAACcQAAAAEPQHygINIiRAUpAdtivgAUrydEzA2GphhriT0Ij4wMc+xBffXOrhJT6cDcb9lqRsAw==", "68e8a96a-7b4a-45c9-a365-f5e3a3b92ec7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bc5f8df5-6115-4344-897b-73e185df4bff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8dec1b99-3765-42ea-b4dc-2b609048ba7e", "AQAAAAEAACcQAAAAEMh2ffDKeOj87T1QW72zxzpsrelDA5iF27iYYRkl4+a08xjf4dTImd70zT0ZoKEk8g==", "4ea73919-4923-4061-9d01-cc4b1fbe55d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bdc70ff8-a02a-428f-ad1c-b5ba645a45e1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51719789-61d5-479f-8c92-586c13e79fba", "AQAAAAEAACcQAAAAEAyq7Y5Pn+usCXmwUZY6R4s472YGmCq0vjneFyWRhfixO29pzbVrBnR0G0H1ACUrZQ==", "69ef1fd1-32b5-424d-bd39-88c14bf3547e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ebdc00b8-7106-4cbd-a482-da93c40103d3"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e0ff6c2-9796-4d78-affc-e2e5d07a1f57", "AQAAAAEAACcQAAAAEFRbWN0k7h5jcUIew8XnLzlD2pL61hKjcdOLqtQE+sm+OjQtnuyYCn4i64xrNQS4Ng==", "49b03303-c710-453c-88ee-ab19b1891b56" });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(5977), 4.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6016), 3.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6021), 5.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6025), 6.0 });

            migrationBuilder.UpdateData(
                table: "Grades",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateGraded", "Score" },
                values: new object[] { new DateTime(2024, 12, 16, 12, 25, 51, 62, DateTimeKind.Local).AddTicks(6029), 6.0 });

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 1,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 2,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 3,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 4,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5707));

            migrationBuilder.UpdateData(
                table: "Submissions",
                keyColumn: "Id",
                keyValue: 5,
                column: "SubmittedOn",
                value: new DateTime(2024, 12, 16, 10, 25, 51, 62, DateTimeKind.Utc).AddTicks(5708));
        }
    }
}
