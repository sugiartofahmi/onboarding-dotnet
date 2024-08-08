using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace onboarding_backend.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Overview = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PlayUntil = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "studios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudioNumber = table.Column<int>(type: "int", nullable: false),
                    SeatCapacity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_studios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "movie_schedules",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: false),
                    StudioId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie_schedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_movie_schedules_movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_movie_schedules_studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "studios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    TotalItemPrice = table.Column<double>(type: "float", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orders_users_UserId",
                        column: x => x.UserId,
                        principalTable: "users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MovieScheduleId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    SubTotalPrice = table.Column<double>(type: "float", nullable: false),
                    Snapshots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_order_items_movie_schedules_MovieScheduleId",
                        column: x => x.MovieScheduleId,
                        principalTable: "movie_schedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_items_orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "studios",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "SeatCapacity", "StudioNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1472), null, 10, 1, new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1484) },
                    { 2, new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1485), null, 15, 2, new DateTime(2024, 8, 8, 11, 21, 8, 323, DateTimeKind.Local).AddTicks(1486) }
                });

            migrationBuilder.InsertData(
                table: "tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(64), null, "Action", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(73) },
                    { 2, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(91), null, "Comedy", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(92) },
                    { 3, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(93), null, "Drama", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(94) },
                    { 4, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(96), null, "Horror", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(97) },
                    { 5, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(98), null, "Romance", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(99) },
                    { 6, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(100), null, "Science Fiction", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(101) },
                    { 7, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(102), null, "Fantasy", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(103) },
                    { 8, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(104), null, "Thriller", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(105) },
                    { 9, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(106), null, "Mystery", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(107) },
                    { 10, new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(108), null, "Documentary", new DateTime(2024, 8, 8, 11, 21, 8, 477, DateTimeKind.Local).AddTicks(109) }
                });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "DeletedAt", "Email", "IsAdmin", "Name", "Password", "UpdatedAt" },
                values: new object[] { 1, "https://static-00.iconduck.com/assets.00/avatar-default-symbolic-icon-479x512-n8sg74wg.png", new DateTime(2024, 8, 8, 11, 21, 8, 476, DateTimeKind.Local).AddTicks(9782), null, "admin@admin.com", true, "Admin", "$2a$11$DEff0XY20L.vWYpbAEg.H.2SKI985HaoxSmkfB57Ya062Ry.cXksa", new DateTime(2024, 8, 8, 11, 21, 8, 476, DateTimeKind.Local).AddTicks(9801) });

            migrationBuilder.CreateIndex(
                name: "IX_movie_schedules_MovieId",
                table: "movie_schedules",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_movie_schedules_StudioId",
                table: "movie_schedules",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTags_TagId",
                table: "MovieTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_order_items_MovieScheduleId",
                table: "order_items",
                column: "MovieScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_order_items_OrderId",
                table: "order_items",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserId",
                table: "orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieTags");

            migrationBuilder.DropTable(
                name: "order_items");

            migrationBuilder.DropTable(
                name: "tags");

            migrationBuilder.DropTable(
                name: "movie_schedules");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "studios");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
