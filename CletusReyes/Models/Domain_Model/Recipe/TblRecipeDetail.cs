using CletusReyes.Models.Domain_Model.Raw_Material;

namespace CletusReyes.Models.Domain_Model.Recipe
{
    public class TblRecipeDetail
    {
        public Guid Id { get; set; }
        public Guid RecipeHeaderId { get; set; }
        public Guid RawMaterialId { get; set; }
        public float Quantity { get; set; }

        public TblRecipeHeader RecipeHeader { get; set; }
        public TblRawMaterial RawMaterial { get; set; }
    }
}
