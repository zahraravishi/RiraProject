using RiraProjeckt.Models;

namespace RiraProjeckt.Service
{
    public interface IProductService
    {
        List<Product> GetCategoryOneProducts();
        Product GetProductWithHighestPrice();
        decimal GetSumOfProducPrice();
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByCategory(CategorEnum category);
        decimal GetAveragePrice();
        IEnumerable<IGrouping<CategorEnum, Product>> GetProductsGroupByCategory();
    }
  
}


