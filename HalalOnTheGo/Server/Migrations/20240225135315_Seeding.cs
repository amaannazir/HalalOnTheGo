using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HalalOnTheGo.Server.Migrations
{
    /// <inheritdoc />
    public partial class Seeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "food", "Chicken", "chicken" },
                    { 2, "food", "Lamb", "meat" },
                    { 3, "food", "Mutton", "mutton" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "DateCreated", "DateUpdated", "Description", "Image", "IsDeleted", "IsPublic", "OriginalPrice", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6168), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Experience the epitome of freshness and quality with our HALAL whole chicken, now available for purchase on our website. Our HALAL-certified whole chickens are sourced from reputable farms, ensuring that you receive a product that aligns with your dietary preferences and cultural values. (BEST VALUE)", "/Images/WholeChicken.png", false, false, 0m, 5.00m, "HALAL Whole Chicken" },
                    { 2, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6525), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected, ensuring a premium dining experience that aligns with your dietary preferences.", "/Images/chickenbreast1KG.png", false, false, 0m, 4.50m, "HALAL Chicken Breast 1KG" },
                    { 3, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6530), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected, ensuring a premium dining experience that aligns with your dietary preferences.", "/Images/chickenbreast1KG.png", false, false, 10.00m, 6.00m, "HALAL Chicken Breast 2KG" },
                    { 4, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6535), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected,ensuring a premium dining experience that aligns with your dietary preferences. OVER HALF OFF!", "/Images/chickenbreast1KG.png", false, false, 37.00m, 15.00m, "HALAL Chicken Breast 5KG" },
                    { 5, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6539), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.", "/Images/Chicken-Drumsticks.png", false, false, 0m, 5.00m, "HALAL Chicken Drumsticks (5 PIECES)" },
                    { 6, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6542), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.", "/Images/Chicken-Drumsticks.png", false, false, 12.15m, 9.95m, "HALAL Chicken Drumsticks (10 PIECES)" },
                    { 7, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6545), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.", "/Images/Chicken-Drumsticks.png", false, false, 0m, 14.30m, "HALAL Chicken Drumsticks (15 PIECES)" },
                    { 8, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6549), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.", "/Images/Chicken-Mix-Mince.png", false, false, 7.50m, 5.00m, "HALAL Chicken Mince (Keema) 500G" },
                    { 9, 1, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6553), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.", "/Images/Chicken-Mix-Mince.png", false, false, 0m, 8.50m, "HALAL Chicken Mince (Keema) 2KG" },
                    { 10, 2, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6557), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously  sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering. ON SALE NOW. LIMITED TIME ONLY", "/Images/LambChops1kg.png", false, false, 12.60m, 7.00m, "HALAL Lamp Chops 500G" },
                    { 11, 2, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6560), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.", "/Images/LambChops1kg.png", false, false, 0m, 13.00m, "HALAL Lamp Chops 1KG" },
                    { 12, 2, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6563), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.", "/Images/LambChops1kg.png", false, false, 26.50m, 24.95m, "HALAL Lamp Chops 2KG" },
                    { 13, 2, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6567), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations. ON SALE NOW - LIMITED TIME ONLY!", "/Images/LambMince1KG.png", false, false, 7.00m, 5.00m, "HALAL Lamb Mince (Keema) 500G" },
                    { 14, 2, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6570), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations.", "/Images/LambMince1KG.png", false, false, 0m, 8.95m, "HALAL Lamb Mince (Keema) 2KG" },
                    { 15, 2, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6574), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Transform your meals into culinary masterpieces with the premium taste and quality of our halal lamb steaks. Order now to bring home the unparalleled richness and tenderness that only halal-certified lamb can offer. Enjoy a dining experience that combines tradition and excellence with every flavorful bite.", "/Images/Lamb-Leg-Steak.png", false, false, 18.00m, 12.00m, "HALAL Lamb Steak" },
                    { 16, 3, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6577), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.", "/Images/Dice-Mutton.png", false, false, 0m, 9.00m, "HALAL Mutton (DICED W/ BONE) 1KG" },
                    { 17, 3, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6580), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.", "/Images/Dice-Mutton.png", false, false, 18.00m, 13.50m, "HALAL Mutton (DICED W/ BONE) 2KG" },
                    { 18, 3, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6584), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Embark on a gastronomic adventure with our exquisite mixed mutton assortment – a carefully curated blend of diverse cuts that harmonize to create a culinary masterpiece. Crafted with precision and passion, this medley of mutton promises to captivate your palate and elevate your cooking to new heights.", "/Images/Mixed-Mutton.png", false, false, 11.20m, 7.50m, "HALAL Mixed Mutton 1KG" },
                    { 19, 3, new DateTime(2024, 2, 25, 13, 53, 15, 659, DateTimeKind.Local).AddTicks(6587), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sourced from the finest cuts of mutton, our 7-day dry-aged process is a testament to patience and precision. The result? A masterpiece that boasts an intensified, concentrated flavor profile, bringing forth the sublime fusion of richness and tenderness that can only be achieved through the art of dry aging. ON SALE NOW- LIMITED TIME ONLY! ", "/Images/7Day-Aged-Mutton.png", false, false, 45.00m, 30.00m, "HALAL 7-Day Dry Aged Mutton 2KG" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
