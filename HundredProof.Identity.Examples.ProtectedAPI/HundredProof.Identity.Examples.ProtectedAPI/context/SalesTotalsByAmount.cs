﻿using System;
using System.Collections.Generic;

namespace HundredProof.Identity.Examples.ProtectedAPI.context
{
    public partial class SalesTotalsByAmount
    {
        public decimal? SaleAmount { get; set; }
        public int OrderId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? ShippedDate { get; set; }
    }
}
