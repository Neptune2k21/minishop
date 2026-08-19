using MiniShop.Api.Domain;
using MiniShop.Api.Domain.Repositories;
namespace MiniShop.Api.Application.Products.GetProducts;

public class GetProductsHandler
{
    private readonly IProductRepository _repository;
    
    public GetProductsHandler(IProductRepository repository)
    {
        _repository = repository;
    }
    public Product[] Handle()
    {
        return _repository.GetAll();
    }
}