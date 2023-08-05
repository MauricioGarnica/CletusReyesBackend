using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Category;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Category
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        private readonly CletusReyesDataDbContext dbContext;

        public SQLCategoryRepository(CletusReyesDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblCategory>> GetAll()
        {
            var categories = dbContext.Categories.AsQueryable();
            categories = categories.Where(category => category.Status == true);

            return await categories.ToListAsync();
        }

        public async Task<TblCategory?> GetById(Guid id)
        {
            return await dbContext.Categories.FirstOrDefaultAsync(category => category.Id == id);
        }

        public async Task<TblCategory> Create(TblCategory tblCategory)
        {
            tblCategory.Created_at = DateTime.Now.ToString("G");
            await dbContext.Categories.AddAsync(tblCategory);
            await dbContext.SaveChangesAsync();

            return tblCategory;
        }

        public async Task<TblCategory?> Update(Guid id, TblCategory tblCategory)
        {
            var categoryUpdated = await dbContext.Categories.FirstOrDefaultAsync(category => category.Id == id);

            if(categoryUpdated == null)
            {
                return null;
            }

            categoryUpdated.Name = tblCategory.Name;
            categoryUpdated.Description = tblCategory.Description;
            categoryUpdated.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return categoryUpdated;
        }

        public async Task<TblCategory?> Delete(Guid id)
        {
            var categoryDeleted = await dbContext.Categories.FirstOrDefaultAsync(category => category.Id == id);

            if (categoryDeleted == null)
            {
                return null;
            }

            categoryDeleted.Status = false;
            categoryDeleted.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return categoryDeleted;
        }
    }
}
