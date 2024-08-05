using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onboarding_backend.Database.MIgrations
{
    /// <inheritdoc />
    public partial class UserSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 1, 56, 16, DateTimeKind.Local).AddTicks(2304), new DateTime(2024, 8, 5, 13, 1, 56, 16, DateTimeKind.Local).AddTicks(2316) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 1, 56, 16, DateTimeKind.Local).AddTicks(2318), new DateTime(2024, 8, 5, 13, 1, 56, 16, DateTimeKind.Local).AddTicks(2318) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "DeletedAt", "Email", "IsAdmin", "Name", "Password", "UpdatedAt" },
                values: new object[] { 1, "https://static-00.iconduck.com/assets.00/avatar-default-symbolic-icon-479x512-n8sg74wg.png", new DateTime(2024, 8, 5, 13, 1, 56, 165, DateTimeKind.Local).AddTicks(5067), null, "admin@admin.com", true, "Admin", "$2a$11$VYyUiqYkxNYDnc5Nz0UVqeobdq1.QEcej/roYeeLZlyqXifua1yli", new DateTime(2024, 8, 5, 13, 1, 56, 165, DateTimeKind.Local).AddTicks(5084) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(666), new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(682) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(685), new DateTime(2024, 8, 5, 12, 52, 55, 622, DateTimeKind.Local).AddTicks(686) });
        }
    }
}
