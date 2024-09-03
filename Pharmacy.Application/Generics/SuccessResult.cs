namespace Pharmacy.Application.Generics;


public class SuccessResult<TData> : Result
{
    public TData Data {get; init;}
    public SuccessResult(TData data) : base(true) =>
        Data = data;
}
