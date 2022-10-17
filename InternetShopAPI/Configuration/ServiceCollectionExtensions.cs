using InternetShopAPI.DataBase;
using InternetShopAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace InternetShopAPI.Configuration;

public static class ServiceCollectionExtensions
{
    public static void ConfigureService(this IServiceCollection services)
    {
        services.AddSingleton<ApiDbContext>();
        services.AddSingleton<IDataBaseService, DataBaseService>();
        services.AddSingleton<IProductService, ProductService>();  
    }
}
