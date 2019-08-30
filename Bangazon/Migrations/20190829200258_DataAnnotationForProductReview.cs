using Microsoft.EntityFrameworkCore.Migrations;

namespace Bangazon.Migrations
{
    public partial class DataAnnotationForProductReview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReview_AspNetUsers_UserId",
                table: "ProductReview");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProductReview",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d111da89-8a10-453d-a411-6501bbed7ff0", "AQAAAAEAACcQAAAAEKgsVh50DwabK8CYzyImxdpFo5MX87OrApPRLUqOJ+wWwuPBi8XvQ25hyHsit4N1lA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReview_AspNetUsers_UserId",
                table: "ProductReview",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductReview_AspNetUsers_UserId",
                table: "ProductReview");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "ProductReview",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e0be3bf4-60fe-42ef-bde4-ff8ddc39d393", "AQAAAAEAACcQAAAAEDqahjn7agJdmvF5S5X8e9Cqun+WNnCSFRbdJmHx7kdx0rpq0t/lNxemz0PxQAchhQ==" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductReview_AspNetUsers_UserId",
                table: "ProductReview",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
