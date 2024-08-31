using System.ComponentModel.DataAnnotations;
using Pharmacy.Domain.Validations;

namespace Pharmacy.Domain.Models;


public abstract class OrderItemBase
{
    [Required, NonNegative]
    public int Amount {get; set;}
}
