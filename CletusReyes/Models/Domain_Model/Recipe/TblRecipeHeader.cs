using CletusReyes.Models.Domain_Model.Product;

namespace CletusReyes.Models.Domain_Model.Recipe
{
    public class TblRecipeHeader
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid ProductId { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }

        public TblProduct Product { get; set; }
        public List<TblRecipeDetail> Details { get; set; }
    }
}
