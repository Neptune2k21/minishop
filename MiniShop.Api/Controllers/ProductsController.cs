using Microsoft.AspNetCore.Mvc;
using MiniShop.Api.Domain;
using MiniShop.Api.Application.Products.GetProducts;
using MiniShop.Api.Application.Products.CreateProduct;

namespace MiniShop.Api.Controllers;

[ApiController]
[Route("products")]
public class ProductsController : ControllerBase
{
    private readonly GetProductsHandler _getProductshandler;
    private readonly CreateProductHandler _createProductHandler;
    
    public ProductsController(GetProductsHandler handler, CreateProductHandler command)
    {
        _getProductshandler = handler;
        _createProductHandler = command;
    }


    [HttpGet]
    public ActionResult<Product[]> GetProducts()
    {
        var products = _getProductshandler.Handle();
        return Ok(products);
    }
    [HttpPost]
    public Product CreateProduct(CreateProductCommand command)
    {
        return _createProductHandler.Handle(command);
    }
}