using Blazored.LocalStorage;
using Blazored.Toast.Services;
using HalalOnTheGo.Client.Services.ProductService;
using HalalOnTheGo.Shared;
using System.Net.Http.Json;

namespace HalalOnTheGo.Client.Services.CartService
{
    public class CartService : ICartService
    {
        //INITIALIZING FIELDS
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;
        private readonly HttpClient _http; //FOR STRIPE CHECKOUT, LINK TO STRIPE PAYMENTS

        public event Action OnChange;


        // Constructor for CartService, initializing it with instances of required services.
        // _localStorage: ILocalStorageService for managing local storage operations.
        // _toastService: IToastService for displaying toast notifications.
        // _productService: IProductService for fetching product-related information.
        //_http: http call for checkout and payments for user.
        public CartService(ILocalStorageService localStorage, IToastService toastService, IProductService productService, HttpClient http) 
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
            _http = http; //STRIPE CHECKOUT HTTP CALL
        }

        // Asynchronously adds a ProductVariant to the 'cart'. Retrieves the current 'cart' from local storage and initializes it as a new list if not found.
        public async Task AddToCart(CartItem item)
        {
            // Adds the provided 'productVariant' to the 'cart' and updates the local storage accordingly. Fetches the corresponding product information for the added variant. Displays a success toast notification with the product title.
            
            
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                cart = new List<CartItem>();
            }

            var sameItem = cart //Check if same item exists
            .Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            if (sameItem == null)
            {
               cart.Add(item); //If item does not exist in cart, add it to cart.
            }
            else
            {
                sameItem.Quantity += item.Quantity; //Increment the cart number even if product is the same / multiple of same item.
            }

             //SAME IMPLEMENTATION I DID IN PRODUCT DETAILS PAGE
            await _localStorage.SetItemAsync("cart", cart); //Store cart in local strage

            var product = await _productService.GetProduct(item.ProductId);
            _toastService.ShowSuccess("Added to cart: " + product.Title);

            OnChange.Invoke(); // Invokes the OnChange event to notify observers about the cart change.
        }

        public async Task <List<CartItem>> GetCartItems() //Get all cart items from the local storage and loop through them using a loop. Then as that is happening add it to the CartItem LIST.
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if (cart == null)
            {
                return new List<CartItem>(); //Return an empty list if cart is empty
            }
            return cart; //return the cart with any items
        }
            
        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<CartItem>>("cart");
            if(cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }

        public async Task EmptyCart() //Method to empty cart once an order has been placed! 
        {
            await _localStorage.RemoveItemAsync("cart");
            OnChange.Invoke();
        }

        public async Task<string> Checkout() //Method for checkout - uses cart.razor
        {
            var result = await _http.PostAsJsonAsync("api/payment/checkout", await GetCartItems()); //API call to checkout payment service
            var url = await result.Content.ReadAsStringAsync();
            return url;
        }
    }
}
