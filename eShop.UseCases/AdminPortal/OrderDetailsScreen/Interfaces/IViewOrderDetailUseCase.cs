using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;

namespace eShop.UseCases.AdminPortal.OrderDetailsScreen.Interfaces
{
    public interface IViewOrderDetailUseCase
    {
        IOrderRepository OrderRepository { get; }

        Order Execute(int orderId);
    }
}