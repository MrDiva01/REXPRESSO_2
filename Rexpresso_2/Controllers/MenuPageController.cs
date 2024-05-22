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
        public IActionResult AddToCart([FromBody] ProductRequest request)
        {
            if (request == null)
            {
                return BadRequest("Invalid request.");
            }

            var product = context.Products.FirstOrDefault(p => p.Id == request.ProductId);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            cartService.AddToCart(product);
            return Ok("Product added to cart successfully.");
        }

        public IActionResult Cart()
        {
            var cartItems = cartService.GetCartItems();
            return View(cartItems);
        }
    }

    public class ProductRequest
    {
        public int ProductId { get; set; }
    }
}
