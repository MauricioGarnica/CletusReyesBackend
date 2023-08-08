using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Provider;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Provider
{
    public class SQLProviderRepository : IProviderRepository
    {
        private readonly CletusReyesDataDbContext dbContext;

        public SQLProviderRepository(CletusReyesDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblProvider>> GetAll()
        {
            var providers = dbContext.Providers.AsQueryable();

            providers = providers.Where(provider => provider.Status == true);

            return await providers.ToListAsync();
        }

        public async Task<TblProvider?> GetByid(Guid id)
        {
            return await dbContext.Providers.FirstOrDefaultAsync(provider => provider.Id == id);
        }

        public async Task<TblProvider> Create(TblProvider tblProvider)
        {
            tblProvider.Created_at = DateTime.Now.ToString("G");
            tblProvider.Status = true;
            await dbContext.Providers.AddAsync(tblProvider);
            await dbContext.SaveChangesAsync();

            return tblProvider;
        }

        public async Task<TblProvider?> Update(Guid id, TblProvider tblProvider)
        {
            var providerUpdated = await dbContext.Providers.FirstOrDefaultAsync(provider => provider.Id == id);

            if(providerUpdated == null)
            {
                return null;
            }

            providerUpdated.BusinessName = tblProvider.BusinessName;
            providerUpdated.ContactName = tblProvider.ContactName;
            providerUpdated.ContactEmail = tblProvider.ContactEmail;
            providerUpdated.ContactPhone = tblProvider.ContactPhone;
            providerUpdated.Address = tblProvider.Address;
            providerUpdated.UserIdUpdated = tblProvider.UserIdUpdated;
            providerUpdated.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return providerUpdated;
        }

        public async Task<TblProvider?> Delete(Guid id)
        {
            var providerDelete = await dbContext.Providers.FirstOrDefaultAsync(provider => provider.Id == id);

            if (providerDelete == null)
            {
                return null;
            }

            providerDelete.Status = false;
            providerDelete.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return providerDelete;
        }
    }
}
