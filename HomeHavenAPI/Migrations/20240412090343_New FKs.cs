using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class NewFKs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Residences",
                newName: "ResidenceId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Regions",
                newName: "RegionId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Firms",
                newName: "BrokerageFirmId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Brokers",
                newName: "BrokerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ResidenceId",
                table: "Residences",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RegionId",
                table: "Regions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BrokerageFirmId",
                table: "Firms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BrokerId",
                table: "Brokers",
                newName: "Id");
        }
    }
}
