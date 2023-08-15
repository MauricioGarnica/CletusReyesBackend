using CletusReyes.Models.Domain_Model.Sale_Order;

namespace CletusReyes.Repositories.Sale_Order
{
    public interface ISaleOrderRepository
    {
        public Task<List<TblSaleOrderHeader>> GetAll();
        public Task<List<TblSaleOrderHeader>> GetAllByUser(string id);
        public Task<TblSaleOrderHeader?> GetById(Guid id);
        public Task<TblSaleOrderHeader> Create(TblSaleOrderHeader tblSaleOrderHeader, List<TblSaleOrderDetail> tblSaleOrderDetails);
        public Task<List<string>> Update(Guid id, Guid newStatus);
        public Task<TblSaleOrderHeader?> Delete(Guid id);
    }
}
