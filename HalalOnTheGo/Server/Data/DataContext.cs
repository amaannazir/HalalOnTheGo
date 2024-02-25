using HalalOnTheGo.Shared;
using Microsoft.EntityFrameworkCore;

namespace HalalOnTheGo.Server.Data
{
    public class DataContext : DbContext //Db context for categories and products 
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)  
        {

        }

        public DbSet<Category> Categories { get; set; } //Creating tables and giving names:
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData( //Adding the categories to the Database!

             new Category { Id = 1, Name = "Chicken", Url = "chicken", Icon = "food" },
                new Category { Id = 2, Name = "Lamb", Url = "meat", Icon = "food" },
                new Category { Id = 3, Name = "Mutton", Url = "mutton", Icon = "food" }
                );

            modelBuilder.Entity<Product>().HasData( //Adding the products to the database!!

                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "HALAL Whole Chicken",
                    Description = "Experience the epitome of freshness and quality with our HALAL whole chicken, now available for purchase on our website. Our HALAL-certified whole chickens are sourced from reputable farms, ensuring that you receive a product that aligns with your dietary preferences and cultural values. (BEST VALUE)",
                    Image = "/Images/WholeChicken.png",
                    Price = 5.00m, 
                    DateCreated = new DateTime(2024, 1, 1)
                },


        new Product
        {
            Id = 2,
            CategoryId = 1,
            Title = "HALAL Chicken Breast 1KG",
            Description = "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected, ensuring a premium dining experience that aligns with your dietary preferences.",
            Image = "/Images/chickenbreast1KG.png",
            Price = 4.50m,
            DateCreated = new DateTime(2024, 1, 1)
        },
        new Product
        {
            Id = 3,
            CategoryId = 1,
            Title = "HALAL Chicken Breast 2KG",
            Description = "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected, ensuring a premium dining experience that aligns with your dietary preferences.",
            Image = "/Images/chickenbreast1KG.png",
            Price = 6.00m,
            OriginalPrice = 10.00m,
            DateCreated = new DateTime(2024, 1, 1)
        },
        new Product
        {
            Id = 4,
            CategoryId = 1,
            Title = "HALAL Chicken Breast 5KG",
            Description = "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected,ensuring a premium dining experience that aligns with your dietary preferences. OVER HALF OFF!",
            Image = "/Images/chickenbreast1KG.png",
            Price = 15.00m,
            OriginalPrice = 37.00m,
            DateCreated = new DateTime(2024, 1, 1)
        },
         new Product
         {
             Id = 5,
             CategoryId = 1,
             Title = "HALAL Chicken Drumsticks (5 PIECES)",
             Description = "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.",
             Image = "/Images/Chicken-Drumsticks.png",
             Price = 5.00m,
             DateCreated = new DateTime(2024, 1, 1)

         },
          new Product
          {
              Id = 6,
              CategoryId = 1,
              Title = "HALAL Chicken Drumsticks (10 PIECES)",
              Description = "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.",
              Image = "/Images/Chicken-Drumsticks.png",
              Price = 9.95m,
              OriginalPrice = 12.15m,
              DateCreated = new DateTime(2024, 1, 1)

          },
             new Product
             {
                 Id = 7,
                 CategoryId = 1,
                 Title = "HALAL Chicken Drumsticks (15 PIECES)",
                 Description = "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.",
                 Image = "/Images/Chicken-Drumsticks.png",
                 Price = 14.30m,
                 DateCreated = new DateTime(2024, 1, 1)

             },
       new Product
       {
           Id = 8,
           CategoryId = 1,
           Title = "HALAL Chicken Mince (Keema) 500G",
           Description = "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.",
           Image = "/Images/Chicken-Mix-Mince.png",
           Price = 5.00m,
           OriginalPrice = 7.50m,
           DateCreated = new DateTime(2024, 1, 1)

       },
         new Product
         {
             Id = 9,
             CategoryId = 1,
             Title = "HALAL Chicken Mince (Keema) 2KG",
             Description = "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.",
             Image = "/Images/Chicken-Mix-Mince.png",
             Price = 8.50m,
             DateCreated = new DateTime(2024, 1, 1)

         },

         new Product
         {
             Id = 10,
             CategoryId = 2,
             Title = "HALAL Lamp Chops 500G",
             Description = "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously  sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering. ON SALE NOW. LIMITED TIME ONLY",
             Image = "/Images/LambChops1kg.png",
             Price = 7.00m,
             OriginalPrice = 12.60m,
             DateCreated = new DateTime(2024, 1, 1)
         },

        new Product
        {
            Id = 11,
            CategoryId = 2,
            Title = "HALAL Lamp Chops 1KG",
            Description = "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.",
            Image = "/Images/LambChops1kg.png",
            Price = 13.00m,
            DateCreated = new DateTime(2024, 1, 1)

        },
         new Product
         {
             Id = 12,
             CategoryId = 2,
             Title = "HALAL Lamp Chops 2KG",
             Description = "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.",
             Image = "/Images/LambChops1kg.png",
             Price = 24.95m,
             OriginalPrice = 26.50m,
             DateCreated = new DateTime(2024, 1, 1)
         },

        new Product
        {
            Id = 13,
            CategoryId = 2,
            Title = "HALAL Lamb Mince (Keema) 500G",
            Description = "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations. ON SALE NOW - LIMITED TIME ONLY!",
            Image = "/Images/LambMince1KG.png",
            Price = 5.00m,
            OriginalPrice = 7.00m,
            DateCreated = new DateTime(2024, 1, 1)
        },
         new Product
         {
             Id = 14,
             CategoryId = 2,
             Title = "HALAL Lamb Mince (Keema) 2KG",
             Description = "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations.",
             Image = "/Images/LambMince1KG.png",
             Price = 8.95m,
             DateCreated = new DateTime(2024, 1, 1)
         },
          new Product
          {
              Id = 15,
              CategoryId = 2,
              Title = "HALAL Lamb Steak",
              Description = "Transform your meals into culinary masterpieces with the premium taste and quality of our halal lamb steaks. Order now to bring home the unparalleled richness and tenderness that only halal-certified lamb can offer. Enjoy a dining experience that combines tradition and excellence with every flavorful bite.",
              Image = "/Images/Lamb-Leg-Steak.png",
              Price = 12.00m,
              OriginalPrice = 18.00m,
              DateCreated = new DateTime(2024, 1, 1)
          },
            new Product
            {
                Id = 16,
                CategoryId = 3,
                Title = "HALAL Mutton (DICED W/ BONE) 1KG",
                Description = "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.",
                Image = "/Images/Dice-Mutton.png",
                Price = 9.00m,
                DateCreated = new DateTime(2024, 1, 1)
            },
               new Product
               {
                   Id = 17,
                   CategoryId = 3,
                   Title = "HALAL Mutton (DICED W/ BONE) 2KG",
                   Description = "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.",
                   Image = "/Images/Dice-Mutton.png",
                   Price = 13.50m,
                   OriginalPrice = 18.00m,
                   DateCreated = new DateTime(2024, 1, 1)
               },
               new Product
               {
                   Id = 18,
                   CategoryId = 3,
                   Title = "HALAL Mixed Mutton 1KG",
                   Description = "Embark on a gastronomic adventure with our exquisite mixed mutton assortment – a carefully curated blend of diverse cuts that harmonize to create a culinary masterpiece. Crafted with precision and passion, this medley of mutton promises to captivate your palate and elevate your cooking to new heights.",
                   Image = "/Images/Mixed-Mutton.png",
                   Price = 7.50m,
                   OriginalPrice = 11.20m,
                   DateCreated = new DateTime(2024, 1, 1)
               },
               new Product
               {
                          Id = 19,
                          CategoryId = 3,
                          Title = "HALAL 7-Day Dry Aged Mutton 2KG",
                          Description = "Sourced from the finest cuts of mutton, our 7-day dry-aged process is a testament to patience and precision. The result? A masterpiece that boasts an intensified, concentrated flavor profile, bringing forth the sublime fusion of richness and tenderness that can only be achieved through the art of dry aging. ON SALE NOW- LIMITED TIME ONLY! ",
                          Image = "/Images/7Day-Aged-Mutton.png",
                          Price = 30.00m,
                          OriginalPrice = 45.00m,
                   DateCreated = new DateTime(2024, 1, 1)
               }


                );

            modelBuilder.Entity<Edition>().HasData //Multiple sizes FOR MEATS! 
           (
                new Edition { Id = 1, Name = "1KG" },

                new Edition { Id = 2, Name = "2KG" },

                new Edition { Id = 3, Name = "5KG" },

                new Edition { Id = 4, Name ="5(FIVE) Pieces"}, //PIECES FOR DRUMSTICKS 

                new Edition { Id = 5, Name = "10(TEN) Pieces" },

                new Edition { Id = 6, Name = "15(FIFTEEN) Pieces" },

                new Edition { Id = 7, Name = "500G" }
                

           );
            modelBuilder.SharedTypeEntity<Dictionary<string, object>>("EditionProduct").HasData( //Assigning multiple sizes to the database colums 
                
                new {EditionsId = 1, ProductsId = 2}, //For chicken breast, this will mean 1kg, 2kg and 5kg is available. and so on. 
                new { EditionsId = 2, ProductsId = 2 },
                new { EditionsId = 3, ProductsId = 2 },
                new { EditionsId = 4, ProductsId = 5 },
                new { EditionsId = 5, ProductsId = 5 },
                new { EditionsId = 6, ProductsId = 5 },
                new { EditionsId = 2, ProductsId = 9 },
                new { EditionsId = 7, ProductsId = 9 },
                new { EditionsId = 7, ProductsId = 10},
                new { EditionsId = 1, ProductsId = 10 },
                new { EditionsId = 2, ProductsId = 10 },
                new { EditionsId = 7, ProductsId = 13 },
                new { EditionsId = 2, ProductsId = 13 },
                new { EditionsId = 2, ProductsId = 15 },
                new { EditionsId = 1, ProductsId = 16 },
                new { EditionsId = 3, ProductsId = 16 },
                new { EditionsId = 1, ProductsId = 18 },
                new { EditionsId = 2, ProductsId = 19 },
                new { EditionsId = 2, ProductsId = 1 }


                );
        }
    }
}
