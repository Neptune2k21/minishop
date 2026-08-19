using Microsoft.EntityFrameworkCore;
using MiniShop.Api.Domain;
using MiniShop.Api.Domain.Repositories;

namespace MiniShop.Api.Infrastructure.Persistence;

public class PostgresProductRepository : IProductRepository
{
    private readonly AppDbContext _db;

    public PostgresProductRepository(AppDbContext db)
    {
        _db = db;
    }

    public Product[] GetAll()
    {
        return _db.Products
            .AsNoTracking()
            .ToArray();
    }
    public void Add(Product product)
    {
        _db.Products.Add(product);
        _db.SaveChanges();
    }
}