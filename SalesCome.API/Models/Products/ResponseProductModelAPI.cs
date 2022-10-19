using System.Collections.Generic;

namespace SalesCome.API.Models.Products
{
    public class ResponseProductModelAPI
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProducDescription { get; set; }
        public bool Active { get; set; }
        public string CategoryProduct { get; set; }
        public string TradeMark { get; set; }
        public List<ResponseQuantityModelAPI> QuantitieCollection { get; set; }
    }
}
