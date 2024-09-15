using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.Interfaces;



public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<ProductItem>> GetAboutToExpire();
}
