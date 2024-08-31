namespace Pharmacy.Domain.Models;



public class Payment : PaymentBase
{
    public int Id {get; set;}
    public DateTime CreatedAt {get; set;}
}
