using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public abstract class ProductProviderBase
{
    [Required, MinLength(3), MaxLength(100)]
    public required string Name {get; set;}
}
