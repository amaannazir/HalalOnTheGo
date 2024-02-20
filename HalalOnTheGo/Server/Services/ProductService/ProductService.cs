using HalalOnTheGo.Server.Services.CategoryService;
using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;

        public ProductService(ICategoryService categoryService)
        {
                _categoryService = categoryService;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return Products;
        }

        public async Task<Product> GetProduct(int id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return Products.Where(p => p.CategoryId == category.Id).ToList();
        }

        public List<Product> Products { get; set; } = new List<Product>
      { 

       new Product
        {
            Id = 1,
            CategoryId = 1,
            Title = "HALAL Whole Chicken",
            Description = "Experience the epitome of freshness and quality with our HALAL whole chicken, now available for purchase on our website. Our HALAL-certified whole chickens are sourced from reputable farms, ensuring that you receive a product that aligns with your dietary preferences and cultural values. (BEST VALUE)",
            Image = "/Images/WholeChicken.png",
            Price = 5.00m
        },


        new Product
        {
            Id = 2,
            CategoryId = 1,
            Title = "HALAL Chicken Breast 1KG",
            Description = "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-                certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected,                    ensuring a premium dining experience that aligns with your dietary preferences.",
            Image = "/Images/chickenbreast1KG.png",
            Price = 4.50m
        },
        new Product
        {
            Id = 3,
            CategoryId = 1,
            Title = "HALAL Chicken Breast 2KG",
            Description = "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-                certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected,                    ensuring a premium dining experience that aligns with your dietary preferences.",
            Image = "/Images/chickenbreast1KG.png",
            Price = 6.00m
        },
        new Product
        {
            Id = 4,
            CategoryId = 1,
            Title = "HALAL Chicken Breast 5KG",
            Description = "Indulge in the unparalleled quality and authenticity of our halal butchered chicken breasts, where tradition meets excellence. Sourced from ethically-raised, halal-certified poultry, our chicken breasts are meticulously prepared to meet the highest standards of halal butchering. Each tender and succulent piece is carefully hand-selected,ensuring a premium dining experience that aligns with your dietary preferences. OVER HALF OFF!",
            Image = "/Images/chickenbreast1KG.png",
            Price = 15.00m,
            OriginalPrice = 37.00m
        },
         new Product
        {
            Id = 5,
            CategoryId = 1,
            Title = "HALAL Chicken Drumsticks (5 PIECES)",
            Description = "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.",
            Image = "/Images/Chicken-Drumsticks.png",
            Price = 5.00m

        },
          new Product
        {
            Id = 6,
            CategoryId = 1,
            Title = "HALAL Chicken Drumsticks (10 PIECES)",
            Description = "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.",
            Image = "/Images/Chicken-Drumsticks.png",
            Price = 9.95m

        },
             new Product
        {
            Id = 7,
            CategoryId = 1,
            Title = "HALAL Chicken Drumsticks (15 PIECES)",
            Description = "Delight your senses with our premium HALAL chicken drumsticks, now available for purchase on our website. Sourced from trusted and ethical producers, our HALAL-certified chicken drumsticks offer a perfect balance of quality, flavor, and convenience.",
            Image = "/Images/Chicken-Drumsticks.png",
            Price = 14.30m

        },
       new Product
        {
            Id = 8,
            CategoryId = 1,
            Title = "HALAL Chicken Mince (Keema) 500G",
            Description = "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.",
            Image = "/Images/Chicken-Mix-Mince.png",
            Price = 5.00m

        },
         new Product
        {
            Id = 9,
            CategoryId = 1,
            Title = "HALAL Chicken Mince (Keema) 2KG",
            Description = "Discover the convenience and versatility of our halal chicken mince, now available for purchase on our website. Sourced from trusted producers and crafted with care, our halal chicken mince provides a wholesome and flavorful option for a variety of culinary creations.",
            Image = "/Images/Chicken-Mix-Mince.png",
            Price = 8.50m

        },

         new Product
        {
            Id = 10,
            CategoryId = 2,
            Title = "HALAL Lamp Chops 500G",
            Description = "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously  sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering. ON SALE NOW. LIMITED TIME ONLY",
            Image = "/Images/LambChops1kg.png",
            Price = 7.00m,
            OriginalPrice = 12.60m
        },

        new Product
        {
            Id = 11,
            CategoryId = 2,
            Title = "HALAL Lamp Chops 1KG",
            Description = "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.",
            Image = "/Images/LambChops1kg.png",
            Price = 13.00m

        },
         new Product
        {
            Id = 12,
            CategoryId = 2,
            Title = "HALAL Lamp Chops 2KG",
            Description = "Savor the exquisite taste of our Halal Butchered Lamb Chops, a culinary delight crafted with the utmost respect for halal principles. Our lamb chops are meticulously               sourced from ethically-raised, halal-certified lambs, ensuring that every succulent bite adheres to the highest standards of halal butchering.",
            Image = "/Images/LambChops1kg.png",
            Price = 24.95m
        },

        new Product
        {
            Id = 13,
            CategoryId = 2,
            Title = "HALAL Lamb Mince (Keema) 500G",
            Description = "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations. ON SALE NOW - LIMITED TIME ONLY!",
            Image = "/Images/LambMince1KG.png",
            Price = 5.00m,
            OriginalPrice = 7.00m
        },
         new Product
        {
            Id = 14,
            CategoryId = 2,
            Title = "HALAL Lamb Mince (Keema) 2KG",
            Description = "Crafted with precision and care, our HALAL lamb mince is expertly ground to perfection, ensuring a delectable texture that enhances the richness of your favorite dishes. Whether you're preparing savory kebabs, hearty casseroles, or flavorful curries, our HALAL lamb mince adds a touch of authenticity and quality to your culinary creations.",
            Image = "/Images/LambMince1KG.png",
            Price = 8.95m
        },
          new Product
        {
            Id = 15,
            CategoryId = 2,
            Title = "HALAL Lamb Steak",
            Description = "Transform your meals into culinary masterpieces with the premium taste and quality of our halal lamb steaks. Order now to bring home the unparalleled richness and tenderness that only halal-certified lamb can offer. Enjoy a dining experience that combines tradition and excellence with every flavorful bite.",
            Image = "/Images/Lamb-Leg-Steak.png",
            Price = 12.00m
        },

            };
    }
}
