using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Pharmacy.Domain.Models;



public abstract class CustomerBase
{
    [Required, MinLength(3), MaxLength(100)]
    public required string Name {get; set;}

    [AllowNull, DefaultValue(0)]
    public decimal Dept {get; set;}
}
