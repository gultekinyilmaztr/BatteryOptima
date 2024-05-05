using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class first_mig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CellDetails",
                columns: table => new
                {
                    CellDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestIR = table.Column<double>(type: "float", nullable: false),
                    TestVoltage = table.Column<double>(type: "float", nullable: false),
                    DateOfTest = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CellId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellDetails", x => x.CellDetailId);
                });

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
                    CellSerialNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalResistance = table.Column<double>(type: "float", nullable: false),
                    Voltage = table.Column<double>(type: "float", nullable: false),
                    DateOfMesurementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Statu = table.Column<bool>(type: "bit", nullable: false),
                    CellDetailId = table.Column<int>(type: "int", nullable: false),
                    ProducerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BatteryCells", x => x.BatteryCellId);
                    table.ForeignKey(
                        name: "FK_BatteryCells_CellDetails_CellDetailId",
                        column: x => x.CellDetailId,
                        principalTable: "CellDetails",
                        principalColumn: "CellDetailId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BatteryCells_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "ProducerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BatteryCells_CellDetailId",
                table: "BatteryCells",
                column: "CellDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_BatteryCells_ProducerId",
                table: "BatteryCells",
                column: "ProducerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BatteryCells");

            migrationBuilder.DropTable(
                name: "CellDetails");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
