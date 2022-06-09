using System;
using System.Collections.Generic;

namespace Shopee.DataAccess.Models
{
    public partial class Product
    {
        public int Productid { get; set; }
        public string Productname { get; set; } = null!;
        public string Productdescription { get; set; } = null!;
        public string Productprice { get; set; } = null!;
    }
}
