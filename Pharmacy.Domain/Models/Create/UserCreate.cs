using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Pharmacy.Domain.Models;



public class UserCreate : UserBase
{
    [AllowNull, DefaultValue(false)]
    public bool IsManager {get; set;}

    [Required]
    public required string Password {get; set;}
}
