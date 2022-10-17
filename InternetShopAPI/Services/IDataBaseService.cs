using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Models;

namespace InternetShopAPI.Services;

public interface IDataBaseService
{
    Task addProduct(ProductCreateRequest productRequest);

    Task addProductAtribute(int id, Category category);
    Task addQuantityProduct(int id);

    Task changeProductAtribute(int id, Category category);

    Task deleteProduct(int id);

    Task<Product> getProductById(int id);

    Task<List<Product>> getProductsByCategory(Category category);
}
