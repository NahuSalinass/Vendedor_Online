using Api.Funcionalities.Sellers;
using Api.Funcionalities.Stores;
namespace Api.Funcionalities;

public static class ServiceManager
{
    public static IServiceCollection AddAplicationServices(this IServiceCollection services)
    {
        services.AddScoped<ISellerService, SellerService>();
        services.AddScoped<IStoreService, StoreService>();

        return services;
    }
}