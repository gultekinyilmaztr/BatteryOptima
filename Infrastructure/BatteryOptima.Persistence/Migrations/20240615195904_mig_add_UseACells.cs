using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_UseACells : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "UseACells",
                columns: table => new
                {
                    UseACellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickUpLocationId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    BatteryCellId = table.Column<int>(type: "int", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UseACells", x => x.UseACellId);
                    table.ForeignKey(
                        name: "FK_UseACells_BatteryCells_BatteryCellId",
                        column: x => x.BatteryCellId,
                        principalTable: "BatteryCells",
                        principalColumn: "BatteryCellId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UseACells_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UseACells_BatteryCellId",
                table: "UseACells",
                column: "BatteryCellId");

            migrationBuilder.CreateIndex(
                name: "IX_UseACells_LocationId",
                table: "UseACells",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UseACells");

            migrationBuilder.DropTable(
                name: "Location");
        }
    }
}
