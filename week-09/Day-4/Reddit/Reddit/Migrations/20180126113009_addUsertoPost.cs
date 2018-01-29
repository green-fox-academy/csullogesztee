using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Reddit.Migrations
{
    public partial class addUsertoPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reddit_Users_UserId",
                table: "Reddit");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Reddit",
                newName: "OwnerUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reddit_UserId",
                table: "Reddit",
                newName: "IX_Reddit_OwnerUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reddit_Users_OwnerUserId",
                table: "Reddit",
                column: "OwnerUserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reddit_Users_OwnerUserId",
                table: "Reddit");

            migrationBuilder.RenameColumn(
                name: "OwnerUserId",
                table: "Reddit",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reddit_OwnerUserId",
                table: "Reddit",
                newName: "IX_Reddit_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reddit_Users_UserId",
                table: "Reddit",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
