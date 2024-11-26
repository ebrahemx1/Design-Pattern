using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design.Ex01.Strategys
{
    public class SeasonalPricing : IPricingStrategy
    {
        public decimal SeasonalPricingAmount { get; set; }
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice - SeasonalPricingAmount;
        }
    }
}