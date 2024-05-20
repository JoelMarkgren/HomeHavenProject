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
                name: "FirmRequests",
                columns: table => new
                {
                    FirmRequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FromEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RealtorFirmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmRequests", x => x.FirmRequestId);
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
                values: new object[] { "e116f8a0-bfd5-43cc-b014-4ce2a2063664", null, "User", "USER" });

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
                    { 1, "Tillhör ej någon mäklarfirma", "Ingen", "URL" },
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
                    { "3869a014-937b-4970-9021-3bb704bb10a2", 0, "4c285ee4-3d98-4894-a681-f27e3d3f9ec7", "linnea.lindgren@example.com", false, "Linnea", "Lindgren", false, null, null, null, null, "074-8889990", false, null, 5, "ef9f1d1d-2dbd-4c1a-914b-9dbf4b01c805", false, null },
                    { "60205c1a-ef79-44ac-89b2-ac75176e3408", 0, "46d7623d-72ae-4c1e-a1fd-449361b15450", "emma.johansson@example.com", false, "Emma", "Johansson", false, null, null, null, null, "076-1112233", false, null, 2, "dcefd990-982c-420b-b391-ae8927e3ccb6", false, null },
                    { "9dcb614e-6280-4101-ae5a-875d51e33480", 0, "3a5df987-cb47-47a7-b82b-4823fa9797e0", "anders.karlsson@example.com", false, "Anders", "Karlsson", false, null, null, null, null, "072-5554441", false, "https://www.creativefabrica.com/wp-content/uploads/2023/05/23/Bearded-man-avatar-Generic-male-profile-Graphics-70342414-1.png", 4, "5b5f9e5e-47ba-4797-a103-8b891f7f18b9", false, null },
                    { "ac31313d-d278-43d9-a72d-39fc96dc2e92", 0, "5b2c55da-3662-4b57-9088-1df86cc710ff", "sofia.andersson@example.com", false, "Sofia", "Andersson", false, null, null, null, null, "070-1234567", false, "https://www.feedingmatters.org/wp-content/uploads/2022/12/Generic-profile-pic.png", 2, "b1587c61-83f5-4e74-b3d7-db7b6f024bbc", false, null },
                    { "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 0, "f8191bdd-fd4a-4251-b66c-59234546190e", "erik.svensson@example.com", false, "Erik", "Svensson", false, null, null, null, null, "073-9876543", false, "https://st3.depositphotos.com/4060975/17707/v/450/depositphotos_177073010-stock-illustration-male-vector-icon.jpg", 3, "7a763fb4-2654-45a8-95e9-e834d766a9bf", false, null }
                });

            migrationBuilder.InsertData(
                table: "Residences",
                columns: new[] { "ResidenceId", "Address", "BiArea", "CategoryId", "ConstructionYear", "LandArea", "LivingArea", "MonthlyFee", "OperatingCost", "PictureListURL", "RealtorId", "RegionId", "ResidenceDescription", "RoomCount", "StartingPrice" },
                values: new object[,]
                {
                    { 1, "Sveavägen 42", 20, 1, 2004, 500, 120, 4000, 50000, "[\"https://gotenehus.se/app/uploads/2022/09/puff-vassholm-lada-1344x896.jpg\",\"https://cdn.decoist.com/wp-content/uploads/2014/08/Indoor-blossoms-in-a-modern-living-room.jpg\",\"https://homejab.com/wp-content/uploads/2021/11/https-__realtor.homejab.com_wp-content_uploads_2021_10_1906_Santa_Clara_Ave__Alameda__CA_94501__USA-20210131235707.jpg\"]", "ac31313d-d278-43d9-a72d-39fc96dc2e92", 1, "Letar du efter en villa där du kan flytta rakt in utan att behöva renovera? \r\nDå ska du spana in denna trevliga 2-plansvilla som har genomgått en totalrenovering de senaste åren. Belägen på den generösa hörntomten erbjuds utrymme för odling, avkoppling och umgänge med familj och vänner på uteplatser i flera vädersträck. \r\nNjut av bekvämligheter som fjärrvärme, fiber och en carport som skyddar bilen mot väder och vind.\r\nVillan är besiktigad och besiktningsprotokollet finner du bilagt i annonsen.\r\nTa chansen att uppleva detta trevliga hus - välkommen att boka dig på visning!", 5, 2000000 },
                    { 2, "Storgatan 12", 30, 1, 2000, 0, 100, 6500, 24500, "[\"https://bilder.hemnet.se/images/1024x/6d/e1/6de128c921bb2a0995de33a177fd7bdb.jpg\",\"https://bilder.hemnet.se/images/1024x/ba/02/ba0287abadb206747f13f9dce44ae0da.jpg\",\"https://bilder.hemnet.se/images/1024x/ce/55/ce55b3f6d283f55579312a806f02c0f8.jpg\",\"https://bilder.hemnet.se/images/1024x/dd/57/dd578b3d87879ecdb89fa2a4e0fdfd27.jpg\",\"https://bilder.hemnet.se/images/1024x/15/ef/15efb48083ba66b6dc1a5395b1b8cd8d.jpg\"]", "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 2, "Letar du efter en villa där du kan flytta rakt in utan att behöva renovera? \r\nDå ska du spana in denna trevliga 2-plansvilla som har genomgått en totalrenovering de senaste åren. Belägen på den generösa hörntomten erbjuds utrymme för odling, avkoppling och umgänge med familj och vänner på uteplatser i flera vädersträck. \r\nNjut av bekvämligheter som fjärrvärme, fiber och en carport som skyddar bilen mot väder och vind.\r\nVillan är besiktigad och besiktningsprotokollet finner du bilagt i annonsen.\r\nTa chansen att uppleva detta trevliga hus - välkommen att boka dig på visning!", 3, 1250000 },
                    { 3, "Strandvägen 7", 0, 2, 2018, 1000, 250, 4250, 32400, "[\"https://bilder.hemnet.se/images/1024x/82/ef/82ef5b32d254189c566c4bb6e16139ba.jpg\",\"https://bilder.hemnet.se/images/1024x/03/a3/03a35f482b889f513c3303b5f8d32c47.jpg\",\"https://bilder.hemnet.se/images/1024x/09/ba/09ba42eac3e24be70df9ccfd0234f4b9.jpg\",\"https://bilder.hemnet.se/images/1024x/52/dc/52dc234a8326652e1c451dff24c5977d.jpg\",\"https://bilder.hemnet.se/images/1024x/81/1b/811bda81e4c8832f78b9f8450ba25a79.jpg\"]", "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 3, "Välkommen till denna trevliga bostadsrätt belägen i Riksbyggen Brf Björket i Kristianstad. Med en boyta på 84 kvadratmeter erbjuds här ett hem med två sovrum, rymligt vardagsrum, kök och matplats samt ett härligt inglasat uterum där man kan tillbringa många härliga dagar. Föreningen erbjuder trygghet och gemenskap samtidigt som man har närhet till stadens puls och service.\r\nBoendet på våningsplan ett passar perfekt för den som önskar ett lättillgängligt  boende med närhet till grönområden och promenadstråk i björket. \r\nVälkomna att kontakta mäklaren vid intresse! ", 6, 3000000 },
                    { 4, "Norra Vallgatan 14", 15, 3, 2009, 625, 130, 7000, 31500, "[\"https://bilder.hemnet.se/images/1024x/0c/a5/0ca567fe6f8edeab861615c89e193fb1.jpg\",\"https://bilder.hemnet.se/images/1024x/3a/8c/3a8cbdbe3459c82fabadf2300dac4892.jpg\",\"https://bilder.hemnet.se/images/1024x/59/ce/59ce80115fc1db27b1bb69e0c332d650.jpg\",\"https://bilder.hemnet.se/images/1024x/53/d1/53d1e3f8cc5663a224a6df69f1f6bc67.jpg\"]", "ac31313d-d278-43d9-a72d-39fc96dc2e92", 2, "Välkommen till Alfabetsvägen 52 och ett mycket tilltalande radhus i barnvänligt och populärt område! Entréplan rymmer ett stort kök med matplats, ett lättmöblerat vardagsrum, rymligt sovrum, modernt badrum med bastu och en praktisk tvättstuga. Ovanvåningen huserar fyra bra planerade sovrum och ett helkaklat badrum. Både fram- och baksida har härliga uteplatser med gott om utrymme för både loungemöbler och matmöblemang. Gräsmatta med plats för studsmatta, odlingar eller liknande på baksidan. Carport finns mittemot huset, extra p-plats och separat förråd. Här bor du nära både buss, förskola/skola, natur och flertalet stormarknader!\r\n", 4, 2230000 },
                    { 5, "Östra Hamngatan 3", 50, 3, 1972, 200, 120, 3750, 20500, "[\"https://bilder.hemnet.se/images/1024x/12/f5/12f553af156dc9976c7b017c52e579d9.jpg\",\"https://bilder.hemnet.se/images/1024x/18/5b/185b2966fb0ada2fb03f989fe9c45a22.jpg\",\"https://bilder.hemnet.se/images/1024x/a8/92/a89266955a44d70df2fe4a76651af4e1.jpg\",\"https://bilder.hemnet.se/images/1024x/73/fe/73fe58e7f6e8db52a07f9b224fa7ca08.jpg\"]", "ac31313d-d278-43d9-a72d-39fc96dc2e92", 5, "Sällsynt tillfälle att bli ägare till detta utmärkt planerade gavelradhus i två plan om ca 160 kvm i ett av Luthagens/Stabbys mest eftertraktade kvarter. Det här är ett perfekt hem för den växande familjen, med närhet till utmärkta förskolor och skolor i ett tryggt och barnvänligt område.\r\n\r\n\r\n\r\nRadhuset erbjuder rymlig hall som leder dig till ett ljust och luftigt vardagsrum med gott om ljusinsläpp genom de generösa fönstren. Ett funktionellt vinkelkök med stor matplats är perfekt för familjemiddagar. Uteplatser både på framsidan och baksidan ger dig möjlighet att njuta av solen från morgon till kväll. Huset rymmer totalt fem sovrum, varav två praktiskt placerade på entréplanet och tre på övre våningen. Master bedroom har dessutom en egen balkong där du kan njuta av ditt morgonkaffe. Ett stort allrum ger extra utrymme för familjens aktiviteter och kan enkelt omvandlas till ytterligare sovrum om så önskas. Dessutom finns två renoverade badrum för familjens bekvämlighet.\r\n\r\n\r\n\r\nUteplatsen på framsidan bjuder in till avkopplande stunder i eftermiddags- och kvällssolen, medan baksidans altan ger dig möjlighet att njuta av frukosten i solens första strålar. Den trevliga trädgården är perfekt för lek och rekreation, med gräsyta och fruktträd som ger trädgården extra charm. Du kommer att älska det trivsamma och omtyckta området med närhet till skogspromenader som ger glädje året runt, inklusive möjligheter till löprundor och skidåkning. Service som vårdcentral, restauranger, café och gym finns bara några kvarter bort vid Mimmi Ekholms plats. Närhet till förskolor och skolor gör vardagen smidig för hela familjen. Det här är verkligen ett hem som erbjuder både komfort och livskvalitet. Missa inte chansen att bli ägare till detta fantastiska radhus och skapa ditt drömboende för din familj.", 5, 1400000 },
                    { 6, "Kemigränd 12", 10, 2, 1998, 0, 90, 5200, 32000, "[\"https://www.maklarringen.se/contentassets/41cd42b001da48209ba3f20452da0e63/objektbilder/fasad?preset=ObjectImageListLarge\"]", "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 2, "Varmt välkomna till denna smakfulla och genomtänkta bostad placerad på ett idealiskt centrumnära läge. Med en kort promenad till stationsområdet är man alltid nära citys puls samtidigt som naturen är nära tack vare Bokhultets naturreservat och Växjösjön. Lägenhetens väl genomtänkta färg- och materialval genomsyrar hela bostaden och skapar en harmonisk och hemtrevlig känsla.\r\n\r\nHär erbjuds en bostad med välplanerad planlösning med öppna och sociala ytor som skapar rum för familj och vänner. Det generösa vardagsrummet har en öppen planlösning mot det stilrena köket och den trivsamma matplatsen. Vardagsrum och kök bildar tillsammans boendets hjärta. Från vardagsrummet når ni den väl tilltagna balkongen där man kan skapa sin egna gröna oas. Lägenhetens två sovrum erbjuder gott om plats både för säng och övrigt möblemang. Det helkaklade badrummet är rymligt och erbjuder en duschhörna. Här finns även en välutrustad tvätthörna med både tvättmaskin, torktumlare, arbetsbänk samt skåpsförvaring.", 4, 2100000 },
                    { 7, "Västra Grodgatan 2", 20, 1, 2017, 200, 240, 3750, 50000, "[\"https://assets-global.website-files.com/5fd75a3e2aa1abd3e9c84632/65cfb27503791a7b1edb8b3c_grand-villa-5-sterne-hotel-villa-contessa.webp\"]", "ac31313d-d278-43d9-a72d-39fc96dc2e92", 5, "Välkommen till detta fantastiska 1,5-planshus som ligger på en perfekt trädgårdstomt. Huset är noggrant planerat för att erbjuda både elegans och bekvämlighet. Du välkomnas av en praktisk entré med goda förvaringsmöjligheter. Det rymliga vardagsrummet har stora fönster som släpper in naturligt ljus och ger en fantastisk utsikt över trädgården. Det öppna köket är utrustat med toppmoderna apparater och generösa bänkytor, perfekt för både matlagning och socialt umgänge. på övre plan hittar vi ytterligare två sovrum och ett gemensamt badrum. Det finns även ett flexibelt utrymme som kan användas som kontor, bibliotek eller lekrum. Sovrummen på entréplanet är generösa och smakfullt inredda. Master bedroom har en egen utgång direkt till poolområdet. På baksidan av huset sträcker sig en soldränkt altan, perfekt för avkoppling och underhållning. Här finns gott om plats för utemöbler, en grillplats och en loungehörna. Altanen blickar ut över den välskötta trädgården och den inbjudande poolen.", 6, 1800000 },
                    { 8, "Biskopägen 23", 0, 3, 2002, 40, 120, 3750, 20500, "[\"https://tengbom.se/app/uploads/2017/03/07721-2000x1440.jpg\"]", "60205c1a-ef79-44ac-89b2-ac75176e3408", 3, "Nu har vi äntligen nöjet att presentera ett välrenoverat radhus om hela 125,5 kvm med en av de bästa hörntomterna i området. Bostaden har en öppen planlösning på entréplan, två badrum, separat tvättstuga samt fyra sovrum som samtliga är belägna på övre plan. Till höjdpunkterna hör dessutom en baksida med kvällssol. På baksidan finns ett inglasat uterum, trädäck samt stor trädgård med odlingsmöjligheter samt tre utvändiga förråd. 13 478 kr i inre reparationsfonden. Garage i länga som tillhör bostaden.\r\n\r\nHär bor du med närhet till bland annat skola, lekparker och en närbutik. För pendlaren är det endast 22 minuter in till Örebro och 10 min till Hallsberg. Ett perfekt boende för barnfamiljen!", 4, 1400000 },
                    { 9, "Teknologigatan 32", 55, 4, 2000, 100, 50, 14000, 10000, "[\"https://sp-ao.shortpixel.ai/client/to_webp,q_glossy,ret_img,w_760,h_500/https://www.borohus.se/wp-content/uploads/2022/04/1800x1300_forsta-tunet-760x500.jpg\"]", "3869a014-937b-4970-9021-3bb704bb10a2", 1, "Välkommen till detta charmiga fritidshushus om 33 kvadratmeter! Fridfullt och lugnt läge i växande Börtnäsheden.\r\nBostaden erbjuder välplanerade ytor med praktiskt kök, gott om förvaringsmöjligheter och fint ljusinsläpp. Vidare finns ett rymligt allrum, plats för både mat- och soffgrupp samt en rymlig sovalkov.\r\n\r\nTill fastigheten hör även en sovstuga med utrymme för flera sovplatser eller annat möblemang. Ytterligare en byggnad finns som inrymmer, förråd, bastu, dusch samt förbränningstoalett.\r\n\r\nHär har ni en trevlig tomt om 2451 kvm, välskött gräsmatta med många soltimmar och plats för lek.\r\n", 1, 1400000 },
                    { 10, "Aslövsgatan 3", 70, 1, 2015, 300, 250, 16000, 60000, "[\"https://static.wixstatic.com/media/d6d69b_3c2cf8100e304193bb5eed28a30db2dd~mv2.jpg/v1/fill/w_560,h_374,al_c,q_80,usm_0.66_1.00_0.01,enc_auto/%C2%A9%20P%C3%A5l%20Ross%20Villa%20Luciani%20Grand%20DesignFasad%20Blue%20Hour.jpg\"]", "e8411d7f-4c81-4e1a-92fc-1890db0e5b81", 4, "Här lever du bekvämt med villakänsla och med bostadsrättens trygghet och smidighet.\r\nMed uteplatser i två väderstreck är det lätt att följa både sol och skugga efter behag.\r\nFrån Kuggås strand leder strandpromenaden till Nynässerveringen med bland annat minigolf och musikkvällar. Strax där ovanför finns köpingen med den pittoreska Storgatan där butikerna ligger på rad.\r\n\r\nAlla lägenheter är byggd med den höga standard som GBJ Bygg erbjuder, till exempel parkettgolv i alla bostadsrum, fönsterbänkar i sten, helkaklade badrum samt golvvärme i hela bostaden.\r\nEgen parkeringsplats som är förberedd för att installera laddstolpe till elbilen på framsidan och på baksidan finns den stensatta uteplatsen som följer med köpet samt förrådet på cirka 10 m².", 7, 1900000 }
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
                name: "FirmRequests");

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
