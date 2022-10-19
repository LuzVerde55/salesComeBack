namespace SalesCome.Application.Services.Products.Model
{
    public class RequestQuantityModel
    {
        public long QuantityId { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
    }
}
