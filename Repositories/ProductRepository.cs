using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace lab08_ricardoquispea.Repositories;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(LinqexampleContext context) : base(context) { }

    // Ejercicio 2
    public async Task<IEnumerable<Product>> GetByPriceGreaterThanAsync(decimal price)
    {
        return await _context.Products
            .Where(p => p.Price > price)
            .ToListAsync();
    }

    // Ejercicio 5
    public async Task<Product?> GetMostExpensiveAsync()
    {
        return await _context.Products
            .OrderByDescending(p => p.Price)
            .FirstOrDefaultAsync();
    }

    // Ejercicio 7
    public async Task<decimal> GetAveragePriceAsync()
    {
        return await _context.Products
            .Select(p => p.Price)
            .AverageAsync();
    }

    // Ejercicio 8
    public async Task<IEnumerable<Product>> GetWithoutDescriptionAsync()
    {
        return await _context.Products
            .Where(p => string.IsNullOrEmpty(p.Description))
            .ToListAsync();
    }

    // Ejercicio 11
    public async Task<IEnumerable<object>> GetProductsByClientAsync(int clientId)
    {
        return await _context.Orders
            .Where(o => o.Clientid == clientId)
            .SelectMany(o => o.Orderdetails.Select(od => new
            {
                ProductName = od.Product.Name
            }))
            .Distinct()
            .ToListAsync<object>();
    }
}