using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sportsman.Migrations
{
    public partial class SportsmanInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Sportsmans");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Sportsmans",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Career",
                table: "Sportsmans",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalAchievements",
                table: "Sportsmans",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Sportsmans");

            migrationBuilder.DropColumn(
                name: "Career",
                table: "Sportsmans");

            migrationBuilder.DropColumn(
                name: "PersonalAchievements",
                table: "Sportsmans");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Sportsmans",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
