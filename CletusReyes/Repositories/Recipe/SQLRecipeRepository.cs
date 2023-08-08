using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Recipe;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Recipe
{
    public class SQLRecipeRepository : IRecipeRepository
    {
        private readonly CletusReyesDataDbContext dbContext;

        public SQLRecipeRepository(CletusReyesDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblRecipeHeader>> GetAll()
        {
            var recipes = dbContext.RecipeHeaders
                .Include(recipe => recipe.Product)
                    .ThenInclude(recipe => recipe.Size)
                .Include(recipe => recipe.Product)
                    .ThenInclude(recipe => recipe.Category)
                .AsQueryable();

            recipes = recipes.Where(recipe => recipe.Status == true);

            return await recipes.ToListAsync();
        }

        public async Task<TblRecipeHeader?> GetById(Guid id)
        {
            return await dbContext.RecipeHeaders
                .Include(recipe => recipe.Details)
                    .ThenInclude(detail => detail.RawMaterial)
                .Include(recipe => recipe.Product).FirstOrDefaultAsync(recipe => recipe.Id == id);
        }

        public async Task<TblRecipeHeader> Create(TblRecipeHeader tblRecipeHeader, List<TblRecipeDetail> tblRecipeDetails)
        {
            //First insert the header
            tblRecipeHeader.Created_at = DateTime.Now.ToString("G");
            tblRecipeHeader.Status = true;
            await dbContext.RecipeHeaders.AddAsync(tblRecipeHeader);
            await dbContext.SaveChangesAsync();
            Guid recipeHeaderId = tblRecipeHeader.Id;

            //Insert detail of recipe
            foreach (var detail in tblRecipeDetails)
            {
                detail.RecipeHeaderId = recipeHeaderId;

                await dbContext.RecipeDetails.AddAsync(detail);
                await dbContext.SaveChangesAsync();
            }

            return tblRecipeHeader;
        }

        public async Task<TblRecipeHeader?> Delete(Guid id)
        {
            var recipeDeleted = await dbContext.RecipeHeaders.FirstOrDefaultAsync(recipe => recipe.Id == id);

            if(recipeDeleted == null)
            {
                return null;
            }

            recipeDeleted.Status = false;
            recipeDeleted.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return recipeDeleted;
        }
    }
}
