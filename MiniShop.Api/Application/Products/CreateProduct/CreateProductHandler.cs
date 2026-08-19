using MiniShop.Api.Domain;
using MiniShop.Api.Domain.Repositories;

namespace MiniShop.Api.Application.Products.CreateProduct;

public class CreateProductHandler
{
    private readonly IProductRepository _repository;

    public CreateProductHandler(IProductRepository repository)
    {
        _repository = repository;
    }

    public Product Handle(CreateProductCommand command)
    {
        var product = new Product
        {
            Name = command.Name,
            Price = command.Price
        };

        _repository.Add(product);

        return product;
    }
}