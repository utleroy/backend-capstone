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
        public string ProductSelected { get; set; }
        

    }
}