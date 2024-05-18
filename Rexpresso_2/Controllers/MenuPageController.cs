using Microsoft.AspNetCore.Mvc;
using Rexpresso_2.Models;
using Rexpresso_2.Services;
using System.Linq;

namespace Rexpresso_2.Controllers
{
    public class MenuPageController : Controller
    {
        private readonly ApplicationDbContext context;
        private readonly ICartService cartService;

        public MenuPageController(ApplicationDbContext context, ICartService cartService)
        {
            this.context = context;
            this.cartService = cartService;
        }

        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(p => p.Id).ToList();
            return View(products);
        }

        [HttpPost]
        public IActionResult AddToCart([FromBody] int productId)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == productId);
            if (product != null)
            {
                cartService.AddToCart(product);
            }

            return Ok();
        }

        public IActionResult Cart()
        {
            var cartItems = cartService.GetCartItems();
            return View(cartItems);
        }
    }
}
