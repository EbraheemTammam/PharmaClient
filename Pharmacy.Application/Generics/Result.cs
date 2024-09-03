namespace Pharmacy.Application.Generics;


public abstract class Result
{
    public bool Success {get; init;}
    protected Result(bool success) =>
        Success = success;
}
