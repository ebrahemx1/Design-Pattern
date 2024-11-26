using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.Ex01.Strategys
{
    public class DisscountPricing :IPricingStrategy
    {

        public int DisscountAmount { get; set; }
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice - DisscountAmount;
        }
    }
}