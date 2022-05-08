using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmacyShop.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "Vitamin C nutritional supplement with gradual release for the proper functioning of the immune system.", "https://www.drmax.sk/_i/288425126.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2F6%2Fz%2F6zdiiq0_400x400_1.jpg&fit=contain&w=350&h=350&format=webp", 4.99m, "Vitamin C Long Effect 500 mg" },
                    { 2, "Advantageous package with gelatin capsules with vitamin D3.", "https://www.drmax.sk/_i/1851874929.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fd%2Fe%2Fdevit_2000_120_l.png&fit=contain&w=350&h=350&format=webp", 11.49m, "Vitamin D DeVit 2000 IU" },
                    { 3, "It contains a combination of magnesium and vitamin B6, thanks to which magnesium is replenished in the body faster. Magne B6® improves in case of magnesium deficiency e.g. nervousness, fatigue, irritability, muscle cramps and numbness.", "https://www.drmax.sk/_i/1922185717.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fz%2Fp%2Fzpv4rz0_400x400_1.jpg&fit=contain&w=350&h=350&format=webp", 14.39m, "Magne B6" },
                    { 4, "Probiotic complex suitable for adults and children from 3 years.", "https://www.drmax.sk/_i/1944578361.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fo%2Fz%2Fozz0lb0_400x400_1.jpg&fit=contain&w=350&h=350&format=webp", 13.39m, "Biopron 9" },
                    { 5, "Nutritional supplement containing 25 mg of lutein, minerals, vitamins and omega-3 fatty acids.", "https://www.drmax.sk/_i/1804857849.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2F7%2F9%2F7926yq0_400x400_1.jpg&fit=contain&w=350&h=350&format=webp", 28.19m, "Ocutein Brillant Lutein 25 mg" },
                    { 6, "Drug with analgesic and antipyretic effect. Helps relieve pain and lower temperature. Suitable for flu conditions. It does not irritate the stomach.", "https://www.drmax.sk/_i/-1194474228.webp?m2=%2Fmedia%2Fcatalog%2Fproduct%2Fp%2Fa%2Fparalen_500_24tab.png&fit=contain&w=350&h=350&format=webp", 2.09m, "Paralen 500" }
                });
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
