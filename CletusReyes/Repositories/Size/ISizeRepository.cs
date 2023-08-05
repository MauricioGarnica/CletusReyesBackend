using CletusReyes.Models.Domain_Model.Size;

namespace CletusReyes.Repositories.Size
{
    public interface ISizeRepository
    {
        Task<List<TblSize>> GetAllAsync();
        Task<TblSize?> GetByIdAsync(Guid id);
        Task<TblSize> Create(TblSize tblSize);
        Task<TblSize?> Update(Guid id, TblSize tblSize);
        Task<TblSize?> Delete(Guid id);
    }
}
