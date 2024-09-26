using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan.Domain.Entities
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public int ArtisanId { get; set; } // Foreign key to Artisans

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; } 
        public string Category { get; set; } 

        public string ProductImageUrl { get; set; }
        public DateTime DateAdded { get; set; }

        public bool IsAvailable { get; set; }


        // Navigation property
        public Artisans Artisan { get; set; }
    }
}
