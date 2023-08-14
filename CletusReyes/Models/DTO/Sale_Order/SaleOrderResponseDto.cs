using CletusReyes.Models.DTO.User;

namespace CletusReyes.Models.DTO.Sale_Order
{
    public class SaleOrderResponseDto
    {
        public Guid Id { get; set; }
        public float Total { get; set; }


        public UserResponseDto User { get; set; }
        public SaleOrderStatusResponseDto SaleOrderStatus { get; set; }
        public List<SaleOrderDetailResponseDto> Details { get; set; }
    }
}
