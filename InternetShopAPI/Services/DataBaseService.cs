using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.DataBase;
using InternetShopAPI.Models;

namespace InternetShopAPI.Services;

public class DataBaseService : IDataBaseService
{
    private readonly ApiDbContext _apiDbContext;

    public DataBaseService(ApiDbContext apiDbContext)
    {
        _apiDbContext = apiDbContext;
    }

    public async Task addProduct(ProductCreateRequest productRequest)
    {
        var product = new Product()
        {
            Name = productRequest.Name,
            Category = productRequest.Category,
            Atribute = productRequest.Atribute
        };

        using (_apiDbContext)
        {
            await _apiDbContext.AddAsync(product);
            await _apiDbContext.SaveChangesAsync();
        }
        
        /*throw new NotImplementedException();*/
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
