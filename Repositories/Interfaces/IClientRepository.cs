using lab08_ricardoquispea.Models;

namespace lab08_ricardoquispea.Repositories.Interfaces;

public interface IClientRepository : IGenericRepository<Client>
{
    Task<IEnumerable<Client>> GetByNameAsync(string name);
    Task<object?> GetClientWithMostOrdersAsync();
    Task<IEnumerable<object>> GetClientsByProductAsync(int productId);  //  agrega
}