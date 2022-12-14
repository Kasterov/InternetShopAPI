using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.Models;

namespace InternetShopAPI.Services;

public interface IProductService
{
    Task AddProduct(ProductCreateRequest productCreateRequest);
    Task DeleteProduct(int id);
    Task AddQuantityProduct(int id, int quantity);
    Task ChangeProductAtribute(int id, string atribute);
    Task AddProductAtribute(int id, string atribute);
    Task<List<Product>> GetProductsByCategory(Category category);
    Task<Product> GetProductById(int id);
}
