using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HepsiApi.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parentId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    priorty = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    brandId = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_brandId",
                        column: x => x.brandId,
                        principalTable: "Brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    categoryId = table.Column<int>(type: "int", nullable: false),
                    createdDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.id);
                    table.ForeignKey(
                        name: "FK_Details_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryProduct",
                columns: table => new
                {
                    Categoriesid = table.Column<int>(type: "int", nullable: false),
                    Productsid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryProduct", x => new { x.Categoriesid, x.Productsid });
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Categories_Categoriesid",
                        column: x => x.Categoriesid,
                        principalTable: "Categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryProduct_Products_Productsid",
                        column: x => x.Productsid,
                        principalTable: "Products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "id", "createdDate", "isDeleted", "name" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 19, 14, 45, 48, 409, DateTimeKind.Local).AddTicks(3738), false, "Clothing, Home & Kids" },
                    { 2, new DateTime(2025, 11, 19, 14, 45, 48, 409, DateTimeKind.Local).AddTicks(3762), false, "Games, Health & Automotive" },
                    { 3, new DateTime(2025, 11, 19, 14, 45, 48, 409, DateTimeKind.Local).AddTicks(3772), true, "Outdoors" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "id", "createdDate", "isDeleted", "name", "parentId", "priorty" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 11, 19, 14, 45, 48, 409, DateTimeKind.Local).AddTicks(5001), false, "Elektronik", 0, 1 },
                    { 2, new DateTime(2025, 11, 19, 14, 45, 48, 409, DateTimeKind.Local).AddTicks(5003), false, "Moda", 0, 2 },
                    { 3, new DateTime(2025, 11, 19, 14, 45, 48, 409, DateTimeKind.Local).AddTicks(5005), false, "Bilgisayar", 1, 1 },
                    { 4, new DateTime(2025, 11, 19, 14, 45, 48, 409, DateTimeKind.Local).AddTicks(5006), false, "Kadin", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "Details",
                columns: new[] { "id", "categoryId", "createdDate", "description", "isDeleted", "title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 11, 19, 14, 45, 48, 410, DateTimeKind.Local).AddTicks(8498), "Qui sayfası iure iusto çıktılar.", false, "Cezbelendi." },
                    { 2, 3, new DateTime(2025, 11, 19, 14, 45, 48, 410, DateTimeKind.Local).AddTicks(8535), "Eum şafak salladı qui gidecekmiş.", true, "Architecto incidunt." },
                    { 3, 4, new DateTime(2025, 11, 19, 14, 45, 48, 410, DateTimeKind.Local).AddTicks(8564), "Odio bahar qui ab aut.", false, "Teldeki." }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "brandId", "createdDate", "description", "discount", "isDeleted", "price", "title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 11, 19, 14, 45, 48, 412, DateTimeKind.Local).AddTicks(1300), "Carbonite web goalkeeper gloves are ergonomically designed to give easy fit", 6.904042489890240m, false, 990.70m, "Incredible Frozen Pizza" },
                    { 2, 3, new DateTime(2025, 11, 19, 14, 45, 48, 412, DateTimeKind.Local).AddTicks(1330), "New ABC 13 9370, 13.3, 5th Gen CoreA5-8250U, 8GB RAM, 256GB SSD, power UHD Graphics, OS 10 Home, OS Office A & J 2016", 0.5973208547271870m, false, 319.66m, "Awesome Steel Shoes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryProduct_Productsid",
                table: "CategoryProduct",
                column: "Productsid");

            migrationBuilder.CreateIndex(
                name: "IX_Details_categoryId",
                table: "Details",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_brandId",
                table: "Products",
                column: "brandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryProduct");

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
