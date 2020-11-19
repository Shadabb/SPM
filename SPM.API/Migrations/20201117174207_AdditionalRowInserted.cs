using Microsoft.EntityFrameworkCore.Migrations;

namespace SPM.API.Migrations
{
    public partial class AdditionalRowInserted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductCode", "ProductName", "ReleaseDate", "StarRating" },
                values: new object[] { 1, "Leaf rake with 48-inch wooden handle", "assets/images/leaf_rake.png", "19.95", "GDN-0011", "Leaf Rake", "March 19, 2018", "3.2" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "ProductCode", "ProductName", "ReleaseDate", "StarRating" },
                values: new object[] { 2, "15 gallon capacity rolling garden cart", "assets/images/garden_cart.png", "32.99", "GDN-0023", "Garden Cart", "March 18, 2018", "4.2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
