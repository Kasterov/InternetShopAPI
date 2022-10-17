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

    public Task addProduct(ProductCreateRequest productRequest)
    {
        throw new NotImplementedException();
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
