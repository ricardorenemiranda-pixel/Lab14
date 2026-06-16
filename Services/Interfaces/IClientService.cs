using lab08_ricardoquispea.Models;

namespace lab08_ricardoquispea.Services.Interfaces;

public interface IClientService
{
    Task<IEnumerable<Client>> GetByNameAsync(string name);
    Task<object?> GetClientWithMostOrdersAsync();
    Task<IEnumerable<object>> GetClientsByProductAsync(int productId);  //  
}