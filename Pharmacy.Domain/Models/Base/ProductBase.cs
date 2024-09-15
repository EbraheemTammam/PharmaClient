using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Pharmacy.Domain.Validations;

namespace Pharmacy.Domain.Models;



public abstract class ProductBase
{
    [AllowNull, MinLength(10), MaxLength(15)]
    public string? Barcode {get; set;}

    [Required, MinLength(3), MaxLength(100)]
    public string? Name {get; set;}

    [NonNegative, DefaultValue(1)]
    public int? NumberOfElements {get; set;}

    [Required, NonNegative]
    public double PricePerElement {get; set;}

    [Required, NonNegative, DefaultValue(0)]
    public int Minimum {get; set;}
}
