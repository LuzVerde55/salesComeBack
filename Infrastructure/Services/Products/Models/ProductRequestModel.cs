﻿namespace SalesCome.Infrastructure.Services.Products.Models
{
    public class ProductRequestModel
    {
        public long ProductId { get; set; }
        public int ProductCategory { get; set; }
        public int TradeMark { get; set; }
        public string ProductName { get; set; }
        public string ProducDescription { get; set; }   
        public bool Active { get; set; }
        public int UserCreate { get; set; }
        public long ProviderId { get; set; }
    }
}
