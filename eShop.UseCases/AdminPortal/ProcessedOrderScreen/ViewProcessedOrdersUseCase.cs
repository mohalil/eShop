using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.AdminPortal.ProcessedOrderScreen
{
    public class ViewProcessedOrdersUseCase : IViewProcessedOrdersUseCase
    {
        public ViewProcessedOrdersUseCase(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        public IOrderRepository OrderRepository { get; }

        public IEnumerable<Order> Execute()
        {
            return OrderRepository.GetProcessedOrders();
        }
    }
}
