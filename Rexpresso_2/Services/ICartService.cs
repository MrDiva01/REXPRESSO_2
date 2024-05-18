using System.Collections.Generic;
using Rexpresso_2.Models;

namespace Rexpresso_2.Services
{
    public interface ICartService
    {
        void AddToCart(Product product);
        List<Product> GetCartItems();
    }
}
