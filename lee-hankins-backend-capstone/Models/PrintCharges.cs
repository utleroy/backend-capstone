using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lee_hankins_backend_capstone.Models
{
    public class PrintCharges
    {
        public int PrintChargesId { get; set; }
        public int Quantities { get; set; }
        public int ColorsToPrint { get; set; }
        public decimal PricePer { get; set; }
        public decimal SetUp { get; set; }
        

    }
}