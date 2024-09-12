using MudBlazor.Services;
using Pharmacy.Domain.Models;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Application.Utilities;
using Pharmacy.Application.Services;

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
        services.AddServices();
        services.AddClient(configuration);
        return services;
    }

    public static IServiceCollection AddClient(this IServiceCollection services, IConfiguration configuration)
    {
        Uri BaseAddress = new(configuration.GetSection("BaseAddress").Value!);
        services.AddHttpClient<IService<User>, UserService>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IService<Product>, ProductService>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IService<ProductProvider>, GenericService<ProductProvider>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IService<ScarceProduct>, GenericService<ScarceProduct>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IService<IncomingOrder>, GenericService<IncomingOrder>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IService<Customer>, GenericService<Customer>>(client => client.BaseAddress = BaseAddress);
        services.AddHttpClient<IService<Order>, GenericService<Order>>(client => client.BaseAddress = BaseAddress);
        return services;
    }
}
