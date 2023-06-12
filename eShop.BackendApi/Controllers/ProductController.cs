using eShop.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;

namespace eShop.BackendApi.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly IPublicProductService _publicProductService;
        public ProductController(IPublicProductService publicProductService) 
        {
            _publicProductService = publicProductService;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _publicProductService.GetAll();
            return Ok(products);
        }
    }
}
