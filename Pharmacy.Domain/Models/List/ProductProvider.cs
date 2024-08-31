namespace Pharmacy.Domain.Models;



public class ProductProvider : ProductProviderBase
{
    public Guid Id {get; set;}
    public decimal Indepted {get; set;}
}
