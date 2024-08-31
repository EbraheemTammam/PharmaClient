using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public abstract class UserBase
{
    [Required, MinLength(3), MaxLength(150)]
    public required string FirstName {get; set;}

    [Required, MinLength(3), MaxLength(150)]
    public required string LastName {get; set;}

    [Required, MaxLength(150), EmailAddress]
    public required string Email {get; set;}
}
