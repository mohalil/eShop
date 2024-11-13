﻿using eShop.CoreBusiness.Models;

namespace eShop.UseCases.PluginInterfaces.DataStore
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts(string filter);

        Product GetProduct(int Id);

    }
}
