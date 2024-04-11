using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class CategoryControllerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureList",
                table: "Residences",
                newName: "PictureListURL");

            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Firms",
                newName: "LogoURL");

            migrationBuilder.RenameColumn(
                name: "ProfilePicture",
                table: "Brokers",
                newName: "ProfilePictureURL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PictureListURL",
                table: "Residences",
                newName: "PictureList");

            migrationBuilder.RenameColumn(
                name: "LogoURL",
                table: "Firms",
                newName: "Logo");

            migrationBuilder.RenameColumn(
                name: "ProfilePictureURL",
                table: "Brokers",
                newName: "ProfilePicture");
        }
    }
}
