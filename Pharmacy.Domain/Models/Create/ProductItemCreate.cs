using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public class ProductItemCreate : ProductItemBase
{
    [Required]
    public Guid ProductId {get; set;}
}
