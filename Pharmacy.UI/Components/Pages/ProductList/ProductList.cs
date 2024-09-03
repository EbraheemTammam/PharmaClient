using Microsoft.AspNetCore.Components;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;

namespace Pharmacy.UI.Components;



public class ProductListBase : ComponentBase
{
    [Inject]
    private IServiceManager? _manager {get; set;}

    public IEnumerable<Product>? Products {get; set;}

    protected override async Task OnInitializedAsync() =>
        Products = await _manager!.Products.GetAll();
}
