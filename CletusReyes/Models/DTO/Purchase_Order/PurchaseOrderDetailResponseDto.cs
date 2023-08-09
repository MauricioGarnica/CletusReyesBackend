using CletusReyes.Models.DTO.Raw_Material;

namespace CletusReyes.Models.DTO.Purchase_Order
{
    public class PurchaseOrderDetailResponseDto
    {
        public Guid Id { get; set; }
        public float Price { get; set; }
        public float Quantity { get; set; }

        public RawMaterialResponseDto RawMaterial { get; set; }
    }
}
