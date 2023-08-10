using CletusReyes.Data;
using CletusReyes.Models.Domain_Model.Unit_Measure;
using Microsoft.EntityFrameworkCore;

namespace CletusReyes.Repositories.Unit_Measure
{
    public class SQLUnitMeasureRepository : IUnitMeasureRepository
    {
        private readonly CletusReyesDataDbContext dbContext;

        public SQLUnitMeasureRepository(CletusReyesDataDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<List<TblUnitMeasure>> GetAll()
        {
            return await dbContext.UnitMeasures.Where(unitMeasure => unitMeasure.Status).ToListAsync();
        }

        public async Task<TblUnitMeasure?> GetById(Guid id)
        {
            return await dbContext.UnitMeasures.FirstOrDefaultAsync(unitMeasure => unitMeasure.Id == id);
        }

        public async Task<TblUnitMeasure> Create(TblUnitMeasure tblUnitMeasure)
        {
            tblUnitMeasure.Created_at = DateTime.Now.ToString("G");
            tblUnitMeasure.Status = true;
            await dbContext.UnitMeasures.AddAsync(tblUnitMeasure);
            await dbContext.SaveChangesAsync();

            return tblUnitMeasure;
        }

        public async Task<TblUnitMeasure?> Update(Guid id, TblUnitMeasure tblUnitMeasure)
        {
            var unitMeasureExists = await dbContext.UnitMeasures.FirstOrDefaultAsync(unit_measure => unit_measure.Id == id);

            if(unitMeasureExists == null)
            {
                return null;
            }

            unitMeasureExists.Name = tblUnitMeasure.Name;
            unitMeasureExists.Description = tblUnitMeasure.Description;
            unitMeasureExists.UserIdUpdated = tblUnitMeasure.UserIdUpdated;
            unitMeasureExists.Updated_at = DateTime.Today.ToString("G");
            await dbContext.SaveChangesAsync();

            return unitMeasureExists;
        }

        public async Task<TblUnitMeasure?> Delete(Guid id)
        {
            var unitMeasureExists = await dbContext.UnitMeasures.FirstOrDefaultAsync(unit_measure => unit_measure.Id == id);

            if(unitMeasureExists == null)
            {
                return null;
            }

            unitMeasureExists.Status = false;
            unitMeasureExists.Updated_at = DateTime.Now.ToString("G");
            await dbContext.SaveChangesAsync();

            return unitMeasureExists;
        }
    }
}
