using eShop.CoreBusiness.Models;

namespace eShop.UseCases.CustomerPortal.SearchProductScreen
{
    public interface ISearchProductUseCase
    {
        IEnumerable<Product> Execute(string filter = null);
    }
}
