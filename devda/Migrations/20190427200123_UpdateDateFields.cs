using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace devda.Migrations
{
    public partial class UpdateDateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationDayTime",
                table: "Posts",
                newName: "LastUpdate");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDay",
                table: "Posts",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationDay",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "LastUpdate",
                table: "Posts",
                newName: "CreationDayTime");
        }
    }
}
