namespace Pharmacy.Application.Generics;


public class ErrorResult : Result
{
    public string ErrorMessage {get; init;}
    public ErrorResult(string error) : base(false) =>
        ErrorMessage = error;
}
