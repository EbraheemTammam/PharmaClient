using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.Interfaces;



public interface ICustomerRepository : IRepository<Customer>
{
    Task<HttpResponseMessage> GetPayments(Guid customerId);
    Task<HttpResponseMessage> AddPayment(Guid customerId, PaymentCreate paymentCreate);
    Task<HttpResponseMessage> DeletePayment(Guid customerId, int paymentId);
}
