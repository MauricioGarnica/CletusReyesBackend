using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Raw_Material;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Raw_Material
{
    public class SQLRawMaterialRepository : IRawMaterialRepository
    {
        private readonly CletusReyesDataDbContext dbContext;

        public SQLRawMaterialRepository(CletusReyesDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblRawMaterial>> GetAll()
        {
            var rawMaterials = dbContext.RawMaterials.Include("Providers").Include("UnitMeasures").AsQueryable();
            rawMaterials = rawMaterials.Where(rawMaterial => rawMaterial.Status == true);

            return await rawMaterials.ToListAsync();
        }

        public async Task<TblRawMaterial?> GetById(Guid id)
        {
            return await dbContext.RawMaterials.FirstOrDefaultAsync(rawMaterial => rawMaterial.Id == id);
        }

        public async Task<TblRawMaterial> Create(TblRawMaterial tblRawMaterial)
        {
            tblRawMaterial.Created_at = DateTime.Now.ToString("G");
            await dbContext.RawMaterials.AddAsync(tblRawMaterial);
            await dbContext.SaveChangesAsync();

            return tblRawMaterial;
        }

        public async Task<TblRawMaterial?> Update(Guid id, TblRawMaterial tblRawMaterial)
        {
            var rawMaterialExists = await dbContext.RawMaterials.FirstOrDefaultAsync(rawMaterial => rawMaterial.Id == id);

            if(rawMaterialExists == null) 
            {
                return null;
            }

            rawMaterialExists.Name = tblRawMaterial.Name;
            rawMaterialExists.Description = tblRawMaterial.Description;
            rawMaterialExists.Price = tblRawMaterial.Price;
            rawMaterialExists.ProviderId = tblRawMaterial.ProviderId;
            rawMaterialExists.UnitMeasureId = tblRawMaterial.UnitMeasureId;
            rawMaterialExists.MinValue = tblRawMaterial.MinValue;
            rawMaterialExists.MaxValue = tblRawMaterial.MaxValue;
            rawMaterialExists.Quantity = tblRawMaterial.Quantity;
            rawMaterialExists.UserIdUpdated = tblRawMaterial.UserIdUpdated;
            rawMaterialExists.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return rawMaterialExists;
        }

        public async Task<TblRawMaterial?> Delete(Guid id)
        {
            var rawMaterialExists = await dbContext.RawMaterials.FirstOrDefaultAsync(rawMaterial => rawMaterial.Id == id);

            if (rawMaterialExists == null)
            {
                return null;
            }

            rawMaterialExists.Status = false;

            return rawMaterialExists;
        }
    }
}
