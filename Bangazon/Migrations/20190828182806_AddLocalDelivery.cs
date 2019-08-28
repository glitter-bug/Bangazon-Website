using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class AddLocalDelivery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LocalDelivery",
                table: "Product",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "855566f4-744b-4510-91fe-caaf739d274d", "AQAAAAEAACcQAAAAEGKiWmtrKdRvNx6+w0Oqw6jMqkz0xyixGBsqxKQIjCirXbKtlFtuPqh9YgjZxj5pog==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocalDelivery",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1563d799-7049-4ae4-b83b-4063bfaad987", "AQAAAAEAACcQAAAAEINup3S2J8xptRYNqoi8SO0AeJavuvvah563R13u375QpKwNQEzIf0+qTCbpzI/G9g==" });
        }
    }
}
