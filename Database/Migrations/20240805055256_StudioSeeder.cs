using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace onboarding_backend.Database.MIgrations
{
    /// <inheritdoc />
    public partial class StudioSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "SeatCapacity", "StudioNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(666), null, 10, 1, new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(682) },
                    { 2, new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(685), null, 15, 2, new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(686) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
