﻿using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Models;

namespace InternetShopAPI.Services;

public class ProductService : IProductService
{
    public async Task addProduct(ProductCreateRequest productRequest)
    {
        var product = new Product()
        {
            Name = productRequest.Name,
            Category = productRequest.Category,
            Atribute = productRequest.Atribute
        };

        
    }

    public Task addProductAtribute(int id, Category category)
    {
        throw new NotImplementedException();
    }

    public Task addQuantityProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task changeProductAtribute(int id, Category category)
    {
        throw new NotImplementedException();
    }

    public Task deleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> getProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> getProductsByCategory(Category category)
    {
        throw new NotImplementedException();
    }
}
