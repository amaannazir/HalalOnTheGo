using HalalOnTheGo.Server.Data;
using HalalOnTheGo.Shared;
using Microsoft.EntityFrameworkCore;

namespace HalalOnTheGo.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context; //set the context 
        }
        public async Task<List<Category>> GetCategories() //LOADING THE CATEGORIES FROM THE DATABASE! 
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl) //Loading from database using Async!
        {
           return await _context.Categories.FirstOrDefaultAsync(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
