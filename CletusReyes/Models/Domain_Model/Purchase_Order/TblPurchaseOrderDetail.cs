using CletusReyes.Models.Domain_Model.Raw_Material;

namespace CletusReyes.Models.Domain_Model.Purchase_Order
{
    public class TblPurchaseOrderDetail
    {
        public Guid Id { get; set; }
        public Guid RawMaterialId { get; set; }
        public Guid PurchaseOrderHeaderId { get; set; }
        public float Price { get; set; }
        public float Quantity { get; set; }

        public TblRawMaterial RawMaterial { get; set; }
        public TblPurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}
