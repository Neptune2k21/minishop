namespace MiniShop.Api.Application.Products.CreateProduct;

public record CreateProductCommand(
    string Name,
    decimal Price
);