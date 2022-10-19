namespace SalesCome.API.Models.Products
{
    public class RequestQuantityModelAPI
    {
        public long QuantityId { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
    }
}
