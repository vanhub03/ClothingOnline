using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        public string Productname { get; set; }

        [Required]
        [RegularExpression(@"^([1-9]+[0]{3})$/i",
            ErrorMessage = "Price format: xxx000")]
        public double Price { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Description length can't be more than 500 characters")]
        public string Description { get; set; }

        [Required]  
        [Range(0, 100)]
        public int Unitinstock { get; set; }
        public bool Enable { get; set; }
        public int Categoryid { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
