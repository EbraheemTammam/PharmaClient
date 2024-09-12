using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Infrastructure.Repositories;
using Pharmacy.Domain.Models;

namespace Pharmacy.Infrastructure.Utilities;



public static class DependencyInjection
{
    /// <summary>
    ///     Inject all the Repositorys
    /// </summary>
    /// <param name="services">IRepositoryCollection</param>
    /// <returns>A reference to this instance after injecting Repositorys</returns>
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRepositoryManager, RepositoryManager>();
        services.AddScoped<IRepository<Product>, ProductRepository>();
        services.AddScoped<ICustomerRepository, CustomerRepository>();
        return services;
    }
}
