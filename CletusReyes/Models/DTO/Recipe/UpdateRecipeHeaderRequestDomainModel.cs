using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Recipe
{
    public class UpdateRecipeHeaderRequestDomainModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        public string? Description { get; set; }

        public string? UserIdUpdated { get; set; }

        [Required]
        public List<UpdateRecipeDetailRequestDomainModel> Details { get; set; }
    }
}
