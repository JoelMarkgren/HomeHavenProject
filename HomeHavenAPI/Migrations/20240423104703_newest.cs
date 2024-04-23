using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class newest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Firms",
                columns: table => new
                {
                    RealtorFirmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descrpition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firms", x => x.RealtorFirmId);
                });

            migrationBuilder.CreateTable(
                name: "Realtors",
                columns: table => new
                {
                    RealtorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RealtorFirmId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realtors", x => x.RealtorId);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    RegionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Township = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    County = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.RegionId);
                });

            migrationBuilder.CreateTable(
                name: "Residences",
                columns: table => new
                {
                    ResidenceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartingPrice = table.Column<int>(type: "int", nullable: false),
                    LivingArea = table.Column<int>(type: "int", nullable: false),
                    BiArea = table.Column<int>(type: "int", nullable: false),
                    LandArea = table.Column<int>(type: "int", nullable: false),
                    ResidenceDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomCount = table.Column<int>(type: "int", nullable: false),
                    MonthlyFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OperatingCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConstructionYear = table.Column<int>(type: "int", nullable: false),
                    PictureListURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    RealtorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residences", x => x.ResidenceId);
                    table.ForeignKey(
                        name: "FK_Residences_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residences_Realtors_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "Realtors",
                        principalColumn: "RealtorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residences_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Villa" },
                    { 2, "Lägenhet" },
                    { 3, "RadHus" },
                    { 4, "FritidsBoende" },
                    { 5, "Tomt" }
                });

            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "RealtorFirmId", "Descrpition", "FirmName", "LogoURL" },
                values: new object[,]
                {
                    { 1, "En mäklarfirm med fokus på att göra drömmar till verklighet för kunder genom att matcha dem med sitt perfekta hem.", "Dream Home Realty", "URL" },
                    { 2, "Specialiserade på lyxiga och exklusiva fastigheter, erbjuder Elite Properties en förstklassig service för kunder som söker det bästa av det bästa.", "Elite Properties", "URL" },
                    { 3, "Med starka förbindelser och expertis inom fastighetsmarknaden, strävar Prime Real Estate Solutions efter att hjälpa kunder att hitta de mest lönsamma fastighetsaffärerna.", "Prime Real Estate Solutions", "URL" },
                    { 4, "Fokuserar på att skapa en \"näste\" åt sina kunder där de kan känna sig hemma och bekväma i den stadsmiljö de älskar.", "Urban Nest Realty", "URL" },
                    { 5, "Tar sina kunder till nya horisonter genom att guida dem genom köp- och säljprocessen med en personlig och professionell approach.", "Horizon Homes Real Estate", "URL" }
                });

            migrationBuilder.InsertData(
                table: "Realtors",
                columns: new[] { "RealtorId", "Email", "FirstName", "LastName", "PhoneNumber", "ProfilePictureURL", "RealtorFirmId" },
                values: new object[,]
                {
                    { 1, "sofia.andersson@example.com", "Sofia", "Andersson", "070-1234567", "URL", 1 },
                    { 2, "erik.svensson@example.com", "Erik", "Svensson", "073-9876543", "URL", 3 },
                    { 3, "emma.johansson@example.com", "Emma", "Johansson", "076-1112233", "URL", 2 },
                    { 4, "anders.karlsson@example.com", "Anders", "Karlsson", "072-5554441", "URL", 2 },
                    { 5, "linnea.lindgren@example.com", "Linnea", "Lindgren", "074-8889990", "URL", 5 }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "RegionId", "County", "Township" },
                values: new object[,]
                {
                    { 1, "Stockholm", "Sollentuna" },
                    { 2, "Uppsala", "Östhammar" },
                    { 3, "Jönköpings", "Gislaved" },
                    { 4, "Kalmar", "Torsås" },
                    { 5, "Blekinge", "Karlskrona" }
                });

            migrationBuilder.InsertData(
                table: "Residences",
                columns: new[] { "ResidenceId", "Address", "BiArea", "CategoryId", "ConstructionYear", "LandArea", "LivingArea", "MonthlyFee", "OperatingCost", "PictureListURL", "RealtorId", "RegionId", "ResidenceDescription", "RoomCount", "StartingPrice" },
                values: new object[,]
                {
                    { 1, "Sveavägen 42", 20, 1, 2004, 500, 120, 4000m, 50000m, "[\"https://gotenehus.se/app/uploads/2022/09/puff-vassholm-lada-1344x896.jpg\"]", 5, 1, "Modern lägenhet med öppen planlösning och balkong belägen i centrala stan.", 5, 2000000 },
                    { 2, "Storgatan 12", 30, 2, 2000, 0, 100, 6500m, 24500m, "[\"https://www.brahus.se/upload/house/1031629571.jpg\"]", 4, 2, "Charmigt radhus med trädgård och garage i lugnt bostadsområde nära naturen.", 3, 1250000 },
                    { 3, "Strandvägen 7", 0, 3, 2018, 1000, 250, 4250m, 32400m, "[\"https://hjaltevadshus.se/app/uploads/2022/10/nyckelfardiga-vitsippan.jpg\"]", 3, 3, "Funkisvilla med pool och havsutsikt på exklusiv adress vid kusten.", 6, 3000000 },
                    { 4, "Norra Vallgatan 14", 15, 4, 2009, 625, 130, 7000m, 31500m, "[\"https://www.osloguiden.se/wp-content/uploads/2015/04/Pilestredet.jpg\"]", 3, 2, "Gammal gård renoverad till lyxigt boende med generösa sällskapsytor och stor trädgård.", 4, 2230000 },
                    { 5, "Östra Hamngatan 3", 50, 5, 1972, 200, 120, 3750m, 20500m, "[\"https://www.ekonomifokus.se/wp-content/uploads/2019/01/Vad-ingar-vid-kop-och-salj-av-fastighet-och-hus-e1547480095379.jpg\"]", 1, 5, "Lägenhet i nybyggd bostadsrättsförening med gemensam takterrass och närhet till shopping och kommunikationer.", 5, 1400000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Residences_CategoryId",
                table: "Residences",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_RealtorId",
                table: "Residences",
                column: "RealtorId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_RegionId",
                table: "Residences",
                column: "RegionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Firms");

            migrationBuilder.DropTable(
                name: "Residences");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Realtors");

            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
