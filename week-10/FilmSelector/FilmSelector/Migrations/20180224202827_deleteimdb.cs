using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilmSelector.Migrations
{
    public partial class deleteimdb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IMdB",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "IMdB",
                table: "Films");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "IMdB",
                table: "Series",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "IMdB",
                table: "Films",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
