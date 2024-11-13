﻿using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Services;
using eShop.CoreBusiness.Services.Interfaces;
using eShop.UseCases.CustomerPortal.ShoppingCartScreen.Interfaces;
using eShop.DataStore.SQL.Dapper;
using eShop.UseCases.PluginInterfaces.StateStore;
using eShop.UseCases.PluginInterfaces.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen
{

    public class PlaceOrderUseCase : IPlaceOrderUseCase
    {
        private readonly IOrderService orderService;
        private readonly IOrderRepository orderRepository;
        private readonly IShoppingCart shoppingCart;
        private readonly IShoppingCartStateStore shoppingCartStateStore;

        public PlaceOrderUseCase(IOrderService orderService, IOrderRepository orderRepository, IShoppingCart shoppingCart, IShoppingCartStateStore shoppingCartStateStore)
        {
            this.orderService = orderService;
            this.orderRepository = orderRepository;
            this.shoppingCart = shoppingCart;
            this.shoppingCartStateStore = shoppingCartStateStore;
        }

        public async Task<string> Execute(Order order)
        {
            if (orderService.ValidateCreateOrder(order))
            {
                order.DatePlaced = DateTime.Now;
                order.UniqueId = Guid.NewGuid().ToString();
                orderRepository.CreateOrder(order);

                await shoppingCart.EmptyAsync();
                shoppingCartStateStore.UpdateLineItemsCount();
                return order.UniqueId;
            }
            return null;
        }
    }
}
