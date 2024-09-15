using Microsoft.AspNetCore.Components;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.UI.Components.Pages;



public class ExpiringSoonBase : ComponentBase
{
    [Inject]
    private IRepositoryManager? _manager {get; set;}

    protected string? searchString {get; set;}

    protected IEnumerable<ProductItem>? Products {get; set;}

    protected override async Task OnInitializedAsync() =>
        Products = await _manager!.Products.GetAboutToExpire();

    protected bool FilterFunc(ProductItem product)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (product.ProductName!.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
}
