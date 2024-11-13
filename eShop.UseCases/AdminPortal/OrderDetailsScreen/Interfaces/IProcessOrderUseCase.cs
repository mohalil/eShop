using eShop.CoreBusiness.Services.Interfaces;
using eShop.DataStore.SQL.Dapper;

namespace eShop.UseCases.AdminPortal.OrderDetailsScreen.Interfaces
{
    public interface IProcessOrderUseCase
    {
        IOrderRepository OrderRepository { get; }
        IOrderService OrderService { get; }

        bool Execute(int orderId, string adminUserName);
    }
}