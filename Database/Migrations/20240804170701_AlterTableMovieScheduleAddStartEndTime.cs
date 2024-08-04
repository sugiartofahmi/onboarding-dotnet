using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onboarding_backend.Database.MIgrations
{
    /// <inheritdoc />
    public partial class AlterTableMovieScheduleAddStartEndTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAdmin",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "MovieSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "EndTime",
                table: "MovieSchedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "StartTime",
                table: "MovieSchedules",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAdmin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "MovieSchedules");

            migrationBuilder.DropColumn(
                name: "EndTime",
                table: "MovieSchedules");

            migrationBuilder.DropColumn(
                name: "StartTime",
                table: "MovieSchedules");
        }
    }
}
