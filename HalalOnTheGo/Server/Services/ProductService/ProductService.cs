using HalalOnTheGo.Server.Data;
using HalalOnTheGo.Server.Services.CategoryService;
using HalalOnTheGo.Shared;
using Microsoft.EntityFrameworkCore;

namespace HalalOnTheGo.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly ICategoryService _categoryService;
        private readonly DataContext _context;

        public ProductService(ICategoryService categoryService, DataContext context) //Data context setup for Loading Products from database! 
        {
                _categoryService = categoryService;
            _context = context;
        }

        public async Task<List<Product>> GetAllProducts() //Load products from database using entity framework!                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetProduct(int id) //Load products from database using entity framework! 
        {
            Product product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            return product;
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryUrl)
        {
            Category category = await _categoryService.GetCategoryByUrl(categoryUrl);
            return await _context.Products.Where(p => p.CategoryId == category.Id).ToListAsync(); //Load products from database using entity framework! 
        }

    }
}
