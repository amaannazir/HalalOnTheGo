using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Client.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>();

        public void LoadCategories()
        {
            Categories = new List<Category>
            {
                new Category{Id = 1, Name ="Chicken", Url ="chicken", Icon ="chicken"},
                new Category{Id = 2, Name ="Meat", Url="meat", Icon ="steak"}
            };
        }
    }
}
