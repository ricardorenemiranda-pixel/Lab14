using lab08_ricardoquispea.Services.Interfaces;
using lab08_ricardoquispea.UnitOfWork;

namespace lab08_ricardoquispea.Services;

public class OrderDetailService : IOrderDetailService
{
    private readonly IUnitOfWork _uow;

    public OrderDetailService(IUnitOfWork uow) => _uow = uow;

    //  3
    public Task<IEnumerable<object>> GetDetailsByOrderAsync(int orderId) =>
        _uow.OrderDetails.GetDetailsByOrderAsync(orderId);

    // 4
    public Task<int> GetTotalQuantityByOrderAsync(int orderId) =>
        _uow.OrderDetails.GetTotalQuantityByOrderAsync(orderId);
}