using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SGLE.InfraStructure.Migrations
{
    public partial class ConfiguraClassesArbitroAssistenteAtleta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Atleta",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Assistente",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altura",
                table: "Assistente",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,5)");

            migrationBuilder.AddColumn<int>(
                name: "ArbitroId",
                table: "Assistente",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Arbitro",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,5)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altura",
                table: "Arbitro",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "numeric(10,5)");

            migrationBuilder.CreateIndex(
                name: "IX_Assistente_ArbitroId",
                table: "Assistente",
                column: "ArbitroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Assistente_Arbitro_ArbitroId",
                table: "Assistente",
                column: "ArbitroId",
                principalTable: "Arbitro",
                principalColumn: "ArbitroId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assistente_Arbitro_ArbitroId",
                table: "Assistente");

            migrationBuilder.DropIndex(
                name: "IX_Assistente_ArbitroId",
                table: "Assistente");

            migrationBuilder.DropColumn(
                name: "ArbitroId",
                table: "Assistente");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Atleta",
                type: "numeric(10,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Assistente",
                type: "numeric(10,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altura",
                table: "Assistente",
                type: "numeric(10,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Peso",
                table: "Arbitro",
                type: "numeric(10,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Altura",
                table: "Arbitro",
                type: "numeric(10,5)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");
        }
    }
}
