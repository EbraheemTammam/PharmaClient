using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Repositories;



public class ProductRepository : GenericRepository<Product>
{
    public ProductRepository(HttpClient client) : base(client, "Api/Products") {}
}
