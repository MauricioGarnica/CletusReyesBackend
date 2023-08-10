using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Sale_Order
{
    public class AddSaleOrderHeaderRequestDomainModel
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public float Total { get; set; }

        [Required]
        public List<AddSaleOrderDetailRequestDomainModel> Details { get; set; }
    }
}
