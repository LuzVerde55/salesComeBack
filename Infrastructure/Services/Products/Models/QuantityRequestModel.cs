namespace SalesCome.Infrastructure.Services.Products.Models
{
    public class QuantityRequestModel
    {
        public long QuantityId { get; set; }
        public long ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
    }
}
