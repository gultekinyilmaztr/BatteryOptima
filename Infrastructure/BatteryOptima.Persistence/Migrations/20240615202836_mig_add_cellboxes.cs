using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_cellboxes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CellBoxes",
                columns: table => new
                {
                    CellBoxId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CellBoxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellBoxes", x => x.CellBoxId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellBoxes");
        }
    }
}
