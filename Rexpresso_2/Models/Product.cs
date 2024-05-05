using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Rexpresso_2.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        [MaxLength(100)]
        public string Category { get; set; } = "";
        [Precision(16, 2)]
        public decimal Price { get; set; }
        [MaxLength(100)]

        public int Quantity { get; set; }
        public string ImageFileName { get; set; } = "";

        public DateTimeOffset CreatedAt { get; set; }
    }
}
