using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Repositories;



public class RepositoryManager : IRepositoryManager
{
    private readonly IRepositoryProvider _RepositoryProvider;
    public RepositoryManager(IRepositoryProvider RepositoryProvider) =>
        _RepositoryProvider = RepositoryProvider;
    public IRepository<User> Users => _RepositoryProvider.GetRequiredRepository<IRepository<User>>();

    public IRepository<Product> Products => _RepositoryProvider.GetRequiredRepository<IRepository<Product>>();

    public IRepository<ProductProvider> ProductProviders => _RepositoryProvider.GetRequiredRepository<IRepository<ProductProvider>>();

    public IRepository<IncomingOrder> IncomingOrders => _RepositoryProvider.GetRequiredRepository<IRepository<IncomingOrder>>();

    public IRepository<ScarceProduct> ScarceProducts => _RepositoryProvider.GetRequiredRepository<IRepository<ScarceProduct>>();

    public ICustomerRepository Customers => _RepositoryProvider.GetRequiredRepository<ICustomerRepository>();

    public IRepository<Order> Orders => _RepositoryProvider.GetRequiredRepository<IRepository<Order>>();
}
