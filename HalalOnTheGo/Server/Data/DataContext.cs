using HalalOnTheGo.Shared;
using Microsoft.EntityFrameworkCore;

namespace HalalOnTheGo.Server.Data
{
    public class DataContext : DbContext //Db context for categories and products 
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; } //Creating tables and giving names:
        public DbSet<Product> Products { get; set; }
        public DbSet<Edition> Editions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.EditionId });

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
                    Title = "HALAL Whole Chicken 2KG",
                    Description = "Experience the epitome of freshness and quality with our HALAL whole chicken, now available for purchase on our website. Our HALAL-certified whole chickens are sourced from reputable farms, ensuring that you receive a product that aligns with your dietary preferences and cultural values. (BEST VALUE)",
                    Image = "/Images/WholeChicken.png",
                    DateCreated = new DateTime(2024, 1, 1)
                },


        new Product
        {
            Id = 2,
            CategoryId = 1,
            Title = "HALAL Chicken Breast",
            Description = "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected, ensuring a premium dining experience that aligns with your dietary preferences.",
            Image = "/Images/chickenbreast1KG.png",
            DateCreated = new DateTime(2024, 1, 1)
        },
         new Product
         {
             Id = 3,
             CategoryId = 1,
             Title = "HALAL Chicken Drumsticks",
             Description = "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.",
             Image = "/Images/Chicken-Drumsticks.png",
             DateCreated = new DateTime(2024, 1, 1)

         },

       new Product
       {
           Id = 4,
           CategoryId = 1,
           Title = "HALAL Chicken Mince (Keema)",
           Description = "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.",
           Image = "/Images/Chicken-Mix-Mince.png",
           DateCreated = new DateTime(2024, 1, 1)

       },

         new Product
         {
             Id = 5,
             CategoryId = 2,
             Title = "HALAL Lamp Chops",
             Description = "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously  sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering. ON SALE NOW. LIMITED TIME ONLY",
             Image = "/Images/LambChops1kg.png",
             DateCreated = new DateTime(2024, 1, 1)
         },

        new Product
        {
            Id = 6,
            CategoryId = 2,
            Title = "HALAL Lamb Mince (Keema)",
            Description = "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations. ON SALE NOW - LIMITED TIME ONLY!",
            Image = "/Images/LambMince1KG.png",
            DateCreated = new DateTime(2024, 1, 1)
        },
          new Product
          {
              Id = 7,
              CategoryId = 2,
              Title = "HALAL Lamb Steak",
              Description = "Transform your meals into culinary masterpieces with the premium taste and quality of our halal lamb steaks. Order now to bring home the unparalleled richness and tenderness that only halal-certified lamb can offer. Enjoy a dining experience that combines tradition and excellence with every flavorful bite.",
              Image = "/Images/Lamb-Leg-Steak.png",
              DateCreated = new DateTime(2024, 1, 1)
          },
            new Product
            {
                Id = 8,
                CategoryId = 3,
                Title = "HALAL Mutton (DICED W/ BONE)",
                Description = "Elevate your culinary adventures with our premium diced with bone mutton, a tantalizing symphony of flavor and tenderness that promises to redefine your dining experience. Sourced from the finest pastures and carefully selected for its exceptional quality, our mutton is a testament to the artistry of butchery.",
                Image = "/Images/Dice-Mutton.png",
                DateCreated = new DateTime(2024, 1, 1)
            },
               new Product
               {
                   Id = 9,
                   CategoryId = 3,
                   Title = "HALAL Mixed Mutton",
                   Description = "Embark on a gastronomic adventure with our exquisite mixed mutton assortment – a carefully curated blend of diverse cuts that harmonize to create a culinary masterpiece. Crafted with precision and passion, this medley of mutton promises to captivate your palate and elevate your cooking to new heights.",
                   Image = "/Images/Mixed-Mutton.png",
                   DateCreated = new DateTime(2024, 1, 1)
               },
               new Product
               {
                   Id = 10,
                   CategoryId = 3,
                   Title = "HALAL 7-Day Dry Aged Mutton",
                   Description = "Sourced from the finest cuts of mutton, our 7-day dry-aged process is a testament to patience and precision. The result? A masterpiece that boasts an intensified, concentrated flavor profile, bringing forth the sublime fusion of richness and tenderness that can only be achieved through the art of dry aging. ON SALE NOW- LIMITED TIME ONLY! ",
                   Image = "/Images/7Day-Aged-Mutton.png",
                   DateCreated = new DateTime(2024, 1, 1)
               }


                );

            modelBuilder.Entity<Edition>().HasData //Multiple sizes FOR MEATS! 
           (
                new Edition { Id = 1, Name = "Default" },

                new Edition { Id = 2, Name = "1KG" },

                new Edition { Id = 3, Name = "2KG" },

                new Edition { Id = 4, Name = "5KG" },

                new Edition { Id = 5, Name = "5(FIVE) Pieces" }, //PIECES FOR DRUMSTICKS 

                new Edition { Id = 6, Name = "10(TEN) Pieces" },

                new Edition { Id = 7, Name = "15(FIFTEEN) Pieces" },

                new Edition { Id = 8, Name = "500G" }

           );
            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 2,
                    Price = 4.50m

                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 3,
                    Price = 6.00m,
                    OriginalPrice = 10.00m

                },
                new ProductVariant
                {
                    ProductId = 2,
                    EditionId = 4,
                    Price = 15.00m,
                    OriginalPrice = 37.00m

                },
                 new ProductVariant
                 {
                     ProductId = 3,
                     EditionId = 5,
                     Price = 5.00m


                 },
                  new ProductVariant
                  {
                      ProductId = 3,
                      EditionId = 6,
                      Price = 9.95m,
                      OriginalPrice = 12.15m

                  },
                   new ProductVariant
                   {
                       ProductId = 4,
                       EditionId = 8,
                       Price = 5.00m,


                   },
                    new ProductVariant
                    {
                        ProductId = 4,
                        EditionId = 3,
                        Price = 8.50m

                    },
                   new ProductVariant
                   {
                       ProductId = 3,
                       EditionId = 7,
                       Price = 14.30m

                   },
                    new ProductVariant
                    {
                        ProductId = 6,
                        EditionId = 8,
                        Price = 5.00m,
                        OriginalPrice = 7.95m

                    },
                     new ProductVariant
                     {
                         ProductId = 6,
                         EditionId = 2,
                         Price = 9.95m

                     },
                      new ProductVariant
                      {
                          ProductId = 5,
                          EditionId = 8,
                          Price = 7.00m,
                          OriginalPrice = 12.60m

                      },
                      new ProductVariant
                      {
                          ProductId = 5,
                          EditionId = 2,
                          Price = 13.00m

                      },
                       new ProductVariant
                       {
                           ProductId = 5,
                           EditionId = 3,
                           Price = 24.95m,
                           OriginalPrice = 26.50m

                       },
                        new ProductVariant
                        {
                            ProductId = 8,
                            EditionId = 2,
                            Price = 9.00m,


                        },
                        new ProductVariant
                        {
                            ProductId = 8,
                            EditionId = 3,
                            Price = 13.50m,
                            OriginalPrice = 18.00m
                        },
                         new ProductVariant
                         {
                             ProductId = 9,
                             EditionId = 2,
                             Price = 7.50m,
                             OriginalPrice = 11.20m
                         },
                         new ProductVariant
                         {
                             ProductId = 9,
                             EditionId = 3,
                             Price = 23.00m

                         },
                         new ProductVariant
                         {
                             ProductId = 10,
                             EditionId = 3,
                             Price = 30.00m,
                             OriginalPrice = 45.00m

                         },
                         new ProductVariant
                         {
                             ProductId = 10,
                             EditionId = 1,
                             Price = 33.00m,

                         },
                         new ProductVariant
                         {
                             ProductId = 1,
                             EditionId = 3,
                             Price = 7.00m

                         },
                         new ProductVariant
                         {
                             ProductId = 7,
                             EditionId = 2,
                             Price = 12.00m,
                             OriginalPrice = 18.00m

                         }

                );
        }
    }
}
