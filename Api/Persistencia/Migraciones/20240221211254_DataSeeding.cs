using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Api.Persistencia.Migraciones
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "id",
                keyValue: new Guid("8c3063b7-be06-46c5-a7c2-a777d2bbbfbd"));

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "id",
                keyValue: new Guid("e9545e97-f2ed-4dc7-ab52-116ca3043d58"));

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "id",
                keyValue: new Guid("1b548119-5778-42c0-a509-b573e01d2a3a"));

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "id",
                keyValue: new Guid("9b37a0c5-cc5b-4fe3-b064-79e4ffcaf3f9"));

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "id",
                keyValue: new Guid("fc63454c-21da-45b6-9543-c2f4e0107ed9"));

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "id", "CUIT", "Storeid", "direction", "lastname", "name" },
                values: new object[,]
                {
                    { new Guid("2f529190-238b-43f4-9928-18cc8dd57b44"), 20463633836L, null, "Av San Juan", "Salinas", "Franco" },
                    { new Guid("a8f762ea-a349-4677-b21f-cd21f73c5224"), 22993949399L, null, "Lanus", "Mansilla", "Facundo" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("8527b142-8d9a-40a9-a2ce-633726642647"), "Nike" },
                    { new Guid("b6c53cad-dded-4ea2-ac9c-e68950512ab5"), "Puma" },
                    { new Guid("e327f64b-3d6a-4755-b1ba-0cb698185211"), "Adidas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "id",
                keyValue: new Guid("2f529190-238b-43f4-9928-18cc8dd57b44"));

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "id",
                keyValue: new Guid("a8f762ea-a349-4677-b21f-cd21f73c5224"));

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "id",
                keyValue: new Guid("8527b142-8d9a-40a9-a2ce-633726642647"));

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "id",
                keyValue: new Guid("b6c53cad-dded-4ea2-ac9c-e68950512ab5"));

            migrationBuilder.DeleteData(
                table: "Store",
                keyColumn: "id",
                keyValue: new Guid("e327f64b-3d6a-4755-b1ba-0cb698185211"));

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "id", "CUIT", "Storeid", "direction", "lastname", "name" },
                values: new object[,]
                {
                    { new Guid("8c3063b7-be06-46c5-a7c2-a777d2bbbfbd"), 22993949399L, null, "Lanus", "Mansilla", "Facundo" },
                    { new Guid("e9545e97-f2ed-4dc7-ab52-116ca3043d58"), 20463633836L, null, "Av San Juan", "Salinas", "Franco" }
                });

            migrationBuilder.InsertData(
                table: "Store",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { new Guid("1b548119-5778-42c0-a509-b573e01d2a3a"), "Adidas" },
                    { new Guid("9b37a0c5-cc5b-4fe3-b064-79e4ffcaf3f9"), "Nike" },
                    { new Guid("fc63454c-21da-45b6-9543-c2f4e0107ed9"), "Puma" }
                });
        }
    }
}
