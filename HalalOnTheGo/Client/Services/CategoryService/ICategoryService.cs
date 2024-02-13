using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Client.Services.CategoryService
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
       void LoadCategories();
    }
}
