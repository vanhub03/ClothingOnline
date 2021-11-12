using System;
using System.Collections.Generic;

#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class Product
    {
        public Product()
        {
            Images = new HashSet<Image>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Productid { get; set; }
        public string Productname { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int Unitinstock { get; set; }
        public bool Enable { get; set; }
        public int Categoryid { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
