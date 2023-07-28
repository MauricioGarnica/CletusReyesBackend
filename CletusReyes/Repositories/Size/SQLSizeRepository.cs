using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Size;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Size
{
    public class SQLSizeRepository : ISizeRepository
    {
        private readonly CletusReyesDataDbContext dbContext;

        public SQLSizeRepository(CletusReyesDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblSize>> GetAllAsync()
        {
            return await dbContext.Sizes.ToListAsync();
        }

        public async Task<TblSize?> GetByIdAsync(Guid id)
        {
            return await dbContext.Sizes.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
