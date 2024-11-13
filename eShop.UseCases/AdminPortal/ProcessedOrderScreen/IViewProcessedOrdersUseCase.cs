using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;

namespace eShop.UseCases.AdminPortal.ProcessedOrderScreen
{
    public interface IViewProcessedOrdersUseCase
    {
        IOrderRepository OrderRepository { get; }

        IEnumerable<Order> Execute();
    }
}