using System.Collections.Generic;

namespace SalesCome.Infrastructure.Services.Products.Models
{
    public class ProductResponseModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProducDescription { get; set; }
        public bool Active { get; set; }
        public string CategoryProduct { get; set; }
        public string TradeMark { get; set; }
        public List<QuantityResponseModel> QuantitieCollection { get; set; }
    }
}
