using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Client.Services.ProductService
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
       

        
    }
}
