using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Purchase_Order
{
    public class AddPurchaseOrderHeaderRequestDomainModel
    {
        [Required]
        public Guid ProviderId { get; set; }

        [Required]
        public float Total { get; set; }

        public string? UserIdCreated { get; set; }

        [Required]
        public List<AddPurchaseOrderDetailRequestDomainModel> Details { get; set; }
    }
}
