using CletusReyes.Models.Domain_Model.Unit_Measure;

namespace CletusReyes.Repositories.Unit_Measure
{
    public interface IUnitMeasureRepository
    {
        Task<List<TblUnitMeasure>> GetAll(string? filterOn = null, string? filterQuery = null);
        Task<TblUnitMeasure?> GetById(Guid id);
        Task<TblUnitMeasure> Create(TblUnitMeasure tblUnitMeasure);
        Task<TblUnitMeasure?> Update(Guid id, TblUnitMeasure tblUnitMeasure);
        Task<TblUnitMeasure?> Delete(Guid id); 
    }
}
