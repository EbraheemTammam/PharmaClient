using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Repositories;



public class RepositoryManager : IRepositoryManager
{
    private readonly IServiceProvider _serviceProvider;
    public RepositoryManager(IServiceProvider serviceProvider) =>
        _serviceProvider = serviceProvider;
    public IRepository<User> Users => _serviceProvider.GetRequiredService<IRepository<User>>();

    public IRepository<Product> Products => _serviceProvider.GetRequiredService<IRepository<Product>>();

    public IRepository<ProductProvider> ProductProviders => _serviceProvider.GetRequiredService<IRepository<ProductProvider>>();

    public IRepository<IncomingOrder> IncomingOrders => _serviceProvider.GetRequiredService<IRepository<IncomingOrder>>();

    public IRepository<ScarceProduct> ScarceProducts => _serviceProvider.GetRequiredService<IRepository<ScarceProduct>>();

    public ICustomerRepository Customers => _serviceProvider.GetRequiredService<ICustomerRepository>();

    public IRepository<Order> Orders => _serviceProvider.GetRequiredService<IRepository<Order>>();
}
