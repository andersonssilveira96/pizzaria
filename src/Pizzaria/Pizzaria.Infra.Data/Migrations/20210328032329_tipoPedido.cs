using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Infra.Data.Migrations
{
    public partial class tipoPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 778, DateTimeKind.Local).AddTicks(7585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 186, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 825, DateTimeKind.Local).AddTicks(5618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 228, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 824, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 226, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 820, DateTimeKind.Local).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 222, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 786, DateTimeKind.Local).AddTicks(194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 189, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.CreateTable(
                name: "TipoPedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 827, DateTimeKind.Local).AddTicks(1558)),
                    UsuarioInclusaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPedido", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TipoPedido");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 186, DateTimeKind.Local).AddTicks(2575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 778, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 228, DateTimeKind.Local).AddTicks(3213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 825, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 226, DateTimeKind.Local).AddTicks(5553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 824, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 222, DateTimeKind.Local).AddTicks(1695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 820, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 189, DateTimeKind.Local).AddTicks(4461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 786, DateTimeKind.Local).AddTicks(194));
        }
    }
}
