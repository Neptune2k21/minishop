using MiniShop.Api.Domain;

namespace MiniShop.Api.Domain.Repositories;

public interface IProductRepository
{
    Product[] GetAll();
    void Add(Product product);
}