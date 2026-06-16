using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Services.Interfaces;
using lab08_ricardoquispea.UnitOfWork;

namespace lab08_ricardoquispea.Services;

public class ProductService : IProductService
{
    private readonly IUnitOfWork _uow;

    public ProductService(IUnitOfWork uow) => _uow = uow;

    // Ejercicio 2
    public Task<IEnumerable<Product>> GetByPriceGreaterThanAsync(decimal price) =>
        _uow.Products.GetByPriceGreaterThanAsync(price);

    // Ejercicio 5
    public Task<Product?> GetMostExpensiveAsync() =>
        _uow.Products.GetMostExpensiveAsync();

    // Ejercicio 7
    public Task<decimal> GetAveragePriceAsync() =>
        _uow.Products.GetAveragePriceAsync();

    // Ejercicio 8
    public Task<IEnumerable<Product>> GetWithoutDescriptionAsync() =>
        _uow.Products.GetWithoutDescriptionAsync();

    // Ejercicio 11
    public Task<IEnumerable<object>> GetProductsByClientAsync(int clientId) =>
        _uow.Products.GetProductsByClientAsync(clientId);
}