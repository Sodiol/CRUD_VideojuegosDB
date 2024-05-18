using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Videojuegos.Migrations
{
    /// <inheritdoc />
    public partial class JuegosCat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Juegos");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Juegos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Juegos_CategoriaId",
                table: "Juegos",
                column: "CategoriaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Juegos_Categorias_CategoriaId",
                table: "Juegos",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Juegos_Categorias_CategoriaId",
                table: "Juegos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropIndex(
                name: "IX_Juegos_CategoriaId",
                table: "Juegos");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Juegos");

            migrationBuilder.AddColumn<string>(
                name: "Categoria",
                table: "Juegos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
