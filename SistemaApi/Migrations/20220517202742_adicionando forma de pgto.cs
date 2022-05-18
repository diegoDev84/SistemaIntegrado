using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaApi.Migrations
{
    public partial class adicionandoformadepgto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FormaPagamento",
                table: "Pedidos",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaPagamento",
                table: "Pedidos");
        }
    }
}
