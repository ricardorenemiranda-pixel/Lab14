using lab08_ricardoquispea.Models;

namespace lab08_ricardoquispea.Repositories.Interfaces;

public interface IOrderDetailRepository : IGenericRepository<Orderdetail>
{
    Task<IEnumerable<object>> GetDetailsByOrderAsync(int orderId);
    Task<int> GetTotalQuantityByOrderAsync(int orderId);  
}