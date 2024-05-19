using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class monster3d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProducerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProducerNo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.ProducerId);
                });

            migrationBuilder.CreateTable(
                name: "BatteryCells",
                columns: table => new
                {
                    BatteryCellId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProducerId = table.Column<int>(type: "int", nullable: false),
                    CellSerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalResistance = table.Column<double>(type: "float", nullable: false),
                    Voltage = table.Column<double>(type: "float", nullable: false),
                    DateOfMesurementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statu = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryCells", x => x.BatteryCellId);
                    table.ForeignKey(
                        name: "FK_BatteryCells_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "ProducerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CellDetails",
                columns: table => new
                {
                    CellDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BatteryCellId = table.Column<int>(type: "int", nullable: false),
                    TestIR = table.Column<double>(type: "float", nullable: false),
                    TestVoltage = table.Column<double>(type: "float", nullable: false),
                    DateOfTest = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellDetails", x => x.CellDetailId);
                    table.ForeignKey(
                        name: "FK_CellDetails_BatteryCells_BatteryCellId",
                        column: x => x.BatteryCellId,
                        principalTable: "BatteryCells",
                        principalColumn: "BatteryCellId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteryCells_ProducerId",
                table: "BatteryCells",
                column: "ProducerId");

            migrationBuilder.CreateIndex(
                name: "IX_CellDetails_BatteryCellId",
                table: "CellDetails",
                column: "BatteryCellId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CellDetails");

            migrationBuilder.DropTable(
                name: "BatteryCells");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
