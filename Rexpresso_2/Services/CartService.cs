using System.Collections.Generic;
using Rexpresso_2.Models;

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
