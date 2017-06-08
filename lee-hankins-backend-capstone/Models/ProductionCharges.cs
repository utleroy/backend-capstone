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
        public string OneColor { get; set; }
        public string TwoColor { get; set; }
        public string ThreeColor { get; set; }
        public string FourColor { get; set; }
        public string FiveColor { get; set; }
        public string SixColor { get; set; }
        public decimal SetUpCharges { get; set; }
        

    }
}