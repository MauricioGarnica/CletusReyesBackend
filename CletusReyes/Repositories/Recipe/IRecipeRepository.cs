using CletusReyes.Models.Domain_Model.Recipe;
using CletusReyes.Models.DTO.Recipe;

namespace CletusReyes.Repositories.Recipe
{
    public interface IRecipeRepository
    {
        public Task<List<TblRecipeHeader>> GetAll();
        public Task<TblRecipeHeader?> GetById(Guid id);
        public Task<TblRecipeHeader> Create(TblRecipeHeader tblRecipeHeader, List<TblRecipeDetail> tblRecipeDetails);
        public Task<List<string>?> MadeProduct(Guid id, int quantityToMake);
        public Task<TblRecipeHeader?> Update(Guid id, TblRecipeHeader tblRecipeHeader, List<TblRecipeDetail> tblRecipeDetails);
        public Task<TblRecipeHeader?> Delete(Guid id);
    }
}
