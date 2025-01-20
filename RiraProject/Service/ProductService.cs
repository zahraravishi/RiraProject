using RiraProjeckt.Models;

namespace RiraProjeckt.Service
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
        {
            new Product { Id = 1, Name = "Product A", Categories = CategorEnum.Category1, Price = 100 },
            new Product { Id = 2, Name = "Product B", Categories = CategorEnum.Category1, Price = 150 },
            new Product { Id = 3, Name = "Product C", Categories = CategorEnum.Category2, Price = 120 },
            new Product { Id = 4, Name = "Product D", Categories = CategorEnum.Category3, Price = 200 },
            new Product { Id = 5, Name = "Product E", Categories = CategorEnum.Category1, Price = 80 }
        };
        }


        public List<Product> GetCategoryOneProducts() =>
       _products.Where(p => p.Categories == CategorEnum.Category1).ToList(); // گرفتن محصولات با دسته بندی کتگوری 1
        public Product GetProductWithHighestPrice() =>
            _products.OrderByDescending(p => p.Price).FirstOrDefault(); // مرتب سازی صعودی بر اساس قیمت و گرفتن اولین اِلِمان

        public decimal GetSumOfProducPrice() =>
              _products.Sum(p => p.Price); // گرفتن جمع قیمت محصولات

        public decimal GetAveragePrice() =>
           _products.Average(p => p.Price); // گرفتن میانگین قیمت محصولات

        public IEnumerable<IGrouping<CategorEnum, Product>> GetProductsGroupByCategory() =>
            _products.GroupBy(p => p.Categories); // گروه کردن محصولات بر اساس دسته بندی

        public IEnumerable<Product> GetAllProducts() => _products; // متد پایه برای گرفتن تمامی محصولات

        public IEnumerable<Product> GetProductsByCategory(CategorEnum category) =>
            _products.Where(p => p.Categories == category); // گرفتن محوصلات بر اساس دسته بندی


    }
}


