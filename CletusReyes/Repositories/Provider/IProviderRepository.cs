using CletusReyes.Models.Domain_Model.Provider;

namespace CletusReyes.Repositories.Provider
{
    public interface IProviderRepository
    {
        Task<List<TblProvider>> GetAll();
        Task<TblProvider?> GetByid(Guid id);
        Task<TblProvider> Create(TblProvider tblProvider);
        Task<TblProvider?> Update(Guid id, TblProvider tblProvider);
        Task<TblProvider?> Delete(Guid id);
    }
}
