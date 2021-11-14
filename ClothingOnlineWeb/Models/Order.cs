using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Orderid { get; set; }
        public int Accountid { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Username length must be between 2 and 50", MinimumLength = 2)]
        public string Customername { get; set; }

        [Required]
        [RegularExpression(@"/^\d{10}$/i", ErrorMessage = "Phone must be 10 digits")]
        public string Phone { get; set; }

        [Required]
        public string Address { get; set; }
        public string Totalprice { get; set; }
        public int Status { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
