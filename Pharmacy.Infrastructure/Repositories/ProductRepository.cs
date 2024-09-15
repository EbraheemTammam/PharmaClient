using System.Net.Http.Json;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.Infrastructure.Repositories;



public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(HttpClient client) : base(client, "Api/Products") {}

    public async Task<IEnumerable<ProductItem>> GetAboutToExpire() =>
        (await _client.GetFromJsonAsync<IEnumerable<ProductItem>>($"{_path}/AboutToExpire"))!;
}
