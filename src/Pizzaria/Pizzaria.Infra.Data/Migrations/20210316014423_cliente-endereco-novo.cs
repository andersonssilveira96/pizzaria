using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Infra.Data.Migrations
{
    public partial class clienteendereconovo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 22, 44, 23, 30, DateTimeKind.Local).AddTicks(6122),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 15, 19, 59, 50, 416, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.AlterColumn<string>(
                name: "CEP",
                table: "Endereco",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Endereco",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 22, 44, 23, 72, DateTimeKind.Local).AddTicks(4102));

            migrationBuilder.AddColumn<int>(
                name: "UsuarioInclusaoId",
                table: "Endereco",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 22, 44, 23, 67, DateTimeKind.Local).AddTicks(3216),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 15, 19, 59, 50, 448, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_UsuarioInclusaoId",
                table: "Endereco",
                column: "UsuarioInclusaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Usuario_UsuarioInclusaoId",
                table: "Endereco",
                column: "UsuarioInclusaoId",
                principalTable: "Usuario",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Usuario_UsuarioInclusaoId",
                table: "Endereco");

            migrationBuilder.DropIndex(
                name: "IX_Endereco_UsuarioInclusaoId",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "DataInclusao",
                table: "Endereco");

            migrationBuilder.DropColumn(
                name: "UsuarioInclusaoId",
                table: "Endereco");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 19, 59, 50, 416, DateTimeKind.Local).AddTicks(1170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 15, 22, 44, 23, 30, DateTimeKind.Local).AddTicks(6122));

            migrationBuilder.AlterColumn<int>(
                name: "CEP",
                table: "Endereco",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 19, 59, 50, 448, DateTimeKind.Local).AddTicks(191),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 15, 22, 44, 23, 67, DateTimeKind.Local).AddTicks(3216));
        }
    }
}
