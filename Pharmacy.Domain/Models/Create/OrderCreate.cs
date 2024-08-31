using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public class OrderCreate : OrderUpdate
{
    [Required]
    public required Guid CustomerId {get; set;}
}
