using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedmoreseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "RealtorFirmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "RealtorFirmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "RealtorFirmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "RealtorFirmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "RealtorFirmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "RealtorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "RealtorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "RealtorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "RealtorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Realtors",
                keyColumn: "RealtorId",
                keyValue: 5);
        }
    }
}
