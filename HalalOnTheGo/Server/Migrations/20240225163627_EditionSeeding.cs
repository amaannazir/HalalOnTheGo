using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HalalOnTheGo.Server.Migrations
{
    /// <inheritdoc />
    public partial class EditionSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "1KG" },
                    { 2, "2KG" },
                    { 3, "5KG" },
                    { 4, "5(FIVE) Pieces" },
                    { 5, "10(TEN) Pieces" },
                    { 6, "15(FIFTEEN) Pieces" },
                    { 7, "500G" }
                });

            migrationBuilder.InsertData(
                table: "EditionProduct",
                columns: new[] { "EditionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 10 },
                    { 1, 16 },
                    { 1, 18 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 13 },
                    { 2, 15 },
                    { 2, 19 },
                    { 3, 2 },
                    { 3, 16 },
                    { 4, 5 },
                    { 5, 5 },
                    { 6, 5 },
                    { 7, 9 },
                    { 7, 10 },
                    { 7, 13 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 1, 16 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 1, 18 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 2, 19 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 4, 5 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 6, 5 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 7, 9 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 7, 10 });

            migrationBuilder.DeleteData(
                table: "EditionProduct",
                keyColumns: new[] { "EditionsId", "ProductsId" },
                keyValues: new object[] { 7, 13 });

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
