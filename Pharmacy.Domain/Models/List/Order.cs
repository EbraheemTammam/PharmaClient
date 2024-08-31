namespace Pharmacy.Domain.Models;



public class Order : OrderBase
{
    public Guid Id {get; set;}
    public DateTime CreatedAt {get; set;}
    public decimal TotalPrice {get; set;}
    public required string CustomerName {get; set;}
    public required string CreatedBy {get; set;}
}
