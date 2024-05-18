using Microsoft.Build.Framework;

namespace Rexpresso_2.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public Order Order { get; set; }

        public Product Products { get; set; }
    }
}
