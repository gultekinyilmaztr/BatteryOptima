using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BatteryOptima.Persistence.Migrations
{
    public partial class filter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseACellProcesses_BatteryCells_BatteryCellId",
                table: "UseACellProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_UseACellProcesses_Personnel_PersonnelId",
                table: "UseACellProcesses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UseACellProcesses",
                table: "UseACellProcesses");

            migrationBuilder.RenameTable(
                name: "UseACellProcesses",
                newName: "UseACellProcesses");

            migrationBuilder.RenameIndex(
                name: "IX_UseACellProcesses_PersonnelId",
                table: "UseACellProcesses",
                newName: "IX_UseACellProcesses_PersonnelId");

            migrationBuilder.RenameIndex(
                name: "IX_UseACellProcesses_BatteryCellId",
                table: "UseACellProcesses",
                newName: "IX_UseACellProcesses_BatteryCellId");

            // `CellDetailId` sütunu zaten var olduğu için ekleme işlemini kaldırın
            // migrationBuilder.AddColumn<int>(
            //     name: "CellDetailId",
            //     table: "UseACells",
            //     type: "int",
            //     nullable: false,
            //     defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CellBoxId",
                table: "UseACellProcesses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UseACellProcesses",
                table: "UseACellProcesses",
                column: "UseACellProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_UseACells_CellDetailId",
                table: "UseACells",
                column: "CellDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_UseACellProcesses_CellBoxId",
                table: "UseACellProcesses",
                column: "CellBoxId");

            migrationBuilder.AddForeignKey(
                name: "FK_UseACellProcesses_BatteryCells_BatteryCellId",
                table: "UseACellProcesses",
                column: "BatteryCellId",
                principalTable: "BatteryCells",
                principalColumn: "BatteryCellId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UseACellProcesses_CellBoxes_CellBoxId",
                table: "UseACellProcesses",
                column: "CellBoxId",
                principalTable: "CellBoxes",
                principalColumn: "CellBoxId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UseACellProcesses_Personnel_PersonnelId",
                table: "UseACellProcesses",
                column: "PersonnelId",
                principalTable: "Personnel",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);

            // `CellDetailId` kısıtlaması zaten var olduğu için ekleme işlemini kaldırın
            // migrationBuilder.AddForeignKey(
            //     name: "FK_UseACells_CellDetails_CellDetailId",
            //     table: "UseACells",
            //     column: "CellDetailId",
            //     principalTable: "CellDetails",
            //     principalColumn: "CellDetailId",
            //     onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UseACellProcesses_BatteryCells_BatteryCellId",
                table: "UseACellProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_UseACellProcesses_CellBoxes_CellBoxId",
                table: "UseACellProcesses");

            migrationBuilder.DropForeignKey(
                name: "FK_UseACellProcesses_Personnel_PersonnelId",
                table: "UseACellProcesses");

            // `CellDetailId` kısıtlaması zaten var olduğu için kaldırma işlemini ekleyin
            migrationBuilder.DropForeignKey(
                name: "FK_UseACells_CellDetails_CellDetailId",
                table: "UseACells");

            migrationBuilder.DropIndex(
                name: "IX_UseACells_CellDetailId",
                table: "UseACells");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UseACellProcesses",
                table: "UseACellProcesses");

            migrationBuilder.DropIndex(
                name: "IX_UseACellProcesses_CellBoxId",
                table: "UseACellProcesses");

            // `CellDetailId` sütunu zaten var olduğu için kaldırma işlemini ekleyin
            // migrationBuilder.DropColumn(
            //     name: "CellDetailId",
            //     table: "UseACells");

            migrationBuilder.DropColumn(
                name: "CellBoxId",
                table: "UseACellProcesses");

            migrationBuilder.RenameTable(
                name: "UseACellProcesses",
                newName: "UseACellProcess");

            migrationBuilder.RenameIndex(
                name: "IX_UseACellProcesses_PersonnelId",
                table: "UseACellProcess",
                newName: "IX_UseACellProcess_PersonnelId");

            migrationBuilder.RenameIndex(
                name: "IX_UseACellProcesses_BatteryCellId",
                table: "UseACellProcess",
                newName: "IX_UseACellProcess_BatteryCellId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UseACellProcess",
                table: "UseACellProcess",
                column: "UseACellProcessId");

            migrationBuilder.AddForeignKey(
                name: "FK_UseACellProcess_BatteryCells_BatteryCellId",
                table: "UseACellProcess",
                column: "BatteryCellId",
                principalTable: "BatteryCells",
                principalColumn: "BatteryCellId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UseACellProcess_Personnel_PersonnelId",
                table: "UseACellProcess",
                column: "PersonnelId",
                principalTable: "Personnel",
                principalColumn: "PersonnelId",
                onDelete: ReferentialAction.Cascade);
        }
    }

}

