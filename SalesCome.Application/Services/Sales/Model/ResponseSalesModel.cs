using System;

namespace SalesCome.Application.Services.Sales.Model
{
    /// <summary>
    /// Class sales history
    /// </summary>
    public class ResponseSalesModel
    {
        /// <summary>
        /// Clien Name
        /// </summary>
        public string ClientName { get; set; }
        /// <summary>
        /// Document Number Client
        /// </summary>
        public string DocumentNumber { get; set; }
        /// <summary>
        /// Product Name
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Quantity products
        /// </summary>
        public int Quantity { get; set; }
        /// <summary>
        /// Provider Name
        /// </summary>
        public string ProviderName { get; set; }
        /// <summary>
        /// Unit Price
        /// </summary>
        public decimal UnitPrice { get; set; }
        /// <summary>
        /// Date sale
        /// </summary>
        public DateTime SaleDate { get; set; }
    }
}
