using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Infra.Data.Migrations
{
    public partial class statusPedido2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 510, DateTimeKind.Local).AddTicks(2756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 276, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "TipoPedido",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 551, DateTimeKind.Local).AddTicks(8123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 322, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 549, DateTimeKind.Local).AddTicks(762),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 320, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "FormaPagamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 547, DateTimeKind.Local).AddTicks(6518),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 319, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 546, DateTimeKind.Local).AddTicks(1577),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 317, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 542, DateTimeKind.Local).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 312, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 513, DateTimeKind.Local).AddTicks(1012),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 280, DateTimeKind.Local).AddTicks(1113));

            migrationBuilder.CreateTable(
                name: "StatusPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 550, DateTimeKind.Local).AddTicks(5109)),
                    UsuarioInclusaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusPedido", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StatusPedido");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 276, DateTimeKind.Local).AddTicks(6073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 510, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "TipoPedido",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 322, DateTimeKind.Local).AddTicks(6043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 551, DateTimeKind.Local).AddTicks(8123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 320, DateTimeKind.Local).AddTicks(4671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 549, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "FormaPagamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 319, DateTimeKind.Local).AddTicks(216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 547, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 317, DateTimeKind.Local).AddTicks(5166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 546, DateTimeKind.Local).AddTicks(1577));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 312, DateTimeKind.Local).AddTicks(7990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 542, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 280, DateTimeKind.Local).AddTicks(1113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 42, 28, 513, DateTimeKind.Local).AddTicks(1012));
        }
    }
}
