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
        [StringLength(50, ErrorMessage = "Username length must be between 2 and 50", MinimumLength =2)]
        public string Username { get; set; }

        [Required]
        [RegularExpression(@"^ (?=.*[a - z])(?=.*[A - Z])(?=.*\d)[a - zA - Z\d]{8,}$/i", 
            ErrorMessage = "Minimum 8 characters, at least one uppercase letter, one lowercase letter and one number")]
        public string Password { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [RegularExpression(@"/^\d{10}$/i", ErrorMessage ="Phone must be 10 digits")]
        public string Phone { get; set; }

        [Required]
        [RegularExpression(@"/ ^\w + ([\.-] ?\w +)*@\w+([\.-]?\w+)*(\.\w{2,4})+$/i", ErrorMessage ="Invalid Email Format")]
        public string Email { get; set; }

        public bool Isadmin { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
