namespace lab08_ricardoquispea.Services.Interfaces;

public interface IOrderDetailService
{
    Task<IEnumerable<object>> GetDetailsByOrderAsync(int orderId);
    Task<int> GetTotalQuantityByOrderAsync(int orderId);  //  
}