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

    public async Task ChangeProductAtribute(int id, string atribute)
    {
        if (!await IsProductExist(id))
        {
            throw new ArgumentOutOfRangeException();
        }

        var product = await GetProduct(id);

        product.Atribute = atribute;
        await _apiDbContext.SaveChangesAsync();
    }

    public async Task DeleteProduct(int id)
    {
        if (!await IsProductExist(id))
        {
            throw new ArgumentOutOfRangeException();
        }

        var product = await GetProduct(id);
        _apiDbContext.Products.Remove(product);
        await _apiDbContext.SaveChangesAsync();
    }

    public async Task<Product> GetProductById(int id)
    {
        if (!await IsProductExist(id))
        {
            throw new ArgumentOutOfRangeException("No product with such id!");
        }

        return _apiDbContext.Products.Single(x => x.Id == id);
    }

    public async Task<List<Product>> GetProductsByCategory(Category category)
    {

        var products =
            await _apiDbContext.Products
            .Where(x => x.Category == category)
            .Select(x => new Product
            {
                Id = x.Id,
                Name = x.Name,
                Category = x.Category,
                Atribute = x.Atribute
            })
            .ToListAsync();

        return products;
    }

    private Task<bool> IsProductExist(int id) =>
        _apiDbContext.Products
            .AnyAsync(x => x.Id == id);

    private Task<Product> GetProduct(int id) =>
        _apiDbContext.Products
            .SingleAsync(x => x.Id == id);
}
