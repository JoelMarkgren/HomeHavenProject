using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class SmallModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RegionName",
                table: "Regions",
                newName: "Township");

            migrationBuilder.AddColumn<string>(
                name: "County",
                table: "Regions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "County",
                table: "Regions");

            migrationBuilder.RenameColumn(
                name: "Township",
                table: "Regions",
                newName: "RegionName");
        }
    }
}
