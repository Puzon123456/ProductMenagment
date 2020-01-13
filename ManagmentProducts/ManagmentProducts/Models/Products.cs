using System;
using System.Collections.Generic;

namespace ManagmentProducts.Models
{
    public partial class Products
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
    }
}
