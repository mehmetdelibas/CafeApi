﻿namespace CafeApi.WebApi.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
