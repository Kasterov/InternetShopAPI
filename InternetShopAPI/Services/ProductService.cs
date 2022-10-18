using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.DataBase;
using InternetShopAPI.Models;
using InternetShopAPI.Models.Requests;
using Microsoft.EntityFrameworkCore;

namespace InternetShopAPI.Services;

public class ProductService : IProductService
{
    private readonly ApiDbContext _apiDbContext;
    public ProductService(ApiDbContext apiDbContext)
    {
        _apiDbContext = apiDbContext;
    }

    public async Task AddProduct(ProductCreateRequest productRequest)
    {
        var product = new Product()
        {
            Name = productRequest.Name,
            Category = productRequest.Category,
            Quantity = productRequest.Quantity,
            Atribute = productRequest.Atribute
        };

        await _apiDbContext.Products.AddAsync(product);
        await _apiDbContext.SaveChangesAsync();
    }

    public async Task AddProductAtribute(int id, string atribute)
    {
        if (!await IsProductExist(id))
        {
            throw new ArgumentOutOfRangeException();
        }

        var product = await GetProduct(id);

        if (product.Atribute is not "")
        {
            throw new ArgumentNullException();
        }

        product.Atribute = atribute;
        await _apiDbContext.SaveChangesAsync();
    }

    public async Task AddQuantityProduct(int id, uint quantity)
    {
        if (!await IsProductExist(id))
        {
            throw new ArgumentOutOfRangeException();
        }

        var product = await GetProduct(id);

        product.Quantity = quantity;
        await _apiDbContext.SaveChangesAsync();
    }

    public Task ChangeProductAtribute(int id, Category category)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<Product>> GetProductsByCategory(Category category)
    {
        throw new NotImplementedException();
    }

    private Task<bool> IsProductExist(int id) =>
        _apiDbContext.Products
            .AnyAsync(x => x.Id == id);

    private Task<Product> GetProduct(int id) =>
        _apiDbContext.Products
            .SingleAsync(x => x.Id == id);
}
