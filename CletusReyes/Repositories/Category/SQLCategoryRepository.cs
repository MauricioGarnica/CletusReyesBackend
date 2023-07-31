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
            return await dbContext.Categories.ToListAsync();
        }

        public async Task<TblCategory?> GetById(Guid id)
        {
            return await dbContext.Categories.FirstOrDefaultAsync(category => category.Id == id);
        }
    }
}
