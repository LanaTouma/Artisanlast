using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan.Domain.Entities
{
    public class OrderItems
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; } // Foreign key to Orders


        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; } // Calculated as Quantity * UnitPrice

            // Navigation properties
    public Orders Order { get; set; }
    public Products Product { get; set; }

    }
}
