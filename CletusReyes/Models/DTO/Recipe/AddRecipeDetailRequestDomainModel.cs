using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Recipe
{
    public class AddRecipeDetailRequestDomainModel
    {
        [Required]
        public Guid RawMaterialId { get; set; }

        [Required]
        public float Quantity { get; set; }
    }
}
