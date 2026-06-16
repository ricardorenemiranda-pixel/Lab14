using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Repositories;
using lab08_ricardoquispea.Repositories.Interfaces;

namespace lab08_ricardoquispea.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly LinqexampleContext _context;

    public IClientRepository Clients { get; }
    public IProductRepository Products { get; }
    public IOrderDetailRepository OrderDetails { get; }
    public IOrderRepository Orders { get; }  

    public UnitOfWork(LinqexampleContext context)
    {
        _context = context;
        Clients = new ClientRepository(context);
        Products = new ProductRepository(context);
        OrderDetails = new OrderDetailRepository(context);
        Orders = new OrderRepository(context); 
    }

    public async Task<int> SaveAsync() => await _context.SaveChangesAsync();
    public void Dispose() => _context.Dispose();
}