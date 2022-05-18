using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaApi.Migrations
{
    public partial class adicionandonomeaosPedidos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Pedidos",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Pedidos");
        }
    }
}
