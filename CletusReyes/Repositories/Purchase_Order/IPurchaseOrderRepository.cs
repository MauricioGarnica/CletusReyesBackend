using CletusReyes.Models.Domain_Model.Purchase_Order;

namespace CletusReyes.Repositories.Purchase_Order
{
    public interface IPurchaseOrderRepository
    {
        public Task<List<TblPurchaseOrderHeader>> GetAll();
        public Task<TblPurchaseOrderHeader?> GetById(Guid id);
        public Task<TblPurchaseOrderHeader> Create(TblPurchaseOrderHeader tblPurchaseOrderHeader, List<TblPurchaseOrderDetail> tblPurchaseOrderDetails);
        public Task<TblPurchaseOrderHeader?> Update(Guid id, Guid newStatus);
        public Task<TblPurchaseOrderHeader?> Delete(Guid id);
    }
}
