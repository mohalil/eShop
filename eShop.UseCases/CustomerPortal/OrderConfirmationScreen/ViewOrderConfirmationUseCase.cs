using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.OrderConfirmationScreen
{
    public class ViewOrderConfirmationUseCase : IViewOrderConfirmationUseCase
    {
        public ViewOrderConfirmationUseCase(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        public IOrderRepository OrderRepository { get; }

        public Order Execute(string UniqueId)
        {
            return OrderRepository.GetOrderByUniqueId(UniqueId);
        }
    }
}
