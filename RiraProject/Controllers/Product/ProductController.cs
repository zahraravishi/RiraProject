using Microsoft.AspNetCore.Mvc;
using RiraProjeckt.Models;
using RiraProjeckt.Service;


namespace RiraProjeckt.Controllers.Product
{
    public class ProductController : Controller
    {

        //پیاده سازی کنترلر و تزریق سرویس پروداکت و استفاده از آن برای واکشی دیتا
        // با توجه به عدم نیاز ویو های مورد نیاز را پیاده سازی نکردم
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
;           _productService = productService;
        }

        public IActionResult GetAllProducts()
        {
           var model = _productService.GetAllProducts();
            return View(model);
        }

        public IActionResult GetAveragePrice()
        {
            var model = _productService.GetAveragePrice();
            return View(model);
        }

        public IActionResult GetCategoryOneProducts()
        {
            var model = _productService.GetCategoryOneProducts();
            return View(model);
        }

        public IActionResult GetProductsByCategory(CategorEnum category)
        {
            var model = _productService.GetProductsByCategory(category);
            return View(model);
        }

        public IActionResult GetProductsGroupByCategory()
        {
            var model = _productService.GetProductsGroupByCategory();
            return View(model);
        }

        public IActionResult GetProductWithHighestPrice()
        {
            var model = _productService.GetProductWithHighestPrice();
            return View(model);
        }

        public IActionResult GetSumOfProducPrice()
        {
            var model = _productService.GetSumOfProducPrice();
            return View(model);
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
