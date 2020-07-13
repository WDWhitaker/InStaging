using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InStaging.SqlDataService.Migrations
{
    public partial class newticketfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descriptions",
                table: "Ticket");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Ticket",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Ticket",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Ticket");

            migrationBuilder.AddColumn<string>(
                name: "Descriptions",
                table: "Ticket",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
