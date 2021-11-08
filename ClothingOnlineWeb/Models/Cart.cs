using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingOnlineWeb.Models
{
    public class Cart
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string productImage { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
    }
}
