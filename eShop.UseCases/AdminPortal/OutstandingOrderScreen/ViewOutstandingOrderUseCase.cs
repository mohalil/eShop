using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.AdminPortal.OutstandingOrderScreen
{
    public class ViewOutstandingOrderUseCase : IViewOutstandingOrderUseCase
    {
        public ViewOutstandingOrderUseCase(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        public IOrderRepository OrderRepository { get; }

        public IEnumerable<Order> Execute()
        {
            return OrderRepository.GetOutstandingOrders();
        }
    }
}
