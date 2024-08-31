using System.ComponentModel.DataAnnotations;

namespace Pharmacy.Domain.Models;



public class LoginCreate
{
    [Required, MaxLength(100), EmailAddress]
    public required string Email {get; set;}

    [Required]
    public required string Password {get; set;}
}
