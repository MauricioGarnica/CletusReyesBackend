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

        public async Task<List<TblProvider>> GetAll(string? filterOn = null, bool filterQuery = true)
        {
            var providers = dbContext.Providers.AsQueryable();

            if (!string.IsNullOrWhiteSpace(filterOn))
            {
                if (filterOn.Equals("Status", StringComparison.OrdinalIgnoreCase))
                {
                    providers = providers.Where(provider => provider.Status.Equals(filterQuery));
                }
            }

            return await providers.ToListAsync();
        }

        public async Task<TblProvider?> GetByid(Guid id)
        {
            return await dbContext.Providers.FirstOrDefaultAsync(provider => provider.Id == id);
        }

        public async Task<TblProvider> Create(TblProvider tblProvider)
        {
            tblProvider.Created_at = DateTime.Now.ToString("G");
            await dbContext.Providers.AddAsync(tblProvider);
            await dbContext.SaveChangesAsync();

            return tblProvider;
        }

        public async Task<TblProvider?> Update(Guid id, TblProvider tblProvider)
        {
            var providerExists = await dbContext.Providers.FirstOrDefaultAsync(provider => provider.Id == id);

            if(providerExists == null)
            {
                return null;
            }

            providerExists.BusinessName = tblProvider.BusinessName;
            providerExists.ContactName = tblProvider.ContactName;
            providerExists.ContactEmail = tblProvider.ContactEmail;
            providerExists.ContactPhone = tblProvider.ContactPhone;
            providerExists.Address = tblProvider.Address;
            providerExists.UserIdUpdated = tblProvider.UserIdUpdated;
            providerExists.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return providerExists;
        }

        public async Task<TblProvider?> Delete(Guid id)
        {
            var providerExists = await dbContext.Providers.FirstOrDefaultAsync(provider => provider.Id == id);

            if (providerExists == null)
            {
                return null;
            }

            dbContext.Providers.Remove(providerExists);
            await dbContext.SaveChangesAsync();

            return providerExists;
        }
    }
}
