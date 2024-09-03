using Microsoft.Extensions.DependencyInjection;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Services;



public class ServiceManager : IServiceManager
{
    private readonly IServiceProvider _serviceProvider;
    public ServiceManager(IServiceProvider serviceProvider) =>
        _serviceProvider = serviceProvider;
    public IService<User> Users => _serviceProvider.GetRequiredService<IService<User>>();

    public IService<Product> Products => _serviceProvider.GetRequiredService<IService<Product>>();

    public IService<ProductProvider> ProductProviders => _serviceProvider.GetRequiredService<IService<ProductProvider>>();

    public IService<IncomingOrder> IncomingOrders => _serviceProvider.GetRequiredService<IService<IncomingOrder>>();

    public IService<ScarceProduct> ScarceProducts => _serviceProvider.GetRequiredService<IService<ScarceProduct>>();

    public ICustomerService Customers => _serviceProvider.GetRequiredService<ICustomerService>();

    public IService<Order> Orders => _serviceProvider.GetRequiredService<IService<Order>>();
}
