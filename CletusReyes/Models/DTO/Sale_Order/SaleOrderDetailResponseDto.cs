using CletusReyes.Models.DTO.Product;

namespace CletusReyes.Models.DTO.Sale_Order
{
    public class SaleOrderDetailResponseDto
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }

        public ProductResponseDto Product { get; set; }
    }
}
