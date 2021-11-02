using System;
using System.Collections.Generic;

#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class Image
    {
        public int Imageid { get; set; }
        public string Imagelink { get; set; }
        public int Productid { get; set; }

        public virtual Product Product { get; set; }
    }
}
