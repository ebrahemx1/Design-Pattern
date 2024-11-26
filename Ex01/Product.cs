namespace Design.Ex01
{
    public class Product
    {
        public int Id { get; set; }
        
        public decimal BasePrice { get; set; }


        public decimal CalculateProductPrice(IPricingStrategy strategy)
        {
            return strategy.CalculatePrice(BasePrice);
        }

    }
}