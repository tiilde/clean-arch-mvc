using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArchMvc.WebUI.Controllers {
    public class ProductsController : Controller {

        private readonly IProductService _productService;
        public ProductsController(IProductService productService) { 
            
            _productService = productService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Index() {

            // retorna uma lista/IEnumerable de objetos do tipo produtosDTO
            var products = await _productService.GetProducts(); 
            return View(products);
        }
    }
}
