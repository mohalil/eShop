using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;

namespace eShop.UseCases.CustomerPortal.OrderConfirmationScreen
{
    public interface IViewOrderConfirmationUseCase
    {
        IOrderRepository OrderRepository { get; }

        Order Execute(string UniqueId);
    }
}