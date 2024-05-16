using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class producerremovecelldetail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CellDetails_Producers_ProducerId",
                table: "CellDetails");

            migrationBuilder.DropIndex(
                name: "IX_CellDetails_ProducerId",
                table: "CellDetails");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "CellDetails");

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "BatteryCells",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BatteryCells_ProducerId",
                table: "BatteryCells",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_BatteryCells_Producers_ProducerId",
                table: "BatteryCells",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "ProducerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BatteryCells_Producers_ProducerId",
                table: "BatteryCells");

            migrationBuilder.DropIndex(
                name: "IX_BatteryCells_ProducerId",
                table: "BatteryCells");

            migrationBuilder.DropColumn(
                name: "ProducerId",
                table: "BatteryCells");

            migrationBuilder.AddColumn<int>(
                name: "ProducerId",
                table: "CellDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CellDetails_ProducerId",
                table: "CellDetails",
                column: "ProducerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CellDetails_Producers_ProducerId",
                table: "CellDetails",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "ProducerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
