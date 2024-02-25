using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category{Id = 1, Name ="Chicken", Url ="chicken", Icon ="food"},
                new Category{Id = 2, Name ="Lamb", Url="meat", Icon ="food"},
                new Category{Id = 3, Name ="Mutton", Url="mutton", Icon ="food"}
            };

        public async Task<List<Category>> GetCategories()
        {
            return Categories;
        }

        public async Task<Category> GetCategoryByUrl(string categoryUrl)
        {
           return Categories.FirstOrDefault(c => c.Url.ToLower().Equals(categoryUrl.ToLower()));
        }
    }
}
