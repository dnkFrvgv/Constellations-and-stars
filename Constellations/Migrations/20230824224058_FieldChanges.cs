using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Constellations.Migrations
{
    /// <inheritdoc />
    public partial class FieldChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TemperatureKelvin",
                table: "Stars",
                newName: "SurfaceTemperatureKelvin");

            migrationBuilder.AddColumn<double>(
                name: "ApproximateDistanceFromEarthLightYrs",
                table: "Stars",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApproximateDistanceFromEarthLightYrs",
                table: "Stars");

            migrationBuilder.RenameColumn(
                name: "SurfaceTemperatureKelvin",
                table: "Stars",
                newName: "TemperatureKelvin");
        }
    }
}
