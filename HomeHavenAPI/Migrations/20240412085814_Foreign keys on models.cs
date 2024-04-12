using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class Foreignkeysonmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brokers_Firms_FirmId",
                table: "Brokers");

            migrationBuilder.DropForeignKey(
                name: "FK_Residences_Brokers_BrokerId",
                table: "Residences");

            migrationBuilder.DropForeignKey(
                name: "FK_Residences_Categories_CategoryId",
                table: "Residences");

            migrationBuilder.DropForeignKey(
                name: "FK_Residences_Regions_RegionId",
                table: "Residences");

            migrationBuilder.DropIndex(
                name: "IX_Residences_BrokerId",
                table: "Residences");

            migrationBuilder.DropIndex(
                name: "IX_Residences_CategoryId",
                table: "Residences");

            migrationBuilder.DropIndex(
                name: "IX_Residences_RegionId",
                table: "Residences");

            migrationBuilder.DropIndex(
                name: "IX_Brokers_FirmId",
                table: "Brokers");

            migrationBuilder.DropColumn(
                name: "FirmId",
                table: "Brokers");

            migrationBuilder.AddColumn<int>(
                name: "BrokerageFirmId",
                table: "Brokers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrokerageFirmId",
                table: "Brokers");

            migrationBuilder.AddColumn<int>(
                name: "FirmId",
                table: "Brokers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Residences_BrokerId",
                table: "Residences",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_CategoryId",
                table: "Residences",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Residences_RegionId",
                table: "Residences",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Brokers_FirmId",
                table: "Brokers",
                column: "FirmId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brokers_Firms_FirmId",
                table: "Brokers",
                column: "FirmId",
                principalTable: "Firms",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_Brokers_BrokerId",
                table: "Residences",
                column: "BrokerId",
                principalTable: "Brokers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_Categories_CategoryId",
                table: "Residences",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Residences_Regions_RegionId",
                table: "Residences",
                column: "RegionId",
                principalTable: "Regions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
