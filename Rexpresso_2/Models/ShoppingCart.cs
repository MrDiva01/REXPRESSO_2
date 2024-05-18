using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Rexpresso_2.Models
{
    public class ShoppingCart
    {
        
        public int Id { get; set; }
       
        public string UserId { get; set; }
        public bool IsDeleted { get; set; } = false;




    }
}
