using System;
using System.Collections.Generic;

#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class OrderDetail
    {
        public int OrderId { get; set; }
        public int Productid { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int Id { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
