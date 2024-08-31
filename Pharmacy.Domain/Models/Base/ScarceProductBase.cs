using System.ComponentModel.DataAnnotations;
using Pharmacy.Domain.Validations;

namespace Pharmacy.Domain.Models;



public abstract class ScarceProductBase
{
    [Required, MinLength(3), MaxLength(250)]
    public required string Name {get; set;}

    [Required, NonNegative]
    public int Amount {get; set;}
}
