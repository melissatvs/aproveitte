using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Aproveitte.Infra.Data.Migrations
{
    public partial class VersaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "receita",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receita", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "unidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<int>(maxLength: 40, nullable: false),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_unidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ingrediente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nome = table.Column<string>(maxLength: 100, nullable: false),
                    id_receita = table.Column<int>(nullable: false),
                    id_unidade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingrediente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ingrediente_receita_id_receita",
                        column: x => x.id_receita,
                        principalTable: "receita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ingrediente_unidade_id_unidade",
                        column: x => x.id_unidade,
                        principalTable: "unidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ingrediente_id_receita",
                table: "ingrediente",
                column: "id_receita");

            migrationBuilder.CreateIndex(
                name: "IX_ingrediente_id_unidade",
                table: "ingrediente",
                column: "id_unidade");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ingrediente");

            migrationBuilder.DropTable(
                name: "receita");

            migrationBuilder.DropTable(
                name: "unidade");
        }
    }
}
