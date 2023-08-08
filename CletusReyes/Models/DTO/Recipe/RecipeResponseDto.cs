using CletusReyes.Models.Domain_Model.Recipe;
using CletusReyes.Models.DTO.Product;

namespace CletusReyes.Models.DTO.Recipe
{
    public class RecipeResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public ProductResponseDto Product { get; set; }
        public List<RecipeDetailResponseDto> Details { get; set; }
    }
}
