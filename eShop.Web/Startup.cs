using eShop.CoreBusiness.Models;
using eShop.CoreBusiness.Services;
using eShop.CoreBusiness.Services.Interfaces;
//using eShop.DataStore.Hardcoded;
using eShop.DataStore.SQL.Dapper;
using eShop.DataStore.SQL.Dapper.Helpers;
using eShop.StateStore.DI;
using eShop.UseCases.AdminPortal.OrderDetailsScreen;
using eShop.UseCases.AdminPortal.OrderDetailsScreen.Interfaces;
using eShop.UseCases.AdminPortal.OutstandingOrderScreen;
using eShop.UseCases.AdminPortal.ProcessedOrderScreen;
using eShop.UseCases.CustomerPortal.OrderConfirmationScreen;
using eShop.UseCases.CustomerPortal.SearchProductScreen;
using eShop.UseCases.CustomerPortal.ShoppingCartScreen;
using eShop.UseCases.CustomerPortal.ShoppingCartScreen.Interfaces;
using eShop.UseCases.CustomerPortal.ViewProductScreen;
using eShop.UseCases.PluginInterfaces.DataStore;
using eShop.UseCases.PluginInterfaces.StateStore;
using eShop.UseCases.PluginInterfaces.UI;
using eShop.Web.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddAuthentication("eShop.CookieAuth")
                .AddCookie("eShop.CookieAuth", config =>
                {
                    config.Cookie.Name = "eShop.CookieAuth";
                    config.LoginPath = "/authenticate";
                });
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<WeatherForecastService>();

            //services.AddSingleton<IProductRepository, ProductRepository>();
            //services.AddSingleton<IOrderRepository, OrderRepository>();

            services.AddScoped<IShoppingCart, eShop.ShoppingCart.LocalStorage.ShoppingCart>();
            services.AddScoped<IShoppingCartStateStore, ShoppingCartStateStore>();

            services.AddTransient<IDataAccess>(sp => new DataAccess(Configuration.GetConnectionString("Default")));
            services.AddTransient<DataStore.SQL.Dapper.IProductRepository, ProductRepository>();
            services.AddTransient<DataStore.SQL.Dapper.IOrderRepository, OrderRepository>();

            services.AddTransient<IViewProductUseCase, ViewProductUseCase>();
            services.AddTransient<ISearchProductUseCase, SearchProductUseCase>();
            services.AddTransient<IAddProductToCartUseCase, AddProductToCartUseCase>();
            services.AddTransient<IViewShoppingCartUseCase, ViewShoppingCartUseCase>();
            services.AddTransient<IDeleteProductUseCase, DeleteProductUseCase>();
            services.AddTransient<IUpdateQuantityUseCase, UpdateQuantityUseCase>();
            services.AddTransient<IPlaceOrderUseCase, PlaceOrderUseCase>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IViewOrderConfirmationUseCase, ViewOrderConfirmationUseCase>();

            services.AddTransient<IViewOutstandingOrderUseCase, ViewOutstandingOrderUseCase>();
            services.AddTransient<IViewProcessedOrdersUseCase, ViewProcessedOrdersUseCase>();
            services.AddTransient<IViewOrderDetailUseCase, ViewOrderDetailUseCase>();
            services.AddTransient<IProcessOrderUseCase, ProcessOrderUseCase>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
