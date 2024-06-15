using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_add_CellDetailandCellBox : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CellBoxId",
                table: "CellDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CellDetails_CellBoxId",
                table: "CellDetails",
                column: "CellBoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_CellDetails_CellBoxes_CellBoxId",
                table: "CellDetails",
                column: "CellBoxId",
                principalTable: "CellBoxes",
                principalColumn: "CellBoxId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CellDetails_CellBoxes_CellBoxId",
                table: "CellDetails");

            migrationBuilder.DropIndex(
                name: "IX_CellDetails_CellBoxId",
                table: "CellDetails");

            migrationBuilder.DropColumn(
                name: "CellBoxId",
                table: "CellDetails");
        }
    }
}
