using CletusReyes.Models.DTO.Provider;

namespace CletusReyes.Models.DTO.Purchase_Order
{
    public class PurchaseOrderResponseDto
    {
        public Guid Id { get; set; }
        public float Total { get; set; }

        public ProviderResponseDto Provider { get; set; }
        public PurchaseOrderStatusResponseDto PurchaseOrderStatus { get; set; }
        public List<PurchaseOrderDetailResponseDto> Details { get; set; }
    }
}
