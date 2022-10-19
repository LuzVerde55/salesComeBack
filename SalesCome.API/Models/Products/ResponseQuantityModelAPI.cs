﻿namespace SalesCome.API.Models.Products
{
    public class ResponseQuantityModelAPI
    {
        public long ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProducDescription { get; set; }
        public bool Active { get; set; }
        public string CategoryProduct { get; set; }
        public string TradeMark { get; set; }
        public int Quantity { get; set; }
        public decimal UnitValue { get; set; }
    }
}
