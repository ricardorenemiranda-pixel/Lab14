using lab08_ricardoquispea.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lab08_ricardoquispea.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _service;

    public ProductController(IProductService service) => _service = service;

    // Ejercicio 2
    [HttpGet("by-price")]
    public async Task<IActionResult> GetByPrice([FromQuery] decimal minPrice)
    {
        var products = await _service.GetByPriceGreaterThanAsync(minPrice);
        return Ok(products);
    }

    // Ejercicio 5
    [HttpGet("most-expensive")]
    public async Task<IActionResult> GetMostExpensive()
    {
        var product = await _service.GetMostExpensiveAsync();
        return Ok(product);
    }

    // Ejercicio 7
    [HttpGet("average-price")]
    public async Task<IActionResult> GetAveragePrice()
    {
        var average = await _service.GetAveragePriceAsync();
        return Ok(average);
    }

    // Ejercicio 8
    [HttpGet("without-description")]
    public async Task<IActionResult> GetWithoutDescription()
    {
        var products = await _service.GetWithoutDescriptionAsync();
        return Ok(products);
    }

    // Ejercicio 11
    [HttpGet("by-client/{clientId}")]
    public async Task<IActionResult> GetProductsByClient(int clientId)
    {
        var products = await _service.GetProductsByClientAsync(clientId);
        return Ok(products);
    }
}