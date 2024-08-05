using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onboarding_backend.Database.MIgrations
{
    /// <inheritdoc />
    public partial class AlterTableMissingCreatedDateSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8490), new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8504), new DateTime(2024, 8, 5, 13, 6, 56, 17, DateTimeKind.Local).AddTicks(8505) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(7996), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8023), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8026), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8028), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8029), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8031), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8032) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8034), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8035), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8036) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8037), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8039), new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(8040) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(7504), "$2a$11$idOaeNaUzZP9be4lVSbsyOUdEuDudetBycxGuHiKl0I3jqU0/UPD6", new DateTime(2024, 8, 5, 13, 6, 56, 166, DateTimeKind.Local).AddTicks(7520) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 13, 2, 28, 377, DateTimeKind.Local).AddTicks(6573), "$2a$11$/GYfam84hfE20rR.bmWfoeumzZHFVsnORJ6OrjzSF6/n.KsZ/uzBu", new DateTime(2024, 8, 5, 13, 2, 28, 377, DateTimeKind.Local).AddTicks(6589) });
        }
    }
}
