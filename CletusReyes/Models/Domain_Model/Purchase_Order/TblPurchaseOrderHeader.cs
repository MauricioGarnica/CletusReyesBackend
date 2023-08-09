using CletusReyes.Models.Domain_Model.Provider;

namespace CletusReyes.Models.Domain_Model.Purchase_Order
{
    public class TblPurchaseOrderHeader
    {
        public Guid Id { get; set; }
        public Guid ProviderId { get; set; }
        public Guid PurchaseOrderStatusId { get; set; }
        public float Total { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }

        public TblProvider Provider { get; set; }
        public TblPurchaseOrderStatus PurchaseOrderStatus { get; set; }
        public List<TblPurchaseOrderDetail> Details { get; set; }
    }
}
