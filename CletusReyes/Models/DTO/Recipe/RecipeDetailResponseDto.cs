using CletusReyes.Models.DTO.Raw_Material;

namespace CletusReyes.Models.DTO.Recipe
{
    public class RecipeDetailResponseDto
    {
        public Guid Id { get; set; }
        public float Quantity { get; set; }

        public RawMaterialResponseDto RawMaterial { get; set; }
    }
}
