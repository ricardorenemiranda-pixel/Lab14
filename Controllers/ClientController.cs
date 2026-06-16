using lab08_ricardoquispea.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lab08_ricardoquispea.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientService _service;

    public ClientController(IClientService service) => _service = service;

    // Ejercicio 1
    [HttpGet("by-name")]
    public async Task<IActionResult> GetByName([FromQuery] string name)
    {
        var clients = await _service.GetByNameAsync(name);
        return Ok(clients);
    }

    // Ejercicio 9
    [HttpGet("most-orders")]
    public async Task<IActionResult> GetClientWithMostOrders()
    {
        var client = await _service.GetClientWithMostOrdersAsync();
        return Ok(client);
    }

    // Ejercicio 12
    [HttpGet("by-product/{productId}")]
    public async Task<IActionResult> GetClientsByProduct(int productId)
    {
        var clients = await _service.GetClientsByProductAsync(productId);
        return Ok(clients);
    }
}