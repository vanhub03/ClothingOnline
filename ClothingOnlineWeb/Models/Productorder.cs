using System;
using System.Collections.Generic;

#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class Productorder
    {
        public Productorder()
        {
            Orders = new HashSet<Order>();
        }

        public int Productorderid { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
