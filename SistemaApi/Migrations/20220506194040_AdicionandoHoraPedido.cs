using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaApi.Migrations
{
    public partial class AdicionandoHoraPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataPedido",
                table: "Pedidos",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataPedido",
                table: "Pedidos");
        }
    }
}
