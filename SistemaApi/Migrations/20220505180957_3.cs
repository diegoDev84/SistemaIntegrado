using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaApi.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeleEntrega",
                table: "Pedidos");

            migrationBuilder.AddColumn<string>(
                name: "TipoPedido",
                table: "Pedidos",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoPedido",
                table: "Pedidos");

            migrationBuilder.AddColumn<bool>(
                name: "TeleEntrega",
                table: "Pedidos",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

        }
    }
}
