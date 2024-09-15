using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Models;
using MudBlazor;

namespace Pharmacy.UI.Components.Dialogs;


public class ProductCreateDialogBase : ComponentBase
{
    [CascadingParameter]
    private MudDialogInstance? MudDialog { get; set; }

    [Inject]
    private IRepositoryManager? _manager {get; set;}

    [SupplyParameterFromForm]
    protected ProductCreate productCreate {get; set;} = new();

    [Parameter]
    public EventCallback<Product> OnProductCreated { get; set; }

    protected void CloseDialog() =>
        MudDialog!.Close(DialogResult.Ok(true));

    protected void CancelDialog() =>
        MudDialog!.Cancel();

    protected async void OnValidSubmit(EditContext context)
    {
        Product? product = await _manager!.Products.Create(productCreate);
        await OnProductCreated.InvokeAsync(product);
        StateHasChanged();
    }
}
