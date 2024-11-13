using eShop.CoreBusiness.Models;
using eShop.UseCases.AdminPortal.OrderDetailsScreen.Interfaces;
using eShop.DataStore.SQL.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.AdminPortal.OrderDetailsScreen
{
    public class ViewOrderDetailUseCase : IViewOrderDetailUseCase
    {
        public ViewOrderDetailUseCase(IOrderRepository orderRepository)
        {
            OrderRepository = orderRepository;
        }

        public IOrderRepository OrderRepository { get; }

        public Order Execute(int orderId)
        {
            return OrderRepository.GetOrder(orderId);
        }
    }
}
