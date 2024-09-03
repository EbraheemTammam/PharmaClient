using System.Net.Http.Json;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.Application.Services;



public class CustomerService : GenericService<Customer>, ICustomerService
{
    public CustomerService(HttpClient client) : base(client, "Api/Customers") {}

    public async Task<HttpResponseMessage> GetPayments(Guid customerId) =>
        await _client.GetAsync($"{_path}/{customerId}/Payments");

    public async Task<HttpResponseMessage> AddPayment(Guid customerId, PaymentCreate paymentCreate) =>
        await _client.PostAsJsonAsync($"{_path}/{customerId}/Payments", paymentCreate);

    public async Task<HttpResponseMessage> DeletePayment(Guid customerId, int paymentId) =>
        await _client.DeleteAsync($"{_path}/{customerId}/Payments/{paymentId}");
}
