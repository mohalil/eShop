using eShop.CoreBusiness.Models;

namespace eShop.DataStore.SQL.Dapper
{
    public interface IProductRepository
    {
        Product GetProduct(int id);
        IEnumerable<Product> GetProducts(string filter);
    }
}