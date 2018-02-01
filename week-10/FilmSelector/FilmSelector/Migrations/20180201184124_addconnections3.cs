using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FilmSelector.Migrations
{
    public partial class addconnections3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFilm_Films_FilmId",
                table: "UserFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSeries_Series_SeriesId",
                table: "UserSeries");

            migrationBuilder.DropIndex(
                name: "IX_UserSeries_SeriesId",
                table: "UserSeries");

            migrationBuilder.DropIndex(
                name: "IX_UserFilm_FilmId",
                table: "UserFilm");

            migrationBuilder.DropColumn(
                name: "SeriesId",
                table: "UserSeries");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "UserFilm");

            migrationBuilder.CreateIndex(
                name: "IX_UserSeries_Id",
                table: "UserSeries",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilm_Id",
                table: "UserFilm",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilm_Films_Id",
                table: "UserFilm",
                column: "Id",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSeries_Series_Id",
                table: "UserSeries",
                column: "Id",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFilm_Films_Id",
                table: "UserFilm");

            migrationBuilder.DropForeignKey(
                name: "FK_UserSeries_Series_Id",
                table: "UserSeries");

            migrationBuilder.DropIndex(
                name: "IX_UserSeries_Id",
                table: "UserSeries");

            migrationBuilder.DropIndex(
                name: "IX_UserFilm_Id",
                table: "UserFilm");

            migrationBuilder.AddColumn<int>(
                name: "SeriesId",
                table: "UserSeries",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "UserFilm",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSeries_SeriesId",
                table: "UserSeries",
                column: "SeriesId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFilm_FilmId",
                table: "UserFilm",
                column: "FilmId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFilm_Films_FilmId",
                table: "UserFilm",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserSeries_Series_SeriesId",
                table: "UserSeries",
                column: "SeriesId",
                principalTable: "Series",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
