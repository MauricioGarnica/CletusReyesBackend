namespace CletusReyes.Models.DTO.Sale_Order
{
    public class AddSaleOrderDetailRequestDomainModel
    {
        public int Quantity { get; set; }
        public float Price { get; set; }
        public Guid ProductId { get; set; }
    }
}
