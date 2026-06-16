using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab08_ricardoquispea.Repositories;

public class OrderDetailRepository : GenericRepository<Orderdetail>, IOrderDetailRepository
{
    public OrderDetailRepository(LinqexampleContext context) : base(context) { }

    // 3
    public async Task<IEnumerable<object>> GetDetailsByOrderAsync(int orderId)
    {
        return await _context.Orderdetails
            .Where(od => od.Orderid == orderId)
            .Select(od => new
            {
                ProductName = od.Product.Name,
                od.Quantity
            })
            .ToListAsync<object>();
    }

    // 4
    public async Task<int> GetTotalQuantityByOrderAsync(int orderId)
    {
        return await _context.Orderdetails
            .Where(od => od.Orderid == orderId)
            .Select(od => od.Quantity)
            .SumAsync();
    }
}