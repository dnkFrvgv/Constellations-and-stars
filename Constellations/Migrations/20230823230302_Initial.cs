using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Constellations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Constellations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Hemisphere = table.Column<string>(type: "TEXT", nullable: true),
                    Quadrant = table.Column<string>(type: "TEXT", nullable: true),
                    NumberOfStars = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constellations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvolutionaryStages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Definition = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolutionaryStages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SpectralClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SpectralType = table.Column<char>(type: "TEXT", nullable: false),
                    IntrinsicColour = table.Column<string>(type: "TEXT", nullable: true),
                    SurfaceTemperatureStartKelvin = table.Column<float>(type: "REAL", nullable: false),
                    SurfaceTemperatureEndKelvin = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpectralClassifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    ShortName = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    ConstallationId = table.Column<int>(type: "INTEGER", nullable: false),
                    ConstellationId = table.Column<int>(type: "INTEGER", nullable: true),
                    SpectralClassificationId = table.Column<int>(type: "INTEGER", nullable: false),
                    EvolutionaryStageId = table.Column<int>(type: "INTEGER", nullable: false),
                    TemperatureKelvin = table.Column<float>(type: "REAL", nullable: false),
                    AbsoluteMagnitude = table.Column<float>(type: "REAL", nullable: false),
                    ApparentMagnitude = table.Column<float>(type: "REAL", nullable: false),
                    SolarMass = table.Column<float>(type: "REAL", nullable: false),
                    AgeMillionYrs = table.Column<float>(type: "REAL", nullable: false),
                    Luminosity = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stars_Constellations_ConstellationId",
                        column: x => x.ConstellationId,
                        principalTable: "Constellations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stars_EvolutionaryStages_EvolutionaryStageId",
                        column: x => x.EvolutionaryStageId,
                        principalTable: "EvolutionaryStages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stars_SpectralClassifications_SpectralClassificationId",
                        column: x => x.SpectralClassificationId,
                        principalTable: "SpectralClassifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stars_ConstellationId",
                table: "Stars",
                column: "ConstellationId");

            migrationBuilder.CreateIndex(
                name: "IX_Stars_EvolutionaryStageId",
                table: "Stars",
                column: "EvolutionaryStageId");

            migrationBuilder.CreateIndex(
                name: "IX_Stars_SpectralClassificationId",
                table: "Stars",
                column: "SpectralClassificationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stars");

            migrationBuilder.DropTable(
                name: "Constellations");

            migrationBuilder.DropTable(
                name: "EvolutionaryStages");

            migrationBuilder.DropTable(
                name: "SpectralClassifications");
        }
    }
}
