﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CaducaRest.Migrations
{
    /// <summary>
    /// Migración
    /// </summary>
    public partial class Clientes : Migration
    {
        /// <summary>
        /// Migración
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                      .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    //.Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Clave = table.Column<int>(nullable: false),
                    RFC = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    RazonSocial = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    NombreComercial = table.Column<string>(type: "VARCHAR(250)", nullable: false),
                    Direccion = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(150)", nullable: true),
                    Telefono = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Celular = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    SitioWeb = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    Activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });
        }

        /// <summary>
        /// Migración
        /// </summary>
        /// <param name="migrationBuilder"></param>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Producto",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Categoria",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
        }
    }
}
