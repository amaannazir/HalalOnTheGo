using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Client.Services.ProductService
{
    public interface IProductService
    {
        event Action OnChange; //Add event to load products 
        List<Product> Products { get; set; }
        Task LoadProducts(string categoryUrl = null);
        Task<Product> GetProduct(int id);
       
    }
}
