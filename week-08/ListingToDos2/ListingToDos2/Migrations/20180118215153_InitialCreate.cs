using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ListingToDos2.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users2",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users2", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ToDos2",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AssigneeUserId = table.Column<long>(nullable: true),
                    CreatorUserId = table.Column<long>(nullable: true),
                    Date = table.Column<string>(nullable: true),
                    IsDone = table.Column<bool>(nullable: false),
                    IsUrgent = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToDos2_Users2_AssigneeUserId",
                        column: x => x.AssigneeUserId,
                        principalTable: "Users2",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ToDos2_Users2_CreatorUserId",
                        column: x => x.CreatorUserId,
                        principalTable: "Users2",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ToDos2_AssigneeUserId",
                table: "ToDos2",
                column: "AssigneeUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ToDos2_CreatorUserId",
                table: "ToDos2",
                column: "CreatorUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos2");

            migrationBuilder.DropTable(
                name: "Users2");
        }
    }
}
