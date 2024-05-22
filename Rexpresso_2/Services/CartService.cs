using Rexpresso_2.Models;
using System.Collections.Generic;

namespace Rexpresso_2.Services
{
    public class CartService : ICartService
    {
        private readonly List<Product> cartItems = new List<Product>();

        public void AddToCart(Product product)
        {
            cartItems.Add(product);
        }

        public List<Product> GetCartItems()
        {
            return cartItems;
        }
    }
}
