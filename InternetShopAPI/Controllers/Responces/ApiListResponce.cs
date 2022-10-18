using InternetShopAPI.Models;

namespace InternetShopAPI.Controllers.Responces;

public sealed record ApiListResponce(List<Product> _Products)
{
    public Product[] Products = _Products.ToArray(); 
}
