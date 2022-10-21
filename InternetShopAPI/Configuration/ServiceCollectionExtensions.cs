using InternetShopAPI.Controllers.Requests;
using InternetShopAPI.DataBase;
using InternetShopAPI.Services;
using FluentValidation;
using InternetShopAPI.Controllers.Requests.Validators;

namespace InternetShopAPI.Configuration;

public static class ServiceCollectionExtensions
{
    public static void ConfigureService(this IServiceCollection services)
    {
        services.AddSingleton<ApiDbContext>()
                .AddSingleton<IProductService, ProductService>()
                .AddValidatorsFromAssemblyContaining<ProductValidator>(ServiceLifetime.Singleton);
    }
}
