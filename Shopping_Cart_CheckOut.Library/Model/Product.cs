namespace Shopping_Cart_CheckOut.Library.Model
{
    public class Product
    {
        public string ProductCode { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BulkPrice { get; set; }
        // Initial Value as Default
        public int Quantity { get; set; } = 1;
        public int DiscoutEligibleQuantity { get; set; }
    }
}
