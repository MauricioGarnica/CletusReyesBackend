using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Recipe
{
    public class AddRecipeHeaderRequestDomainModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Guid ProductId { get; set; }

        public string? Description { get; set; }

        public string? UserIdCreated { get; set; }

        [Required]
        public List<AddRecipeDetailRequestDomainModel> Details { get; set; }
    }
}
