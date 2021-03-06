﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lee_hankins_backend_capstone.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<LineItem> LineItems {get;set;}
    }
}