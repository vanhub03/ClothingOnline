using System;
using System.Collections.Generic;

#nullable disable

namespace ClothingOnlineWeb.Models
{
    public partial class Order
    {
        public int Orderid { get; set; }
        public int Accountid { get; set; }
        public int Productorderid { get; set; }
        public string Customername { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Totalprice { get; set; }

        public virtual Account Account { get; set; }
        public virtual Productorder Productorder { get; set; }
    }
}
