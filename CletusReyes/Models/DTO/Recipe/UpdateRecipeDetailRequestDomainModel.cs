using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Recipe
{
    public class UpdateRecipeDetailRequestDomainModel
    {
        [Required]
        public Guid RawMaterialId { get; set; }

        [Required]
        public float Quantity { get; set; }
    }
}
