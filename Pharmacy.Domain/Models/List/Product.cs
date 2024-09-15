namespace Pharmacy.Domain.Models;



public class Product : ProductBase
{
    public Guid Id {get; set;}
    public bool IsLack {get; set;}
    public int OwnedElements {get; set;}
    public int BoxesOwned {get; set;}
}
