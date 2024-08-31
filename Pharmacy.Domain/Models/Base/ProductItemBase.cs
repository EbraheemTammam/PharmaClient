using System.ComponentModel.DataAnnotations;
using Pharmacy.Domain.Validations;

namespace Pharmacy.Domain.Models;



public abstract class ProductItemBase
{
    [Required]
    public DateOnly ExpirationDate {get; set;}

    [Required, NonNegative]
    public int NumberOfBoxes {get; set;}
}
