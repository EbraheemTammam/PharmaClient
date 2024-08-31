using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public class OrderUpdate : OrderBase
{
    [Required]
    public required IEnumerable<OrderItemCreate> Items {get; set;}
}
