using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoIHC.Migrations
{
    /// <inheritdoc />
    public partial class Cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Cliente",
                newName: "NomePai");

            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Cliente",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Complemento",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EstadoCivil",
                table: "Cliente",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Logradouro",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NomeMae",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Numero",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RG",
                table: "Cliente",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UF",
                table: "Cliente",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Cidade",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Complemento",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "EstadoCivil",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Logradouro",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "NomeMae",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "RG",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "UF",
                table: "Cliente");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "NomePai",
                table: "Cliente",
                newName: "name");
        }
    }
}
