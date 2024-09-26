using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artisan.Domain.Entities
{
    public class Artisans
    {
        [Key]
        public int ArtisanId { get; set; }

        // Basic Information
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        // Additional Information
        public string PhoneNumber { get; set; }
        public string Bio { get; set; }
        public string ProfilePictureUrl { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        // Address Information
        public string Address { get; set; }
        public string City { get; set; }

        // Professional Information
        public string Craft { get; set; } // e.g., Pottery, Woodworking
        public string ExperienceLevel { get; set; } // e.g., Beginner, Intermediate, Expert
        public decimal Rating { get; set; } // Average rating from customers
        public int NumberOfReviews { get; set; } // Number of reviews received

        // Social Media Links
        public string WebsiteUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string LinkedInUrl { get; set; }

        // Availability
        public bool IsAvailable { get; set; } // Availability status
        public DateTime DateJoined { get; set; } // Date when the artisan joined the platform
    }
}
