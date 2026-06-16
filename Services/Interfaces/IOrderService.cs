using lab08_ricardoquispea.Models;

namespace lab08_ricardoquispea.Services.Interfaces;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetOrdersAfterDateAsync(DateTime date);
    Task<IEnumerable<object>> GetAllOrdersWithDetailsAsync();  // 
}