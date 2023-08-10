using CletusReyes.Models.Domain_Model.Product;

namespace CletusReyes.Models.Domain_Model.Sale_Order
{
    public class TblSaleOrderDetail
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public Guid ProductId { get; set; }
        public Guid SaleOrderHeaderId { get; set; }

        public TblProduct Product { get; set; }
        public TblSaleOrderHeader SaleOrderHeader { get; set; }
    }
}
