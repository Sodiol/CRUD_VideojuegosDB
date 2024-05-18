using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Videojuegos.Migrations
{
    /// <inheritdoc />
    public partial class JuegosVen2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ventas_Juegos_JuegoId",
                table: "ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ventas",
                table: "ventas");

            migrationBuilder.RenameTable(
                name: "ventas",
                newName: "Ventas");

            migrationBuilder.RenameIndex(
                name: "IX_ventas_JuegoId",
                table: "Ventas",
                newName: "IX_Ventas_JuegoId");

            migrationBuilder.AlterColumn<int>(
                name: "JuegoId",
                table: "Ventas",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VentaId",
                table: "Juegos",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_VentaId",
                table: "Juegos",
                column: "VentaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Ventas_VentaId",
                table: "Juegos",
                column: "VentaId",
                principalTable: "Ventas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventas_Juegos_JuegoId",
                table: "Ventas",
                column: "JuegoId",
                principalTable: "Juegos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Ventas_VentaId",
                table: "Juegos");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventas_Juegos_JuegoId",
                table: "Ventas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ventas",
                table: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_VentaId",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "VentaId",
                table: "Juegos");

            migrationBuilder.RenameTable(
                name: "Ventas",
                newName: "ventas");

            migrationBuilder.RenameIndex(
                name: "IX_Ventas_JuegoId",
                table: "ventas",
                newName: "IX_ventas_JuegoId");

            migrationBuilder.AlterColumn<int>(
                name: "JuegoId",
                table: "ventas",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ventas",
                table: "ventas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ventas_Juegos_JuegoId",
                table: "ventas",
                column: "JuegoId",
                principalTable: "Juegos",
                principalColumn: "Id");
        }
    }
}
