using CletusReyes.Models.Domain_Model.User;

namespace CletusReyes.Models.Domain_Model.Sale_Order
{
    public class TblSaleOrderHeader
    {
        public Guid Id { get; set; }
        public float Total { get; set; }
        public Guid SaleOrderStatusId { get; set; }
        public string UserId { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }

        public TblSaleOrderStatus SaleOrderStatus { get; set; }
        public TblUser User { get; set; }
        public List<TblSaleOrderDetail> Details { get; set; }
    }
}
