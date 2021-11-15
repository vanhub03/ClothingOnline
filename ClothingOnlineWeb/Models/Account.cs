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

        [Required]
        [StringLength(50, ErrorMessage = "Username length must be between 2 and 50", MinimumLength = 2)]
        public string Username { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$",
            ErrorMessage = "Minimum 8 characters, at least one uppercase letter, one lowercase letter and one number")]
        public string Password { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Phone must be 10 digits")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$", 
            ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
        public bool Isadmin { get; set; }
        public bool Enable { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
