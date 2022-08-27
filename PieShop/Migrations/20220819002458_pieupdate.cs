using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class pieupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                column: "Name",
                value: "apple");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "Name",
                value: "orange");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                column: "Name",
                value: "cake");

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInfo", "CategoryId", "ImgUrl", "InStock", "IsPieOfTheWeek", "LongDes", "Name", "Notes", "Price", "ShortDes" },
                values: new object[] { 4, null, 2, "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1", true, true, "Long description", "cake", null, 12.32m, "short description" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1,
                column: "Name",
                value: "apple pie");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2,
                column: "Name",
                value: "orange pie");

            migrationBuilder.UpdateData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3,
                column: "Name",
                value: " pie");
        }
    }
}
