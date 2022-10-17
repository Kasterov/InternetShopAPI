using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Models;

namespace InternetShopAPI.Services;

public interface IProductService
{
    Task addProduct(ProductCreateRequest productCreateRequest);
    Task deleteProduct(int id);
    Task addQuantityProduct(int id);
    Task changeProductAtribute(int id, Category category);
    Task addProductAtribute(int id, Category category);
    Task<List<Product>> getProductsByCategory(Category category);
    Task<Product> getProductById(int id);
}
