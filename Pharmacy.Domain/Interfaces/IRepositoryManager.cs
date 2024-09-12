using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.Interfaces;


public interface IRepositoryManager
{
    IRepository<Product> Products {get; }
    IRepository<ProductProvider> ProductProviders {get; }
    IRepository<IncomingOrder> IncomingOrders {get; }
    IRepository<ScarceProduct> ScarceProducts {get; }
    ICustomerRepository Customers {get; }
    IRepository<Order> Orders {get; }
}
