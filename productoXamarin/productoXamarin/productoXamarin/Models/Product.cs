using System;
using System.Collections.Generic;
using System.Text;

namespace productoXamarin.Models
{
    public partial class Product
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public decimal? ProductPrice { get; set; }

        public int? ProductStock { get; set; }

        public byte? ProductStatus { get; set; }
    }
}
