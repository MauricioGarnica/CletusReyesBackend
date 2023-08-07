using CletusReyes.Models.Domain_Model.Product;

namespace CletusReyes.Repositories.Product
{
    public interface IProductRepository
    {
        Task<List<TblProduct>> GetAll();
        Task<TblProduct?> GetById(Guid id);
        Task<TblProduct> Create(TblProduct tblProduct);
        Task<TblProduct?> Update(Guid id, TblProduct tblProduct);
        Task<TblProduct?> Delete(Guid id); 
    }
}
