using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Purchase_Order
{
    public class AddPurchaseOrderDetailRequestDomainModel
    {
        [Required]
        public Guid RawMaterialId { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public float Quantity { get; set; }
    }
}
