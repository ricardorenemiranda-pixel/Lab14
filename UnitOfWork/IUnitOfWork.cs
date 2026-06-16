using lab08_ricardoquispea.Repositories.Interfaces;

namespace lab08_ricardoquispea.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IClientRepository Clients { get; }
    IProductRepository Products { get; }
    IOrderDetailRepository OrderDetails { get; }
    IOrderRepository Orders { get; } 
    Task<int> SaveAsync();
}