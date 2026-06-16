using lab08_ricardoquispea.Models;

namespace lab08_ricardoquispea.Repositories.Interfaces;

public interface IProductRepository : IGenericRepository<Product>
{
    Task<IEnumerable<Product>> GetByPriceGreaterThanAsync(decimal price);
    Task<Product?> GetMostExpensiveAsync();
    Task<decimal> GetAveragePriceAsync();
    Task<IEnumerable<Product>> GetWithoutDescriptionAsync();
    Task<IEnumerable<object>> GetProductsByClientAsync(int clientId); 
}