using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Infra.Data.Migrations
{
    public partial class rmimagemprod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Produto");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 186, DateTimeKind.Local).AddTicks(2575),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 14, 984, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 228, DateTimeKind.Local).AddTicks(3213),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 33, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 226, DateTimeKind.Local).AddTicks(5553),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 31, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 222, DateTimeKind.Local).AddTicks(1695),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 28, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 189, DateTimeKind.Local).AddTicks(4461),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 14, 994, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.AddColumn<string>(
                name: "Icone",
                table: "Categoria",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Icone",
                table: "Categoria");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 14, 984, DateTimeKind.Local).AddTicks(6179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 186, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Produto",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 33, DateTimeKind.Local).AddTicks(8855),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 228, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Produto",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 31, DateTimeKind.Local).AddTicks(8886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 226, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 28, DateTimeKind.Local).AddTicks(340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 222, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Categoria",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 14, 994, DateTimeKind.Local).AddTicks(1059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 24, 21, 34, 44, 189, DateTimeKind.Local).AddTicks(4461));
        }
    }
}
