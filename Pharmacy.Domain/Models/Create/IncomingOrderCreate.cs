using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public class IncomingOrderCreate : IncomingOrderBase
{
    [Required]
    public Guid ProviderId {get; set;}

    [Required]
    public required IEnumerable<ProductItemCreate> ProductItems {get; set;}
}
