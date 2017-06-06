using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lee_hankins_backend_capstone.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string styleName { get; set; }
        public string colorName { get; set; }
        public string colorSwatchImage { get; set; }
        public string colorSwatchTextColor { get; set; }
        public string colorFrontImage { get; set; }
        public string colorBackImage { get; set; }
        public string sizeName { get; set; }
        public int unitWeight { get; set; }
        public int salePrice { get; set; }
        public int customerPrice { get; set; }
        public int qty { get; set; }
    }
}