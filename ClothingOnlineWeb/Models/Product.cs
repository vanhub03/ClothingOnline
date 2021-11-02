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
            Productorders = new HashSet<Productorder>();
        }

        public int Productid { get; set; }
        public string Productname { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public int Unitinstock { get; set; }
        public bool Enable { get; set; }
        public int Categoryid { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<Productorder> Productorders { get; set; }
    }
}
