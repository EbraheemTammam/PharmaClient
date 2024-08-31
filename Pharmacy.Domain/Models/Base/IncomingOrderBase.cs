using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Pharmacy.Domain.Validations;

namespace Pharmacy.Domain.Models;



public abstract class IncomingOrderBase
{
    [Required, NonNegative]
    public decimal Price {get; set;}

    [Required, NonNegative, DefaultValue(0)]
    public decimal Paid {get; set;} = 0;
}
