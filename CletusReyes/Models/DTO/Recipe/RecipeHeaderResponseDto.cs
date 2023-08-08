using CletusReyes.Models.DTO.Product;

namespace CletusReyes.Models.DTO.Recipe
{
    public class RecipeHeaderResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public ProductResponseDto Product { get; set; }
    }
}
