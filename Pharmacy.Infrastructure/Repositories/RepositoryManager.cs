using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.Infrastructure.Repositories;



public class RepositoryManager : IRepositoryManager
{
    private readonly IServiceProvider _serviceProvider;
    public RepositoryManager(IServiceProvider serviceProvider) =>
        _serviceProvider = serviceProvider;

    public IRepository<User> Users => _serviceProvider.GetRequiredService<IRepository<User>>();

    public IProductRepository Products => _serviceProvider.GetRequiredService<IProductRepository>();

    public IRepository<ProductProvider> ProductProviders => _serviceProvider.GetRequiredService<IRepository<ProductProvider>>();

    public IRepository<IncomingOrder> IncomingOrders => _serviceProvider.GetRequiredService<IRepository<IncomingOrder>>();

    public IRepository<ScarceProduct> ScarceProducts => _serviceProvider.GetRequiredService<IRepository<ScarceProduct>>();

    public ICustomerRepository Customers => _serviceProvider.GetRequiredService<ICustomerRepository>();

    public IRepository<Order> Orders => _serviceProvider.GetRequiredService<IRepository<Order>>();
}
