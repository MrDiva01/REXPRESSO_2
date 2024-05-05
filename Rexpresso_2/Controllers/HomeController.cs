using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rexpresso_2.Models;
using Rexpresso_2.Services;
using System.Diagnostics;

namespace Rexpresso_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        // Constructor with dependencies injected via DI
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            // Retrieve products ordered by Id descending (example)
            var products = _context.Products.OrderByDescending(p => p.Id).ToList();

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

