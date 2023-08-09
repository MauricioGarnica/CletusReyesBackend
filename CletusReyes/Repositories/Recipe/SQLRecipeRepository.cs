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
            tblRecipeHeader.Created_at = DateTime.Now.ToString("G");
            tblRecipeHeader.Status = true;
            await dbContext.RecipeHeaders.AddAsync(tblRecipeHeader);
            await dbContext.SaveChangesAsync();

            tblRecipeDetails.ForEach(detail => detail.RecipeHeaderId = tblRecipeHeader.Id);
            await dbContext.RecipeDetails.AddRangeAsync(tblRecipeDetails);
            await dbContext.SaveChangesAsync();

            return tblRecipeHeader;
        }

        public async Task<List<string>?> MadeProduct(Guid id, int quantityToMake)
        {
            var recipeToMake = await dbContext.RecipeHeaders
                                        .Include(recipe => recipe.Details)
                                            .ThenInclude(detail => detail.RawMaterial)
                                        .Include(recipe => recipe.Product)
                                        .FirstOrDefaultAsync(recipe => recipe.Id == id);
            if(recipeToMake == null)
            {
                return new List<string>
                {
                    "0", $"Recipe with id: {id} not found"
                };
            }

            var rawMaterialsShortage = recipeToMake.Details
                                        .Where(detail => detail.RawMaterial.Quantity - (detail.Quantity * quantityToMake) < detail.RawMaterial.MinValue)
                                        .Select(detail => detail.RawMaterial.Name);

            if (rawMaterialsShortage.Any())
            {
                string rawMaterialsList = string.Join(", ", rawMaterialsShortage);
                return new List<string> 
                { 
                    "0", $"This product cannot be made, because the following raw materials are less than minimum value required in stock: {rawMaterialsList}"
                };
            }
            else
            {
                recipeToMake.Product.Quantity += quantityToMake;
                await dbContext.SaveChangesAsync();

                foreach (var detail in recipeToMake.Details)
                {
                    detail.RawMaterial.Quantity -= detail.Quantity * quantityToMake;
                }
                await dbContext.SaveChangesAsync();

                return new List<string> 
                { 
                    "1", $"{quantityToMake} products have been added to the warehouse for the following product: {recipeToMake.Product.Name}"
                };
            }
        }

        public async Task<TblRecipeHeader?> Update(Guid id, TblRecipeHeader tblRecipeHeader, List<TblRecipeDetail> tblRecipeDetails)
        {
            var recipeUpdated = await dbContext.RecipeHeaders.Include(recipe => recipe.Details).FirstOrDefaultAsync(recipe => recipe.Id == id);

            if(recipeUpdated == null)
            {
                return null;
            }

            dbContext.RecipeDetails.RemoveRange(recipeUpdated.Details);
            await dbContext.SaveChangesAsync();

            recipeUpdated.Name = tblRecipeHeader.Name;
            recipeUpdated.ProductId = tblRecipeHeader.ProductId;
            recipeUpdated.Description = tblRecipeHeader.Description;
            recipeUpdated.UserIdUpdated = tblRecipeHeader.UserIdUpdated;
            recipeUpdated.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            tblRecipeDetails.ForEach(detail => detail.RecipeHeaderId = recipeUpdated.Id);
            await dbContext.RecipeDetails.AddRangeAsync(tblRecipeDetails);
            await dbContext.SaveChangesAsync();

            return recipeUpdated;
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
