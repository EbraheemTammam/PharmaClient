using System.Diagnostics.CodeAnalysis;

namespace Pharmacy.Domain.Models;


public abstract class OrderBase
{
    [AllowNull]
    public decimal? Paid {get; set;}
}
