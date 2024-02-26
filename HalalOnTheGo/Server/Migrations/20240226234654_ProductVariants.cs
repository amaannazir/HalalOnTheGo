using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HalalOnTheGo.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductVariants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EditionProduct");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DropColumn(
                name: "OriginalPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

            migrationBuilder.CreateTable(
                name: "ProductVariant",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    EditionId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariant", x => new { x.ProductId, x.EditionId });
                    table.ForeignKey(
                        name: "FK_ProductVariant_Editions_EditionId",
                        column: x => x.EditionId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariant_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Default");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "1KG");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "2KG");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "5KG");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "5(FIVE) Pieces");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "10(TEN) Pieces");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "15(FIFTEEN) Pieces");

            migrationBuilder.InsertData(
                table: "Editions",
                columns: new[] { "Id", "Name" },
                values: new object[] { 8, "500G" });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 3, 1, 0m, 7.00m },
                    { 2, 2, 0m, 4.50m },
                    { 3, 2, 10.00m, 6.00m },
                    { 4, 2, 37.00m, 15.00m },
                    { 5, 3, 0m, 5.00m },
                    { 6, 3, 12.15m, 9.95m },
                    { 7, 3, 0m, 14.30m },
                    { 3, 4, 0m, 8.50m },
                    { 2, 5, 0m, 13.00m },
                    { 3, 5, 26.50m, 24.95m },
                    { 2, 6, 0m, 9.95m },
                    { 2, 7, 18.00m, 12.00m },
                    { 2, 8, 0m, 9.00m },
                    { 3, 8, 18.00m, 13.50m },
                    { 2, 9, 11.20m, 7.50m },
                    { 3, 9, 0m, 23.00m },
                    { 1, 10, 0m, 33.00m },
                    { 3, 10, 45.00m, 30.00m }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "HALAL Whole Chicken 2KG");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "HALAL Chicken Breast");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.", "/Images/Chicken-Drumsticks.png", "HALAL Chicken Drumsticks" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Title" },
                values: new object[] { "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.", "/Images/Chicken-Mix-Mince.png", "HALAL Chicken Mince (Keema)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 2, "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously  sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering. ON SALE NOW. LIMITED TIME ONLY", "/Images/LambChops1kg.png", "HALAL Lamp Chops" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 2, "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations. ON SALE NOW - LIMITED TIME ONLY!", "/Images/LambMince1KG.png", "HALAL Lamb Mince (Keema)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 2, "Transform your meals into culinary masterpieces with the premium taste and quality of our halal lamb steaks. Order now to bring home the unparalleled richness and tenderness that only halal-certified lamb can offer. Enjoy a dining experience that combines tradition and excellence with every flavorful bite.", "/Images/Lamb-Leg-Steak.png", "HALAL Lamb Steak" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 3, "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.", "/Images/Dice-Mutton.png", "HALAL Mutton (DICED W/ BONE)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 3, "Embark on a gastronomic adventure with our exquisite mixed mutton assortment – a carefully curated blend of diverse cuts that harmonize to create a culinary masterpiece. Crafted with precision and passion, this medley of mutton promises to captivate your palate and elevate your cooking to new heights.", "/Images/Mixed-Mutton.png", "HALAL Mixed Mutton" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Image", "Title" },
                values: new object[] { 3, "Sourced from the finest cuts of mutton, our 7-day dry-aged process is a testament to patience and precision. The result? A masterpiece that boasts an intensified, concentrated flavor profile, bringing forth the sublime fusion of richness and tenderness that can only be achieved through the art of dry aging. ON SALE NOW- LIMITED TIME ONLY! ", "/Images/7Day-Aged-Mutton.png", "HALAL 7-Day Dry Aged Mutton" });

            migrationBuilder.InsertData(
                table: "ProductVariant",
                columns: new[] { "EditionId", "ProductId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { 8, 4, 0m, 5.00m },
                    { 8, 5, 12.60m, 7.00m },
                    { 8, 6, 7.95m, 5.00m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_EditionId",
                table: "ProductVariant",
                column: "EditionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariant");

            migrationBuilder.DeleteData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.AddColumn<decimal>(
                name: "OriginalPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "EditionProduct",
                columns: table => new
                {
                    EditionsId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditionProduct", x => new { x.EditionsId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_EditionProduct_Editions_EditionsId",
                        column: x => x.EditionsId,
                        principalTable: "Editions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EditionProduct_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EditionProduct",
                columns: new[] { "EditionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 10 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 2 },
                    { 4, 5 },
                    { 5, 5 },
                    { 6, 5 },
                    { 7, 9 },
                    { 7, 10 }
                });

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "1KG");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "2KG");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "5KG");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "5(FIVE) Pieces");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "10(TEN) Pieces");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "15(FIFTEEN) Pieces");

            migrationBuilder.UpdateData(
                table: "Editions",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "500G");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "OriginalPrice", "Price", "Title" },
                values: new object[] { 0m, 5.00m, "HALAL Whole Chicken" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "OriginalPrice", "Price", "Title" },
                values: new object[] { 0m, 4.50m, "HALAL Chicken Breast 1KG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected, ensuring a premium dining experience that aligns with your dietary preferences.", "/Images/chickenbreast1KG.png", 10.00m, 6.00m, "HALAL Chicken Breast 2KG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected,ensuring a premium dining experience that aligns with your dietary preferences. OVER HALF OFF!", "/Images/chickenbreast1KG.png", 37.00m, 15.00m, "HALAL Chicken Breast 5KG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.", "/Images/Chicken-Drumsticks.png", 0m, 5.00m, "HALAL Chicken Drumsticks (5 PIECES)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.", "/Images/Chicken-Drumsticks.png", 12.15m, 9.95m, "HALAL Chicken Drumsticks (10 PIECES)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.", "/Images/Chicken-Drumsticks.png", 0m, 14.30m, "HALAL Chicken Drumsticks (15 PIECES)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.", "/Images/Chicken-Mix-Mince.png", 7.50m, 5.00m, "HALAL Chicken Mince (Keema) 500G" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { 1, "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.", "/Images/Chicken-Mix-Mince.png", 0m, 8.50m, "HALAL Chicken Mince (Keema) 2KG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "Image", "OriginalPrice", "Price", "Title" },
                values: new object[] { 2, "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously  sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering. ON SALE NOW. LIMITED TIME ONLY", "/Images/LambChops1kg.png", 12.60m, 7.00m, "HALAL Lamp Chops 500G" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 11, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.", "/Images/LambChops1kg.png", false, false, 0m, 13.00m, "HALAL Lamp Chops 1KG" },
                    { 12, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.", "/Images/LambChops1kg.png", false, false, 26.50m, 24.95m, "HALAL Lamp Chops 2KG" },
                    { 13, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations. ON SALE NOW - LIMITED TIME ONLY!", "/Images/LambMince1KG.png", false, false, 7.00m, 5.00m, "HALAL Lamb Mince (Keema) 500G" },
                    { 14, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations.", "/Images/LambMince1KG.png", false, false, 0m, 8.95m, "HALAL Lamb Mince (Keema) 2KG" },
                    { 15, 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Transform your meals into culinary masterpieces with the premium taste and quality of our halal lamb steaks. Order now to bring home the unparalleled richness and tenderness that only halal-certified lamb can offer. Enjoy a dining experience that combines tradition and excellence with every flavorful bite.", "/Images/Lamb-Leg-Steak.png", false, false, 18.00m, 12.00m, "HALAL Lamb Steak" },
                    { 16, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.", "/Images/Dice-Mutton.png", false, false, 0m, 9.00m, "HALAL Mutton (DICED W/ BONE) 1KG" },
                    { 17, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.", "/Images/Dice-Mutton.png", false, false, 18.00m, 13.50m, "HALAL Mutton (DICED W/ BONE) 2KG" },
                    { 18, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Embark on a gastronomic adventure with our exquisite mixed mutton assortment – a carefully curated blend of diverse cuts that harmonize to create a culinary masterpiece. Crafted with precision and passion, this medley of mutton promises to captivate your palate and elevate your cooking to new heights.", "/Images/Mixed-Mutton.png", false, false, 11.20m, 7.50m, "HALAL Mixed Mutton 1KG" },
                    { 19, 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sourced from the finest cuts of mutton, our 7-day dry-aged process is a testament to patience and precision. The result? A masterpiece that boasts an intensified, concentrated flavor profile, bringing forth the sublime fusion of richness and tenderness that can only be achieved through the art of dry aging. ON SALE NOW- LIMITED TIME ONLY! ", "/Images/7Day-Aged-Mutton.png", false, false, 45.00m, 30.00m, "HALAL 7-Day Dry Aged Mutton 2KG" }
                });

            migrationBuilder.InsertData(
                table: "EditionProduct",
                columns: new[] { "EditionsId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 16 },
                    { 1, 18 },
                    { 2, 13 },
                    { 2, 15 },
                    { 2, 19 },
                    { 3, 16 },
                    { 7, 13 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EditionProduct_ProductsId",
                table: "EditionProduct",
                column: "ProductsId");
        }
    }
}
