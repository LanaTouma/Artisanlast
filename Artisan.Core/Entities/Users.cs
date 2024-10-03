using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Artisan.Domain.Entities
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternativePhoneNumber { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime RegistrationDate { get; set; }

        public UserStatus Status { get; set; }
        public string Image { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

      //  public virtual ICollection<Log> Logs { get; set; }
       //public virtual ICollection<Action> Actions { get; set; }
        //public virtual ICollection<Wishlist> Wishlists { get; set; }
        //public virtual ICollection<Address> Addresses { get; set; }
        //public virtual ICollection<Review> Reviews { get; set; }

    }


}

public enum UserType
{
    Admin = 0,
    Artisan = 1,
    Customer = 2,
    EndUser = 3
}

public enum UserStatus
{
    Active,
    Inactive,
    Suspended,
    Deleted
}