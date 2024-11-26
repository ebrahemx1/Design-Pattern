namespace Design.Ex01.Strategys
{
    public class StandardPricing :IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice;
        }
    }
}