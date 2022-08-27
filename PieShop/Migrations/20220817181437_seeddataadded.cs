using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class seeddataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Des" },
                values: new object[] { 1, "Fruit pies", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Des" },
                values: new object[] { 2, "cheese cake", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Des" },
                values: new object[] { 3, "seasonal pies", null });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInfo", "CategoryId", "ImgUrl", "InStock", "IsPieOfTheWeek", "LongDes", "Name", "Price", "ShortDes" },
                values: new object[] { 1, null, 1, "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1", true, true, "Long description", "apple pie", 12.32m, "short description" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInfo", "CategoryId", "ImgUrl", "InStock", "IsPieOfTheWeek", "LongDes", "Name", "Price", "ShortDes" },
                values: new object[] { 3, null, 2, "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1", true, true, "Long description", " pie", 12.32m, "short description" });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInfo", "CategoryId", "ImgUrl", "InStock", "IsPieOfTheWeek", "LongDes", "Name", "Price", "ShortDes" },
                values: new object[] { 2, null, 3, "https://i0.wp.com/sweetlycakes.com/wp-content/uploads/2019/12/Apple-Pie-8blog.jpg?fit=1440%2C2160&ssl=1", true, true, "Long description", "orange pie", 12.32m, "short description" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
