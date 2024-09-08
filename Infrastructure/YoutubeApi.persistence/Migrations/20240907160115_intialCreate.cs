using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace YoutubeApi.persistence.Migrations
{
    /// <inheritdoc />
    public partial class intialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Priorty = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 7, 19, 1, 15, 511, DateTimeKind.Local).AddTicks(987), false, "Tools, Computers & Outdoors" },
                    { 2, new DateTime(2024, 9, 7, 19, 1, 15, 511, DateTimeKind.Local).AddTicks(1173), false, "Shoes, Garden & Computers" },
                    { 3, new DateTime(2024, 9, 7, 19, 1, 15, 511, DateTimeKind.Local).AddTicks(1201), true, "Automotive, Outdoors & Home" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name", "ParentId", "Priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 7, 19, 1, 15, 511, DateTimeKind.Local).AddTicks(4281), false, "Elektrik", 0, 1 },
                    { 2, new DateTime(2024, 9, 7, 19, 1, 15, 511, DateTimeKind.Local).AddTicks(4288), false, "Moda", 0, 2 },
                    { 3, new DateTime(2024, 9, 7, 19, 1, 15, 511, DateTimeKind.Local).AddTicks(4294), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2024, 9, 7, 19, 1, 15, 511, DateTimeKind.Local).AddTicks(4299), false, "Kadın", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Description", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 7, 19, 1, 15, 516, DateTimeKind.Local).AddTicks(9), "Ullam patlıcan tempora reprehenderit aperiam.", false, "Voluptatem." },
                    { 2, 3, new DateTime(2024, 9, 7, 19, 1, 15, 516, DateTimeKind.Local).AddTicks(837), "Aut çorba et balıkhaneye aut.", true, "Işık adresini." },
                    { 3, 4, new DateTime(2024, 9, 7, 19, 1, 15, 516, DateTimeKind.Local).AddTicks(944), "Nihil iusto dolores batarya reprehenderit.", false, "Eius." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CreatedDate", "Description", "Discount", "IsDeleted", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 9, 7, 19, 1, 15, 519, DateTimeKind.Local).AddTicks(7904), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 9.928401003509510m, false, 85.54m, "Handmade Rubber Ball" },
                    { 2, 3, new DateTime(2024, 9, 7, 19, 1, 15, 519, DateTimeKind.Local).AddTicks(7944), "Ergonomic executive chair upholstered in bonded black leather and PVC padded seat and back for all-day comfort and support", 2.81894326000640m, false, 165.91m, "Rustic Wooden Tuna" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Details_CategoryId",
                table: "Details",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
