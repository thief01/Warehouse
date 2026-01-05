using backend.Models;
using backend.Services;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpPost("add")]
    public IActionResult Add(Product product)
    {
        return Ok(_productService.Add(product));
    }

    [HttpGet("list")]
    public IActionResult GetAll()
    {
        return Ok(_productService.GetAll());
    }
}