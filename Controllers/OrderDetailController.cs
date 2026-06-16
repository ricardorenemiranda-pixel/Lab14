using lab08_ricardoquispea.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace lab08_ricardoquispea.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderDetailController : ControllerBase
{
    private readonly IOrderDetailService _service;

    public OrderDetailController(IOrderDetailService service) => _service = service;

    //  3
    [HttpGet("by-order/{orderId}")]
    public async Task<IActionResult> GetDetailsByOrder(int orderId)
    {
        var details = await _service.GetDetailsByOrderAsync(orderId);
        return Ok(details);
    }

    // 4
    [HttpGet("total-quantity/{orderId}")]
    public async Task<IActionResult> GetTotalQuantity(int orderId)
    {
        var total = await _service.GetTotalQuantityByOrderAsync(orderId);
        return Ok(total);
    }
}