using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pizzaria.Infra.Data.Migrations
{
    public partial class categoria : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 14, 984, DateTimeKind.Local).AddTicks(6179),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 15, 23, 30, 9, 201, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 31, DateTimeKind.Local).AddTicks(8886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 15, 23, 30, 9, 239, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 28, DateTimeKind.Local).AddTicks(340),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 15, 23, 30, 9, 235, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 23, 23, 28, 14, 994, DateTimeKind.Local).AddTicks(1059)),
                    UsuarioInclusaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categoria_Usuario_UsuarioInclusaoId",
                        column: x => x.UsuarioInclusaoId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false),
                    Imagem = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Ativo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    DataInclusao = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 33, DateTimeKind.Local).AddTicks(8855)),
                    UsuarioInclusaoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produto_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produto_Usuario_UsuarioInclusaoId",
                        column: x => x.UsuarioInclusaoId,
                        principalTable: "Usuario",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categoria_UsuarioInclusaoId",
                table: "Categoria",
                column: "UsuarioInclusaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produto",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_UsuarioInclusaoId",
                table: "Produto",
                column: "UsuarioInclusaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Usuario",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 23, 30, 9, 201, DateTimeKind.Local).AddTicks(4620),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 14, 984, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Endereco",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 23, 30, 9, 239, DateTimeKind.Local).AddTicks(3874),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 31, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataInclusao",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 3, 15, 23, 30, 9, 235, DateTimeKind.Local).AddTicks(6187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 3, 23, 23, 28, 15, 28, DateTimeKind.Local).AddTicks(340));
        }
    }
}
