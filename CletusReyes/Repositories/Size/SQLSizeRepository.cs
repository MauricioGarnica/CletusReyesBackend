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
            var sizes = dbContext.Sizes.AsQueryable();

            sizes = sizes.Where(size => size.Status == true);

            return await sizes.ToListAsync();
        }

        public async Task<TblSize?> GetByIdAsync(Guid id)
        {
            return await dbContext.Sizes.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TblSize> Create(TblSize tblSize)
        {
            tblSize.Created_at = DateTime.Now.ToString("G");
            tblSize.Status = true;
            await dbContext.Sizes.AddAsync(tblSize);
            await dbContext.SaveChangesAsync();

            return tblSize;
        }

        public async Task<TblSize?> Update(Guid id, TblSize tblSize)
        {
            var sizeUpdated = await dbContext.Sizes.FirstOrDefaultAsync(size => size.Id == id);

            if(sizeUpdated == null)
            {
                return null;
            }

            sizeUpdated.Size = tblSize.Size;
            sizeUpdated.Description = tblSize.Description;
            sizeUpdated.UserIdUpdated = tblSize.UserIdUpdated;
            sizeUpdated.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return sizeUpdated;
        }

        public async Task<TblSize?> Delete(Guid id)
        {
            var sizeDelete = await dbContext.Sizes.FirstOrDefaultAsync(size => size.Id == id);

            if (sizeDelete == null)
            {
                return null;
            }

            sizeDelete.Status = false;
            sizeDelete.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return sizeDelete;
        }
    }
}
