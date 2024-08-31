using System.ComponentModel.DataAnnotations;
using Pharmacy.Domain.Validations;

namespace Pharmacy.Domain.Models;


public abstract class PaymentBase
{
    [Required, NonNegative]
    public decimal AmountPaid {get; set;}
}
