// Ignore Spelling: App

using System.ComponentModel.DataAnnotations;

namespace PriceQuoteApp.Models
{
    public class PriceQuotation
    {
        [Required(ErrorMessage ="Subtotal is Required")]
        [Range(0.01, double.MaxValue, ErrorMessage ="Subtotal must be greater than 0.")]
        public decimal? Subtotal { get; set; }

        [Required(ErrorMessage ="Discount Percent is Required.")]
        [Range(0, 100, ErrorMessage =" Discount percent must be between 1 and 100.")]
        public decimal? DiscountPercent { get; set; }

        public decimal DiscountAmount { get; set; }

        public decimal Total { get; set; }

        public PriceQuotation()
        {
            Subtotal = null;
            DiscountPercent = null;
            DiscountAmount = 0;
            Total = 0;
        }

        public void Calculate()
        {
            DiscountAmount = Subtotal.Value * (DiscountPercent.Value / 100);
            Total = Subtotal.Value - DiscountAmount;
        }
    }
}
