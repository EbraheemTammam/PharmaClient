namespace Pharmacy.Domain.Models;



public class ProductItem : ProductItemBase
{
    public int Id {get; set;}
    public required string ProductName {get; set;}
    public decimal Price {get; set;}
}
