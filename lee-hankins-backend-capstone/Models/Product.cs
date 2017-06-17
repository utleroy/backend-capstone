using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lee_hankins_backend_capstone.Models
{
    public class Product
    {
        public int styleId { get; set; }
        public string brandName { get; set; }
        public string styleName { get; set; }
        public string colorName { get; set; }
        //public string colorSwatchImage { get; set; }
        //public string colorSwatchTextColor { get; set; }
        //public string colorFrontImage { get; set; }
        //public string colorBackImage { get; set; }
        public string sizeName { get; set; }
        public decimal salePrice { get; set; }
        //public int customerPrice { get; set; }
        //public int qty { get; set; }
    }
}