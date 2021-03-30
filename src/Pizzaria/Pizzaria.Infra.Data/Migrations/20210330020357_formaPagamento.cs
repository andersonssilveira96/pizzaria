using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Infra.Data.Migrations
{
    public partial class formaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 955, DateTimeKind.Local).AddTicks(7817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 778, DateTimeKind.Local).AddTicks(7585));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "TipoPedido",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 996, DateTimeKind.Local).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 827, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 995, DateTimeKind.Local).AddTicks(279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 825, DateTimeKind.Local).AddTicks(5618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 992, DateTimeKind.Local).AddTicks(3016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 824, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 988, DateTimeKind.Local).AddTicks(6201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 820, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 959, DateTimeKind.Local).AddTicks(8302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 786, DateTimeKind.Local).AddTicks(194));

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 993, DateTimeKind.Local).AddTicks(6956)),
                    UsuarioInclusaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 778, DateTimeKind.Local).AddTicks(7585),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 955, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "TipoPedido",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 827, DateTimeKind.Local).AddTicks(1558),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 996, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 825, DateTimeKind.Local).AddTicks(5618),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 995, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 824, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 992, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 820, DateTimeKind.Local).AddTicks(524),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 988, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 28, 0, 23, 28, 786, DateTimeKind.Local).AddTicks(194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 959, DateTimeKind.Local).AddTicks(8302));
        }
    }
}
