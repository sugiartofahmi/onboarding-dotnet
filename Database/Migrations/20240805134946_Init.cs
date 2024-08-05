using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace onboarding_backend.Database.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
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
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Studios",
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
                    table.PrimaryKey("PK_Studios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
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
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MovieSchedules",
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
                    table.PrimaryKey("PK_MovieSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MovieSchedules_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieSchedules_Studios_StudioId",
                        column: x => x.StudioId,
                        principalTable: "Studios",
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
                        name: "FK_MovieTags_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
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
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MovieScheduleId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SubTotalPrice = table.Column<double>(type: "float", nullable: false),
                    Snapshots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_MovieSchedules_MovieScheduleId",
                        column: x => x.MovieScheduleId,
                        principalTable: "MovieSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Studios",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "SeatCapacity", "StudioNumber", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6363), null, 10, 1, new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6377) },
                    { 2, new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6379), null, 15, 2, new DateTime(2024, 8, 5, 20, 49, 45, 705, DateTimeKind.Local).AddTicks(6380) }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1423), null, "Action", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1433) },
                    { 2, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1459), null, "Comedy", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1461) },
                    { 3, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1462), null, "Drama", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1463) },
                    { 4, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1465), null, "Horror", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1465) },
                    { 5, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1467), null, "Romance", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1467) },
                    { 6, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1469), null, "Science Fiction", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1470) },
                    { 7, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1471), null, "Fantasy", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1472) },
                    { 8, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1473), null, "Thriller", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1474) },
                    { 9, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1475), null, "Mystery", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1476) },
                    { 10, new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1477), null, "Documentary", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1478) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "DeletedAt", "Email", "IsAdmin", "Name", "Password", "UpdatedAt" },
                values: new object[] { 1, "https://static-00.iconduck.com/assets.00/avatar-default-symbolic-icon-479x512-n8sg74wg.png", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(999), null, "admin@admin.com", true, "Admin", "$2a$11$SDIs45P/wDS5Hlmri8CzXel.PgTzFD0PP9UdDrBJWwfLn5gJ0.r5u", new DateTime(2024, 8, 5, 20, 49, 45, 845, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.CreateIndex(
                name: "IX_MovieSchedules_MovieId",
                table: "MovieSchedules",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieSchedules_StudioId",
                table: "MovieSchedules",
                column: "StudioId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTags_TagId",
                table: "MovieTags",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_MovieScheduleId",
                table: "OrderItems",
                column: "MovieScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieTags");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "MovieSchedules");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Studios");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
