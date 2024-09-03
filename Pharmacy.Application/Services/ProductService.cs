using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Services;



public class ProductService : GenericService<Product>
{
    public ProductService(HttpClient client) : base(client, "Api/Products") {}
}
