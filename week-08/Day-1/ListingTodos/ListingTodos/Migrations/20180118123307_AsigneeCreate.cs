using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ListingTodos.Migrations
{
    public partial class AsigneeCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_UserId",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ToDos",
                newName: "CreatorUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_UserId",
                table: "ToDos",
                newName: "IX_ToDos_CreatorUserId");

            migrationBuilder.AddColumn<long>(
                name: "AssigneeUserId",
                table: "ToDos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ToDos_AssigneeUserId",
                table: "ToDos",
                column: "AssigneeUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_AssigneeUserId",
                table: "ToDos",
                column: "AssigneeUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_CreatorUserId",
                table: "ToDos",
                column: "CreatorUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_AssigneeUserId",
                table: "ToDos");

            migrationBuilder.DropForeignKey(
                name: "FK_ToDos_Users_CreatorUserId",
                table: "ToDos");

            migrationBuilder.DropIndex(
                name: "IX_ToDos_AssigneeUserId",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "AssigneeUserId",
                table: "ToDos");

            migrationBuilder.RenameColumn(
                name: "CreatorUserId",
                table: "ToDos",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ToDos_CreatorUserId",
                table: "ToDos",
                newName: "IX_ToDos_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDos_Users_UserId",
                table: "ToDos",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
