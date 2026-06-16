using lab08_ricardoquispea.Models;

namespace lab08_ricardoquispea.Repositories.Interfaces;

public interface IOrderRepository : IGenericRepository<Order>
{
    Task<IEnumerable<Order>> GetOrdersAfterDateAsync(DateTime date);
    Task<IEnumerable<object>> GetAllOrdersWithDetailsAsync();  //
}