using Microsoft.EntityFrameworkCore.Migrations;

namespace SPM.API.Migrations
{
    public partial class AdditionalNewRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductCode", "ProductName", "ReleaseDate", "StarRating" },
                values: new object[] { 3, "Curved claw steel hammer", "assets/images/hammer.png", "8.9", "TBX-0048", "Hammer", "May 21, 2018", "4.8" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductCode", "ProductName", "ReleaseDate", "StarRating" },
                values: new object[] { 4, "15-inch steel blade hand saw", "assets/images/saw.png", "11.55", "TBX-0022", "Saw", "May 15, 2018", "3.7" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductCode", "ProductName", "ReleaseDate", "StarRating" },
                values: new object[] { 5, "Standard two-button video game controller", "assets/images/xbox-controller.png", "35.95", "GMG-0042", "Video Game Controller", "October 15, 2018", "4.6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
