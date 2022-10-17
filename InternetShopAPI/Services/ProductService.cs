using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.DataBase;
using InternetShopAPI.Models;

namespace InternetShopAPI.Services;

public class ProductService : IProductService
{
    private readonly IDataBaseService _dataBaseService;
    public ProductService(IDataBaseService dataBaseService)
    {
        _dataBaseService = dataBaseService;
    }

    public async Task addProduct(ProductCreateRequest productRequest)
    {
        await _dataBaseService.addProduct(productRequest);
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
