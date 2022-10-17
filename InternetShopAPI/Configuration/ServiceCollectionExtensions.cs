using InternetShopAPI.DataBase;
using InternetShopAPI.Services;

namespace InternetShopAPI.Configuration;

public static class ServiceCollectionExtensions
{
    public static void ConfigureService(this IServiceCollection services)
    {
        services.AddSingleton<IProductService,ProductService>();
        services.AddSingleton<ApiDbContext>();
    }
}
