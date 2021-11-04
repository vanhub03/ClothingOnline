using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class Account
    {
        public Account()
        {
            Orders = new HashSet<Order>();
        }

        public int Userid { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Username not empty")]
        
        //[RegularExpression()]
        public string Username { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password not empty")]
        
        public string Password { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Address not empty")]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Phone not empty")]
        public string Phone { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email not empty")]
        public string Email { get; set; }
        public bool Isadmin { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
