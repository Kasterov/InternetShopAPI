using InternetShopAPI.DataBase;
using InternetShopAPI.Services;
using InternetShopAPI.Models;
using FluentValidation;

namespace InternetShopAPI.Configuration;

public static class ServiceCollectionExtensions
{
    public static void ConfigureService(this IServiceCollection services)
    {
        services.AddSingleton<ApiDbContext>();
        services.AddSingleton<IProductService, ProductService>();
        services.AddScoped<IValidator<Product>,ProductValidator>();
    }
}
