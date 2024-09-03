using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.Interfaces;


public interface IServiceManager
{
    IService<Product> Products {get; }
    IService<ProductProvider> ProductProviders {get; }
    IService<IncomingOrder> IncomingOrders {get; }
    IService<ScarceProduct> ScarceProducts {get; }
    ICustomerService Customers {get; }
    IService<Order> Orders {get; }
}
