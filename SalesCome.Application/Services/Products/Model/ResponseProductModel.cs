using System.Collections.Generic;

namespace SalesCome.Application.Services.Products.Model
{
    public class ResponseProductModel
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProducDescription { get; set; }
        public bool Active { get; set; }
        public string CategoryProduct { get; set; }
        public string TradeMark { get; set; }
        public List<ResponseQuantityModel> QuantitieCollection { get; set; }
    }
}
