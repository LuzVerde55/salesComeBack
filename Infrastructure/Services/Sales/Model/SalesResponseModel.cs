using System;

namespace SalesCome.Infrastructure.Services.Sales.Model
{
    public class SalesResponseModel
    {
        public string ClientName { get; set; }
        public string DocumentNumber { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string ProviderName { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime SaleDate { get; set; }
    }
}
