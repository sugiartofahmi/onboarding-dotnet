using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace onboarding_backend.Database.Migrations
{
    /// <inheritdoc />
    public partial class RenameTableMovieTags : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieTags");

            migrationBuilder.CreateTable(
                name: "movie_tags",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie_tags", x => new { x.MovieId, x.TagId });
                    table.ForeignKey(
                        name: "FK_movie_tags_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movie_tags_tags_TagId",
                        column: x => x.TagId,
                        principalTable: "tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 292, DateTimeKind.Local).AddTicks(2508), new DateTime(2024, 8, 8, 14, 53, 47, 292, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 292, DateTimeKind.Local).AddTicks(2522), new DateTime(2024, 8, 8, 14, 53, 47, 292, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1480), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1507), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1509) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1510), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1511) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1513), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1515), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1516) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1517), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1518) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1519), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1520) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1521), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1522) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1523), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1524) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1525), new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1052), "$2a$11$rhoMZsyDO5M0iXEZHDYXDeDlQSfVgCCRkpnGH/NUUuPofK/E2Ii02", new DateTime(2024, 8, 8, 14, 53, 47, 431, DateTimeKind.Local).AddTicks(1067) });

            migrationBuilder.CreateIndex(
                name: "IX_movie_tags_TagId",
                table: "movie_tags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "movie_tags");

            migrationBuilder.CreateTable(
                name: "MovieTags",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTags", x => new { x.MovieId, x.TagId });
                    table.ForeignKey(
                        name: "FK_MovieTags_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieTags_tags_TagId",
                        column: x => x.TagId,
                        principalTable: "tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "studios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1472), new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1484) });

            migrationBuilder.UpdateData(
                table: "studios",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1485), new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1486) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(64), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(73) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(91), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(92) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(93), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(94) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(96), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(97) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(98), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(99) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(100), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(102), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(103) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(104), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(105) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(106), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(107) });

            migrationBuilder.UpdateData(
                table: "tags",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(108), new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(109) });

            migrationBuilder.UpdateData(
                table: "users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Password", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 8, 8, 11, 21, 8, 476, DateTimeKind.Local).AddTicks(9782), "$2a$11$DEff0XY20L.vWYpbAEg.H.2SKI985HaoxSmkfB57Ya062Ry.cXksa", new DateTime(2024, 8, 8, 11, 21, 8, 476, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.CreateIndex(
                name: "IX_MovieTags_TagId",
                table: "MovieTags",
                column: "TagId");
        }
    }
}
