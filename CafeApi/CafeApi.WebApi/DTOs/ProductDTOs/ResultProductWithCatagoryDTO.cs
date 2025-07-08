using CafeApi.WebApi.Entities;

namespace CafeApi.WebApi.DTOs.ProductDTOs
{
    public class ResultProductWithCatagoryDTO
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public int CatagoryId { get; set; }
        public string CatagoryName { get; set; }
    }
}
