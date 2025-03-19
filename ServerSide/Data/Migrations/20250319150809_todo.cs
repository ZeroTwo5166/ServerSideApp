using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class todo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Item",
                table: "Todolists",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CprNr",
                table: "Cprs",
                newName: "CprNumber");

            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "Todolists",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Todolists",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "createdDate",
                table: "Todolists",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "Todolists");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Todolists");

            migrationBuilder.DropColumn(
                name: "createdDate",
                table: "Todolists");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Todolists",
                newName: "Item");

            migrationBuilder.RenameColumn(
                name: "CprNumber",
                table: "Cprs",
                newName: "CprNr");
        }
    }
}
