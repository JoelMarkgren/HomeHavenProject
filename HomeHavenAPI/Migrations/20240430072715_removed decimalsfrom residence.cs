using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeHavenAPI.Migrations
{
    /// <inheritdoc />
    public partial class removeddecimalsfromresidence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "OperatingCost",
                table: "Residences",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "MonthlyFee",
                table: "Residences",
                type: "int",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 1,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 4000, 50000 });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 2,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 6500, 24500 });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 3,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 4250, 32400 });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 4,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 7000, 31500 });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 5,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 3750, 20500 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "OperatingCost",
                table: "Residences",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "MonthlyFee",
                table: "Residences",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 1,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 4000m, 50000m });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 2,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 6500m, 24500m });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 3,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 4250m, 32400m });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 4,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 7000m, 31500m });

            migrationBuilder.UpdateData(
                table: "Residences",
                keyColumn: "ResidenceId",
                keyValue: 5,
                columns: new[] { "MonthlyFee", "OperatingCost" },
                values: new object[] { 3750m, 20500m });
        }
    }
}
