using Microsoft.EntityFrameworkCore.Migrations;

namespace Aproveitte.Infra.Data.Migrations
{
    public partial class Versao01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "unidade",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 40);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "nome",
                table: "unidade",
                type: "int",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }
    }
}
