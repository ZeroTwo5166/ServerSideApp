﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ServerSide.Migrations
{
    /// <inheritdoc />
    public partial class modifiedtodolisttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todolists_Cprs_CprId",
                table: "Todolists");

            migrationBuilder.DropIndex(
                name: "IX_Todolists_CprId",
                table: "Todolists");

            migrationBuilder.DropColumn(
                name: "CprId",
                table: "Todolists");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Todolists",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Todolists_UserId",
                table: "Todolists",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todolists_AspNetUsers_UserId",
                table: "Todolists",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todolists_AspNetUsers_UserId",
                table: "Todolists");

            migrationBuilder.DropIndex(
                name: "IX_Todolists_UserId",
                table: "Todolists");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Todolists");

            migrationBuilder.AddColumn<int>(
                name: "CprId",
                table: "Todolists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Todolists_CprId",
                table: "Todolists",
                column: "CprId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todolists_Cprs_CprId",
                table: "Todolists",
                column: "CprId",
                principalTable: "Cprs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
