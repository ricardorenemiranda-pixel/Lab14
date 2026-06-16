using lab08_ricardoquispea.Models;
using lab08_ricardoquispea.Services.Interfaces;
using lab08_ricardoquispea.UnitOfWork;

namespace lab08_ricardoquispea.Services;

public class OrderService : IOrderService
{
    private readonly IUnitOfWork _uow;

    public OrderService(IUnitOfWork uow) => _uow = uow;

    // Ejercicio 6
    public Task<IEnumerable<Order>> GetOrdersAfterDateAsync(DateTime date) =>
        _uow.Orders.GetOrdersAfterDateAsync(date);

    // Ejercicio 10
    public Task<IEnumerable<object>> GetAllOrdersWithDetailsAsync() =>
        _uow.Orders.GetAllOrdersWithDetailsAsync();
}