using CletusReyes.Models.Domain_Model.Raw_Material;

namespace CletusReyes.Repositories.Raw_Material
{
    public interface IRawMaterialRepository
    {
        Task<List<TblRawMaterial>> GetAll();
        Task<TblRawMaterial?> GetById(Guid id);
        Task<TblRawMaterial> Create(TblRawMaterial tblRawMaterial);
        Task<TblRawMaterial?> Update(Guid id, TblRawMaterial tblRawMaterial);
        Task<TblRawMaterial?> Delete(Guid id);
    }
}
