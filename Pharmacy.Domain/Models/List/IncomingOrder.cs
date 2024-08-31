namespace Pharmacy.Domain.Models;



public class IncomingOrder : IncomingOrderBase
{
    public Guid Id {get; set;}
    public DateTime CreatedAt {get; set;}
    public required string ProviderName {get; set;}
}
