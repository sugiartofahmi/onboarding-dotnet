using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace onboarding_backend.Database.MIgrations
{
    /// <inheritdoc />
    public partial class TagSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 2, 28, 196, DateTimeKind.Local).AddTicks(473), new DateTime(2024, 8, 5, 13, 2, 28, 196, DateTimeKind.Local).AddTicks(484) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 2, 28, 196, DateTimeKind.Local).AddTicks(485), new DateTime(2024, 8, 5, 13, 2, 28, 196, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, "Action", null },
                    { 2, null, null, "Comedy", null },
                    { 3, null, null, "Drama", null },
                    { 4, null, null, "Horror", null },
                    { 5, null, null, "Romance", null },
                    { 6, null, null, "Science Fiction", null },
                    { 7, null, null, "Fantasy", null },
                    { 8, null, null, "Thriller", null },
                    { 9, null, null, "Mystery", null },
                    { 10, null, null, "Documentary", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 2, 28, 377, DateTimeKind.Local).AddTicks(6573), "$2a$11$/GYfam84hfE20rR.bmWfoeumzZHFVsnORJ6OrjzSF6/n.KsZ/uzBu", new DateTime(2024, 8, 5, 13, 2, 28, 377, DateTimeKind.Local).AddTicks(6589) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 1, 56, 165, DateTimeKind.Local).AddTicks(5067), "$2a$11$VYyUiqYkxNYDnc5Nz0UVqeobdq1.QEcej/roYeeLZlyqXifua1yli", new DateTime(2024, 8, 5, 13, 1, 56, 165, DateTimeKind.Local).AddTicks(5084) });
        }
    }
}
