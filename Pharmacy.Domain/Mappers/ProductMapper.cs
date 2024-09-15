using Pharmacy.Domain.Models;

namespace Pharmacy.Domain.Mappers;


public static class ProductMapper
{
    public static ProductCreate ToProductCreate(this Product product) =>
        new()
        {
            Name = product.Name,
            Barcode = product.Barcode,
            NumberOfElements = product.NumberOfElements,
            PricePerElement = product.PricePerElement,
            Minimum = product.Minimum,
        };
}
