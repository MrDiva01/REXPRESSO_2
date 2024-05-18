
namespace Rexpresso_2.Models
{
    public class CartDetail
    {
        public int Id { get; set; }
        public int ShoppingCart_Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public Product ShoppingCart { get; set; }
        
        public ShoppingCart shoppingCart { get; set; }
    }
}
