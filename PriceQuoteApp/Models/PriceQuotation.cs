// Ignore Spelling: App

namespace PriceQuoteApp.Models
{
    public class PriceQuotation
    {
        public decimal Subtotal { get; set; }

        public decimal DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal Total { get; set; }

        public PriceQuotation()
        {
            Subtotal = 0;
            DiscountPercent = 0;
            DiscountAmount = 0;
            Total = 0;
        }
    }
}
