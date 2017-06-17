using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lee_hankins_backend_capstone.Models
{
    public class ProductionCharges
    {
        public int ProductionChargesId { get; set; }
        public int Quantity { get; set; }
        public int ColorNumber { get; set; }
        public decimal NumberPrice { get; set; }
        public decimal SetUpCharges { get; set; }
        

    }
}