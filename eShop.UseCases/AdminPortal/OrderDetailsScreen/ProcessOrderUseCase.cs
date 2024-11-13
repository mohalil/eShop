using eShop.CoreBusiness.Services.Interfaces;
using eShop.UseCases.AdminPortal.OrderDetailsScreen.Interfaces;
using eShop.DataStore.SQL.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.AdminPortal.OrderDetailsScreen
{
    public class ProcessOrderUseCase : IProcessOrderUseCase
    {
        public ProcessOrderUseCase(IOrderRepository orderRepository, IOrderService orderService)
        {
            OrderRepository = orderRepository;
            OrderService = orderService;
        }

        public IOrderRepository OrderRepository { get; }
        public IOrderService OrderService { get; }

        public bool Execute(int orderId, string adminUserName)
        {
            var order = OrderRepository.GetOrder(orderId);
            order.AdminUser = adminUserName;
            order.DateProcessed = DateTime.Now;

            if (OrderService.ValidateProcessOrder(order))
            {
                OrderRepository.UpdateOrder(order);
                return true;

            }
            return false;

        }
    }
}
