using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan.Domain.Entities
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public int ArtisanId { get; set; } // Foreign key to Artisans
        public int CustomerId { get; set; } // Foreign key to Customers
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } 

            // Navigation properties
    public Artisans Artisan { get; set; }
    public Customer Customer { get; set; }
    public List<OrderItems> OrderItems { get; set; }
    }
}
