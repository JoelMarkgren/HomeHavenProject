using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedsomeseeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 1,
                column: "PictureListURL",
                value: "[\"https://gotenehus.se/app/uploads/2022/09/puff-vassholm-lada-1344x896.jpg\",\"https://cdn.decoist.com/wp-content/uploads/2014/08/Indoor-blossoms-in-a-modern-living-room.jpg\",\"https://i.ytimg.com/vi/w3zIjcnyaJs/maxresdefault.jpg\"]");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 1,
                column: "PictureListURL",
                value: "[\"https://gotenehus.se/app/uploads/2022/09/puff-vassholm-lada-1344x896.jpg\"]");
        }
    }
}
