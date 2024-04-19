using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedmoreseeddata2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Residences",
                columns: new[] { "ResidenceId", "Address", "BiArea", "CategoryId", "ConstructionYear", "LandArea", "LivingArea", "MonthlyFee", "OperatingCost", "PictureListURL", "RealtorId", "RegionId", "ResidenceDescription", "RoomCount", "StartingPrice" },
                values: new object[,]
                {
                    { 1, "Sveavägen 42", 20, 1, 2004, 500, 120, 4000m, 50000m, "[\"url\"]", 5, 1, "Modern lägenhet med öppen planlösning och balkong belägen i centrala stan.", 5m, 2000000 },
                    { 2, "Storgatan 12", 30, 2, 2000, 0, 100, 6500m, 24500m, "[\"url\"]", 4, 2, "Charmigt radhus med trädgård och garage i lugnt bostadsområde nära naturen.", 3m, 1250000 },
                    { 3, "Strandvägen 7", 0, 3, 2018, 1000, 250, 4250m, 32400m, "[\"url\"]", 3, 3, "Funkisvilla med pool och havsutsikt på exklusiv adress vid kusten.", 6m, 3000000 },
                    { 4, "Norra Vallgatan 14", 15, 4, 2009, 625, 130, 7000m, 31500m, "[\"url\"]", 3, 2, "Gammal gård renoverad till lyxigt boende med generösa sällskapsytor och stor trädgård.", 4m, 2230000 },
                    { 5, "Östra Hamngatan 3", 50, 5, 1972, 200, 120, 3750m, 20500m, "[\"url\"]", 1, 5, "Lägenhet i nybyggd bostadsrättsförening med gemensam takterrass och närhet till shopping och kommunikationer.", 5m, 1400000 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 5);
        }
    }
}
