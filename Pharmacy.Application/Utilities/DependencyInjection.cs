using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Application.Services;
using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Utilities;



public static class DependencyInjection
{
    /// <summary>
    ///     Inject all the services
    /// </summary>
    /// <param name="services">IServiceCollection</param>
    /// <returns>A reference to this instance after injecting services</returns>
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<IServiceManager, ServiceManager>();
        services.AddScoped<IService<Product>, ProductService>();
        services.AddScoped<ICustomerService, CustomerService>();
        return services;
    }
}
