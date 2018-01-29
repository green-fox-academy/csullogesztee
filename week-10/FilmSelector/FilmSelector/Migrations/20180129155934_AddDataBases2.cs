using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilmSelector.Migrations
{
    public partial class AddDataBases2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Program_Users_CreatorId",
                table: "Program");

            migrationBuilder.DropForeignKey(
                name: "FK_Program_Calendar_Date",
                table: "Program");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Program",
                table: "Program");

            migrationBuilder.DropIndex(
                name: "IX_Program_Date",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Program");

            migrationBuilder.RenameTable(
                name: "Program",
                newName: "Series");

            migrationBuilder.RenameIndex(
                name: "IX_Program_CreatorId",
                table: "Series",
                newName: "IX_Series_CreatorId");

            migrationBuilder.AlterColumn<int>(
                name: "Started",
                table: "Series",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Seasons",
                table: "Series",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Ended",
                table: "Series",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Series",
                table: "Series",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    About = table.Column<string>(nullable: true),
                    CreatorId = table.Column<long>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IMBBScore = table.Column<double>(nullable: false),
                    IMDBLink = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Watched = table.Column<bool>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Films_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Program",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    About = table.Column<string>(nullable: true),
                    CreatorId = table.Column<long>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    IMBBScore = table.Column<double>(nullable: false),
                    IMDBLink = table.Column<string>(nullable: true),
                    Style = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Watched = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Program", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Program_Users_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Program_Calendar_Date",
                        column: x => x.Date,
                        principalTable: "Calendar",
                        principalColumn: "Date",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_CreatorId",
                table: "Films",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_CreatorId",
                table: "Program",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_Program_Date",
                table: "Program",
                column: "Date");

            migrationBuilder.AddForeignKey(
                name: "FK_Series_Users_CreatorId",
                table: "Series",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Series_Users_CreatorId",
                table: "Series");

            migrationBuilder.DropTable(
                name: "Films");

            migrationBuilder.DropTable(
                name: "Program");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Series",
                table: "Series");

            migrationBuilder.RenameTable(
                name: "Series",
                newName: "Program");

            migrationBuilder.RenameIndex(
                name: "IX_Series_CreatorId",
                table: "Program",
                newName: "IX_Program_CreatorId");

            migrationBuilder.AlterColumn<int>(
                name: "Started",
                table: "Program",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Seasons",
                table: "Program",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Ended",
                table: "Program",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Program",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Program",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Program",
                table: "Program",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Program_Date",
                table: "Program",
                column: "Date");

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Users_CreatorId",
                table: "Program",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Program_Calendar_Date",
                table: "Program",
                column: "Date",
                principalTable: "Calendar",
                principalColumn: "Date",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
