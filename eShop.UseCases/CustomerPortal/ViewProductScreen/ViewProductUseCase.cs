using eShop.CoreBusiness.Models;
using eShop.DataStore.SQL.Dapper;

namespace eShop.UseCases.CustomerPortal.ViewProductScreen
{
    public class ViewProductUseCase : IViewProductUseCase
    {
        public readonly IProductRepository productRepository;
        public ViewProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }



        public Product Execute(int id)
        {
            return productRepository.GetProduct(id);
        }
    }
}
