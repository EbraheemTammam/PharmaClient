using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public class OrderItemCreate : OrderItemBase
{
    [Required]
    public Guid ProductId {get; set;}
}
