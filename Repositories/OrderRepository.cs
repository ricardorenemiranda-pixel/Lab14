using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab08_ricardoquispea.Repositories;

public class OrderRepository : GenericRepository<Order>, IOrderRepository
{
    public OrderRepository(LinqexampleContext context) : base(context) { }

    // Ejercicio 6
    public async Task<IEnumerable<Order>> GetOrdersAfterDateAsync(DateTime date)
    {
        return await _context.Orders
            .Where(o => o.Orderdate > date)
            .ToListAsync();
    }

    // Ejercicio 10
    public async Task<IEnumerable<object>> GetAllOrdersWithDetailsAsync()
    {
        return await _context.Orderdetails
            .Select(od => new
            {
                od.Orderid,
                ProductName = od.Product.Name,
                od.Quantity
            })
            .ToListAsync<object>();
    }
}