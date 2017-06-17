using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lee_hankins_backend_capstone.Models
{
    public class LineItem
    {
        public int LineItemId { get; set; }
        public int OrderId { get; set; }
        public string product { get; set; }
        public double imprintPrice { get; set; }
        public double shirtPrice { get; set; }
        public double imprintTotal { get; set; }
        public double lineTotal { get; set; }
        public int quantity { get; set; }



    }
}