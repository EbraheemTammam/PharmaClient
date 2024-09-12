using MudBlazor.Services;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Infrastructure.Utilities;
using Pharmacy.Infrastructure.Repositories;

namespace Pharmacy.UI.Utilities;



public static class ServiceExtensionscd
{
    public static IServiceCollection Configure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRazorComponents()
                .AddInteractiveServerComponents();
        services.AddRazorComponents()
                .AddInteractiveWebAssemblyComponents();
        services.AddMudEventManager();
        services.AddMudBlazorJsEvent();
        services.AddMudServices();
        services.AddRepositories();
        services.AddClient(configuration);
        return services;
    }

    public static IServiceCollection AddClient(this IServiceCollection services, IConfiguration configuration)
    {
        Uri BaseAddress = new(configuration.GetSection("BaseAddress").Value!);
        services.AddHttpClient<IRepository<User>, UserRepository>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IRepository<Product>, ProductRepository>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IRepository<ProductProvider>, GenericRepository<ProductProvider>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IRepository<ScarceProduct>, GenericRepository<ScarceProduct>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IRepository<IncomingOrder>, GenericRepository<IncomingOrder>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IRepository<Customer>, GenericRepository<Customer>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IRepository<Order>, GenericRepository<Order>>(client => client.BaseAddress = BaseAddress);
        return services;
    }
}
