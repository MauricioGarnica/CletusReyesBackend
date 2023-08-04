using CletusReyes.Models.Domain_Model.Category;

namespace CletusReyes.Repositories.Category
{
    public interface ICategoryRepository
    {
        Task<List<TblCategory>> GetAll();
        Task<TblCategory?> GetById(Guid id);
        Task<TblCategory> Create(TblCategory tblCategory);
        Task<TblCategory?> Update(Guid id,  TblCategory tblCategory);
        Task<TblCategory?> Delete(Guid id);
    }
}
