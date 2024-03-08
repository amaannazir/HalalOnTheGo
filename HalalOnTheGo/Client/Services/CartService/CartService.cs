﻿using Blazored.LocalStorage;
using Blazored.Toast.Services;
using HalalOnTheGo.Client.Services.ProductService;
using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Client.Services.CartService
{
    public class CartService : ICartService
    {
        //INITIALIZING FIELDS
        private readonly ILocalStorageService _localStorage;
        private readonly IToastService _toastService;
        private readonly IProductService _productService;

        public event Action OnChange;


        // Constructor for CartService, initializing it with instances of required services.
        // _localStorage: ILocalStorageService for managing local storage operations.
        // _toastService: IToastService for displaying toast notifications.
        // _productService: IProductService for fetching product-related information.
        public CartService(ILocalStorageService localStorage, IToastService toastService, IProductService productService) 
        {
            _localStorage = localStorage;
            _toastService = toastService;
            _productService = productService;
        }

        // Asynchronously adds a ProductVariant to the 'cart'. Retrieves the current 'cart' from local storage and initializes it as a new list if not found.
        public async Task AddToCart(ProductVariant productVariant)
        {
            // Adds the provided 'productVariant' to the 'cart' and updates the local storage accordingly. Fetches the corresponding product information for the added variant. Displays a success toast notification with the product title.
            
            
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                cart = new List<ProductVariant>();
            }
            cart.Add(productVariant); //SAME IMPLEMENTATION I DID IN PRODUCT DETAILS PAGE
            await _localStorage.SetItemAsync("cart", cart);

            var product = await _productService.GetProduct(productVariant.ProductId);
            _toastService.ShowSuccess("Added to cart: " + product.Title);

            OnChange.Invoke(); // Invokes the OnChange event to notify observers about the cart change.
        }

        public async Task <List<CartItem>> GetCartItems() //Get all cart items from the local storage and loop through them using a loop. Then as that is happening add it to the CartItem LIST.
        {
            var result = new List<CartItem>();
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if (cart == null)
            {
                return result;
            }

            foreach (var item in cart) // Iterates through each item in the 'cart', fetching corresponding product information and creating a new CartItem with relevant details.
                                      
            {
                var product = await _productService.GetProduct(item.ProductId);
                var cartItem = new CartItem
                {
                    ProductId = product.Id,
                    ProductTitle = product.Title,
                    Image = product.Image,
                    EditionId = item.EditionId
                };

                // Finds the variant in the product's variants list that matches the EditionId of the current cart item. If a matching variant is found, updates the cart item with EditionName and Price.         
                      
                var variant = product.Variants.Find(v => v.EditionId == item.EditionId);
                if (variant != null)
                {
                    cartItem.EditionName = variant.Edition?.Name;
                    cartItem.Price = variant.Price;
                }

                result.Add(cartItem);  // Adds the cart item to the result list.
            }

            return result; //return the cartitem results!
        }
            
        public async Task DeleteItem(CartItem item)
        {
            var cart = await _localStorage.GetItemAsync<List<ProductVariant>>("cart");
            if(cart == null)
            {
                return;
            }

            var cartItem = cart.Find(x => x.ProductId == item.ProductId && x.EditionId == item.EditionId);
            cart.Remove(cartItem);

            await _localStorage.SetItemAsync("cart", cart);
            OnChange.Invoke();
        }
    }
}
