﻿namespace CafeApi.WebApi.Entities
{
    public class Catagory
    {
        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
        public List<Product> Products { get; set; }
    }
}
