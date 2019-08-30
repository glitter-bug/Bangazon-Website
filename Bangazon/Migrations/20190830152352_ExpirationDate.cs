using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class ExpirationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "PaymentType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca8a27cb-24c3-4c00-baf6-4dc2eb361e40", "AQAAAAEAACcQAAAAEAhZORGLHUPKssBfyaGz+wcxhzSAvPOPz/WLXFbD5kIU8WXFRACzeL1jVm8iCtIU3Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "PaymentType");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d111da89-8a10-453d-a411-6501bbed7ff0", "AQAAAAEAACcQAAAAEKgsVh50DwabK8CYzyImxdpFo5MX87OrApPRLUqOJ+wWwuPBi8XvQ25hyHsit4N1lA==" });
        }
    }
}
