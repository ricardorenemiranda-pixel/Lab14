using lab08_ricardoquispea.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lab08_ricardoquispea.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _service;

    public OrderController(IOrderService service) => _service = service;

    // Ejercicio 6
    [HttpGet("after-date")]
    public async Task<IActionResult> GetOrdersAfterDate([FromQuery] DateTime date)
    {
        var orders = await _service.GetOrdersAfterDateAsync(date);
        return Ok(orders);
    }

    // Ejercicio 10
    [HttpGet("with-details")]
    public async Task<IActionResult> GetAllOrdersWithDetails()
    {
        var orders = await _service.GetAllOrdersWithDetailsAsync();
        return Ok(orders);
    }
}