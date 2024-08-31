namespace Pharmacy.Domain.Models;



public class OrderItem : OrderItemBase
{
    public int Id {get; set;}
    public decimal Price {get; set;}
    public required string ProductName {get; set;}
    public int RemainedItems {get; set;}
}
