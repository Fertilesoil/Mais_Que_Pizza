using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MaisQuePizza.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_categoria",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_categoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_pizzas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Borda = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Tamanho = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal (8,2)", nullable: false),
                    CategoriaId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_pizzas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_pizzas_tb_categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "tb_categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_pizzas_CategoriaId",
                table: "tb_pizzas",
                column: "CategoriaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_pizzas");

            migrationBuilder.DropTable(
                name: "tb_categoria");
        }
    }
}
