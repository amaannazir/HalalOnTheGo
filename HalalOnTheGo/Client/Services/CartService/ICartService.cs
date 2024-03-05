using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart(ProductVariant productVariant);

    }
}
