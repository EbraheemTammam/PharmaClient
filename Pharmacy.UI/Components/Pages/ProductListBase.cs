using Microsoft.AspNetCore.Components;
using MudBlazor;
using Pharmacy.Domain.Interfaces;
using Pharmacy.Domain.Mappers;
using Pharmacy.Domain.Models;
using Pharmacy.UI.Components.Dialogs;

namespace Pharmacy.UI.Components.Pages;



public class ProductListBase : ComponentBase
{
    [Inject]
    private IRepositoryManager? _manager {get; set;}

    [Inject]
    private IDialogService? DialogService { get; set; }

    protected Product? productBeforeEdit;

    protected List<Product>? Products {get; set;}

    protected Product? ProductToBeUpdated {get; set;}

    protected string? searchString {get; set;}

    protected override async Task OnInitializedAsync() =>
        Products ??= (List<Product>)await _manager!.Products.GetAll();

    private void _onProductCreated(Product newProduct) => Products?.Add(newProduct);

    protected async Task OpenCreateDialog()
    {
        var parameters = new DialogParameters
        {
            { "OnProductCreated", new EventCallbackFactory().Create<Product>(this, _onProductCreated) }
        };
        var options = new DialogOptions {CloseOnEscapeKey = true};
        await DialogService!.ShowAsync<ProductCreateDialog>("Create Product", parameters, options);
    }

    protected void BackupProduct(object product) =>
        productBeforeEdit = (Product)product;

    protected void ResetProduct(object product) =>
        product = productBeforeEdit!;

    protected async Task UpdateProduct(object product)
    {
        Product productToBeUpdated = (Product)product;
        await _manager!.Products.Update(productToBeUpdated!.Id, productToBeUpdated.ToProductCreate());
    }

    protected async Task DeleteProduct(Product product)
    {
        Products!.Remove(product);
        await _manager!.Products.Delete(product.Id);
    }

    protected bool FilterFunc(Product product)
    {
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (product.Name!.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (product.Barcode is not null && product.Barcode!.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        return false;
    }
}
