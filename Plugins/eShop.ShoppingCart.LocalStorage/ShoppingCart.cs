using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;
using eShop.UseCases.PluginInterfaces.UI;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
//using eShop.UseCases.PluginInterfaces.UI;

namespace eShop.ShoppingCart.LocalStorage
{
    public class ShoppingCart : IShoppingCart
    {
        private const string cstrShoppingCart = "eShop.ShoppingCart";
        public ShoppingCart(IJSRuntime jSRuntime, IProductRepository productRepository)
        {
            JSRuntime = jSRuntime;
            ProductRepository = productRepository;
        }

        public IJSRuntime JSRuntime { get; }
        public IProductRepository ProductRepository { get; }

        public async Task<Order> AddProductAsync(Product product)
        {
            var order = await GetOrder();
            order.AddProduct(product.ProductId,1 , product.Price);
            await SetOrder(order);

            return order;
            
        }

        public async Task<Order> DeleteProductAsync(int productId)
        {
            var order = await GetOrder();
            order.RemoveProduct(productId);
            await SetOrder(order);

            return order;
        }

        public Task EmptyAsync()
        {
            return this.SetOrder(null);
        }

        public async Task<Order> GetOrderAsync()
        {
            return await GetOrder();

        }

        public Task<Order> PlaceOrderAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Order> UpdateOrderAsync(Order order)
        {
            await this.SetOrder(order);
            return order;
        }

        public async Task<Order> UpdateQuantityAsync(int productId, int quanity)
        {
            var order = await GetOrder();
            if (quanity < 0)
                return order;
            else if (quanity == 0)
                return await DeleteProductAsync(productId);
            
            var lineItem = order.LineItems.SingleOrDefault(x => x.ProductId == productId);
            if(lineItem != null) lineItem.Quantity = quanity;
            await SetOrder(order);
            return order;
        }

        private async Task<Order> GetOrder()
        {
            Order order = null;

            var strorder = await JSRuntime.InvokeAsync<string>("localStorage.getItem", cstrShoppingCart);

            if (!string.IsNullOrWhiteSpace(strorder) && strorder.ToLower() != "null")
                order = JsonConvert.DeserializeObject<Order>(strorder);
            else
            {
                order = new Order();
                await SetOrder(order);
            }
            foreach (var item in order.LineItems)
            {
                item.Product = ProductRepository.GetProduct(item.ProductId);

            }

            return order;
        }

        private async Task SetOrder(Order order)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", cstrShoppingCart, JsonConvert.SerializeObject(order));
        }
    }
}
