using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Infra.Data.Migrations
{
    public partial class statusPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 276, DateTimeKind.Local).AddTicks(6073),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 955, DateTimeKind.Local).AddTicks(7817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "TipoPedido",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 322, DateTimeKind.Local).AddTicks(6043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 996, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 320, DateTimeKind.Local).AddTicks(4671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 995, DateTimeKind.Local).AddTicks(279));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "FormaPagamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 319, DateTimeKind.Local).AddTicks(216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 993, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 317, DateTimeKind.Local).AddTicks(5166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 992, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 312, DateTimeKind.Local).AddTicks(7990),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 988, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 280, DateTimeKind.Local).AddTicks(1113),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 959, DateTimeKind.Local).AddTicks(8302));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 955, DateTimeKind.Local).AddTicks(7817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 276, DateTimeKind.Local).AddTicks(6073));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "TipoPedido",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 996, DateTimeKind.Local).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 322, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 995, DateTimeKind.Local).AddTicks(279),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 320, DateTimeKind.Local).AddTicks(4671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "FormaPagamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 993, DateTimeKind.Local).AddTicks(6956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 319, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 992, DateTimeKind.Local).AddTicks(3016),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 317, DateTimeKind.Local).AddTicks(5166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 988, DateTimeKind.Local).AddTicks(6201),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 312, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 29, 23, 3, 56, 959, DateTimeKind.Local).AddTicks(8302),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 29, 23, 39, 48, 280, DateTimeKind.Local).AddTicks(1113));
        }
    }
}
