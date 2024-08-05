using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onboarding_backend.Database.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableOrderTakeOutPrice : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "OrderItems");

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 170, DateTimeKind.Local).AddTicks(5634), new DateTime(2024, 8, 5, 23, 57, 13, 170, DateTimeKind.Local).AddTicks(5647) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 170, DateTimeKind.Local).AddTicks(5649), new DateTime(2024, 8, 5, 23, 57, 13, 170, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3494), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3502) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3526), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3528) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3529), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3530) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3532), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3532) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3534), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3535) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3536), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3538), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3539) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3541), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3542) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3543), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3544) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3545), new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3121), "$2a$11$aoVrV1Pk02uvXHbcBBFaPOmt5IMuygb75zGQVdBOaOB/TX/YDoSjm", new DateTime(2024, 8, 5, 23, 57, 13, 307, DateTimeKind.Local).AddTicks(3137) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "OrderItems",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6363), new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6377) });

            migrationBuilder.UpdateData(
                table: "Studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6379), new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1423), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1433) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1459), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1461) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1462), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1463) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1465), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1465) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1467), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1467) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1469), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1471), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1472) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1473), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1474) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1475), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1476) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1477), new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1478) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(999), "$2a$11$SDIs45P/wDS5Hlmri8CzXel.PgTzFD0PP9UdDrBJWwfLn5gJ0.r5u", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1014) });
        }
    }
}
