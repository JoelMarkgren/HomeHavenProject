using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

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
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RealtorFirmId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfilePictureURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Firms_RealtorFirmId",
                        column: x => x.RealtorFirmId,
                        principalTable: "Firms",
                        principalColumn: "RealtorFirmId");
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    MonthlyFee = table.Column<int>(type: "int", nullable: true),
                    OperatingCost = table.Column<int>(type: "int", nullable: false),
                    ConstructionYear = table.Column<int>(type: "int", nullable: false),
                    PictureListURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    RealtorId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residences", x => x.ResidenceId);
                    table.ForeignKey(
                        name: "FK_Residences_AspNetUsers_RealtorId",
                        column: x => x.RealtorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residences_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residences_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "RegionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2e34c3eb-c353-4b69-9875-295a379a5c05", null, "User", "USER" });

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
                table: "Regions",
                columns: new[] { "RegionId", "County", "Township" },
                values: new object[,]
                {
                    { 1, "Stockholm", "Sollentuna" },
                    { 2, "Uppsala", "Östhammar" },
                    { 3, "Jönköpings", "Gislaved" },
                    { 4, "Kalmar", "Torsås" },
                    { 5, "Blekinge", "Karlskrona" },
                    { 6, "Västerbotten", "Umeå" },
                    { 7, "Stockholm", "Ekerö" },
                    { 8, "Jämtland", "Östersund" },
                    { 9, "Skåne", "Malmö" },
                    { 10, "Skåne", "Hörby" },
                    { 12, "Stockholm", "Järfälla" },
                    { 14, "Stockholm", "Botkyrka" },
                    { 15, "Stockholm", "Solna" },
                    { 16, "Stockholm", "Lidingö" },
                    { 17, "Uppsala", "Håbå" },
                    { 19, "Uppsala", "Knivsta" },
                    { 20, "Uppsala", "Enköping" },
                    { 21, "Uppsala", "Älvkarleby" },
                    { 22, "Uppsala", "Tierp" },
                    { 23, "Södermanland", "Vingåker" },
                    { 24, "Södermanland", "Gnesta" },
                    { 25, "Södermanland", "Nyköping" },
                    { 26, "Södermanland", "Oxelösund" },
                    { 27, "Södermanland", "Flen" },
                    { 28, "Södermanland", "Katrineholm" },
                    { 29, "Södermanland", "Eskilstuna" },
                    { 30, "Södermanland", "Strängnäs" },
                    { 31, "Södermanland", "Trosa" },
                    { 32, "Östergötland", "Ödeshög" },
                    { 33, "Östergötland", "Ydre" },
                    { 34, "Östergötland", "Kinda" },
                    { 35, "Östergötland", "Boxholm" },
                    { 36, "Östergötland", "Åtvidaberg" },
                    { 37, "Östergötland", "Finspång" },
                    { 38, "Östergötland", "Valdemarsvik" },
                    { 39, "Östergötland", "Linköping" },
                    { 41, "Östergötland", "Norrköping" },
                    { 42, "Östergötland", "Söderköping" },
                    { 43, "Östergötland", "Motala" },
                    { 44, "Östergötland", "Vadstena" },
                    { 45, "Östergötland", "Mjölby" },
                    { 46, "Jönköping", "Aneby" },
                    { 47, "Jönköping", "Gnosjö" },
                    { 48, "Jönköping", "Mullsjö" },
                    { 49, "Jönköping", "Habo" },
                    { 51, "Jönköping", "Vaggeryd" },
                    { 52, "Jönköping", "Jönköping" },
                    { 53, "Jönköping", "Nässjö" },
                    { 55, "Jönköping", "Sävsjö" },
                    { 56, "Jönköping", "Vetlanda" },
                    { 57, "Jönköping", "Eksjö" },
                    { 58, "Jönköping", "Tranås" },
                    { 59, "Kronoberg", "Uppvidinge" },
                    { 60, "Kronoberg", "Lessebo" },
                    { 61, "Kronoberg", "Tingsryd" },
                    { 62, "Kronoberg", "Alvesta" },
                    { 63, "Kronoberg", "Älmhult" },
                    { 64, "Kronoberg", "Markaryd" },
                    { 65, "Kronoberg", "Växsjö" },
                    { 66, "Kronoberg", "Ljungby" },
                    { 67, "Kalmar", "Högsby" },
                    { 68, "Uppsala", "Heby" },
                    { 69, "Uppsala", "Uppsala" },
                    { 70, "Kalmar", "Mörbylånga" },
                    { 71, "Kalmar", "Hultsfred" },
                    { 72, "Kalmar", "Mönsterås" },
                    { 73, "Kalmar", "Emmaboda" },
                    { 74, "Kalmar", "Kalmar" },
                    { 75, "Kalmar", "Nybro" },
                    { 76, "Kalmar", "Oskarshamn" },
                    { 77, "Kalmar", "Västervik" },
                    { 78, "Kalmar", "Vimmerby" },
                    { 79, "Kalmar", "Borgholm" },
                    { 80, "Gotland", "Gotland" },
                    { 81, "Blekinge", "Olofström" },
                    { 82, "Blekinge", "Ronneby" },
                    { 83, "Blekinge", "Karlshamn" },
                    { 84, "Blekinge", "Sölvesborg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureURL", "RealtorFirmId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3869a014-937b-4970-9021-3bb704bb10a2", 0, "82af0c9d-b174-442b-8709-b2739fb98a41", "linnea.lindgren@example.com", false, "Linnea", "Lindgren", false, null, null, null, null, "074-8889990", false, "URL", 5, "9ee5618a-ca20-4f8a-8c9f-0047c0450065", false, null },
                    { "60205c1a-ef79-44ac-89b2-ac75176e3408", 0, "94c72f89-80eb-4e2f-8486-e3d2db130f13", "emma.johansson@example.com", false, "Emma", "Johansson", false, null, null, null, null, "076-1112233", false, "URL", 2, "4878136c-b195-4733-add8-0c242df4e3ac", false, null },
                    { "9dcb614e-6280-4101-ae5a-875d51e33480", 0, "2fd0db46-439c-4b0d-bfec-63a558e5026d", "anders.karlsson@example.com", false, "Anders", "Karlsson", false, null, null, null, null, "072-5554441", false, "URL", 2, "0c0a73f2-93db-4c53-9fd7-a7bc15dfd4db", false, null },
                    { "ac31313d-d278-43d9-a72d-39fc96dc2e92", 0, "e4f4280f-47fd-4330-94b9-14d3eb2a1b15", "sofia.andersson@example.com", false, "Sofia", "Andersson", false, null, null, null, null, "070-1234567", false, "URL", 1, "2884ae91-2b93-4a28-9cf1-401a448b619c", false, null },
                    { "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 0, "8e4fb207-d316-41c7-b0e6-e44b2a4089ad", "erik.svensson@example.com", false, "Erik", "Svensson", false, null, null, null, null, "073-9876543", false, "URL", 3, "79b7b909-2b3e-435b-8ef6-8672a8298285", false, null }
                });

            migrationBuilder.InsertData(
                table: "Residences",
                columns: new[] { "ResidenceId", "Address", "BiArea", "CategoryId", "ConstructionYear", "LandArea", "LivingArea", "MonthlyFee", "OperatingCost", "PictureListURL", "RealtorId", "RegionId", "ResidenceDescription", "RoomCount", "StartingPrice" },
                values: new object[,]
                {
                    { 1, "Sveavägen 42", 20, 1, 2004, 500, 120, 4000, 50000, "[\"https://gotenehus.se/app/uploads/2022/09/puff-vassholm-lada-1344x896.jpg\",\"https://cdn.decoist.com/wp-content/uploads/2014/08/Indoor-blossoms-in-a-modern-living-room.jpg\",\"https://homejab.com/wp-content/uploads/2021/11/https-__realtor.homejab.com_wp-content_uploads_2021_10_1906_Santa_Clara_Ave__Alameda__CA_94501__USA-20210131235707.jpg\"]", "ac31313d-d278-43d9-a72d-39fc96dc2e92", 1, "Modern lägenhet med öppen planlösning och balkong belägen i centrala stan.", 5, 2000000 },
                    { 2, "Storgatan 12", 30, 2, 2000, 0, 100, 6500, 24500, "[\"https://www.brahus.se/upload/house/1031629571.jpg\"]", "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 2, "Charmigt radhus med trädgård och garage i lugnt bostadsområde nära naturen.", 3, 1250000 },
                    { 3, "Strandvägen 7", 0, 3, 2018, 1000, 250, 4250, 32400, "[\"https://hjaltevadshus.se/app/uploads/2022/10/nyckelfardiga-vitsippan.jpg\"]", "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 3, "Funkisvilla med pool och havsutsikt på exklusiv adress vid kusten.", 6, 3000000 },
                    { 4, "Norra Vallgatan 14", 15, 4, 2009, 625, 130, 7000, 31500, "[\"https://www.osloguiden.se/wp-content/uploads/2015/04/Pilestredet.jpg\"]", "ac31313d-d278-43d9-a72d-39fc96dc2e92", 2, "Gammal gård renoverad till lyxigt boende med generösa sällskapsytor och stor trädgård.", 4, 2230000 },
                    { 5, "Östra Hamngatan 3", 50, 5, 1972, 200, 120, 3750, 20500, "[\"https://www.ekonomifokus.se/wp-content/uploads/2019/01/Vad-ingar-vid-kop-och-salj-av-fastighet-och-hus-e1547480095379.jpg\"]", "ac31313d-d278-43d9-a72d-39fc96dc2e92", 5, "Lägenhet i nybyggd bostadsrättsförening med gemensam takterrass och närhet till shopping och kommunikationer.", 5, 1400000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RealtorFirmId",
                table: "AspNetUsers",
                column: "RealtorFirmId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Residences");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Firms");
        }
    }
}
