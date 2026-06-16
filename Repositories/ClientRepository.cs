using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab08_ricardoquispea.Repositories;

public class ClientRepository : GenericRepository<Client>, IClientRepository
{
    public ClientRepository(LinqexampleContext context) : base(context) { }

    // Ejercicio 1
    public async Task<IEnumerable<Client>> GetByNameAsync(string name)
    {
        return await _context.Clients
            .Where(c => c.Name.Contains(name))
            .ToListAsync();
    }

    // Ejercicio 9
    public async Task<object?> GetClientWithMostOrdersAsync()
    {
        return await _context.Orders
            .GroupBy(o => o.Clientid)
            .OrderByDescending(g => g.Count())
            .Select(g => new
            {
                ClientId = g.Key,
                TotalOrders = g.Count(),
                ClientName = g.First().Client.Name
            })
            .FirstOrDefaultAsync();
    }

    // Ejercicio 12
    public async Task<IEnumerable<object>> GetClientsByProductAsync(int productId)
    {
        return await _context.Orderdetails
            .Where(od => od.Productid == productId)
            .Select(od => new
            {
                ClientName = od.Order.Client.Name
            })
            .Distinct()
            .ToListAsync<object>();
    }
}