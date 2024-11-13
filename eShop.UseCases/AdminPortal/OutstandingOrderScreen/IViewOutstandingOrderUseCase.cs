using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;

namespace eShop.UseCases.AdminPortal.OutstandingOrderScreen
{
    public interface IViewOutstandingOrderUseCase
    {
        IOrderRepository OrderRepository { get; }

        IEnumerable<Order> Execute();
    }
}