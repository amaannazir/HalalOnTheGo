﻿using HalalOnTheGo.Shared;

namespace HalalOnTheGo.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts(); //Calling function to get ALL products
        Task<List<Product>> GetProductsByCategory(string categoryUrl); // Gets Category specific products, in Lamb, Mutton and chicken VIA URL.
        Task<Product> GetProduct(int id); //Get products by product ID
        Task<List<Product>> SearchProducts(string searchText);
    }
}
