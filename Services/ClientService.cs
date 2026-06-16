using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Services.Interfaces;
using lab08_ricardoquispea.UnitOfWork;

namespace lab08_ricardoquispea.Services;

public class ClientService : IClientService
{
    private readonly IUnitOfWork _uow;

    public ClientService(IUnitOfWork uow) => _uow = uow;

    // Ejercicio 1
    public Task<IEnumerable<Client>> GetByNameAsync(string name) =>
        _uow.Clients.GetByNameAsync(name);

    // Ejercicio 9
    public Task<object?> GetClientWithMostOrdersAsync() =>
        _uow.Clients.GetClientWithMostOrdersAsync();

    // Ejercicio 12
    public Task<IEnumerable<object>> GetClientsByProductAsync(int productId) =>
        _uow.Clients.GetClientsByProductAsync(productId);
}