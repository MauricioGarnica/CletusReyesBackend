namespace CletusReyes.Models.DTO.Product
{
    public class UpdateProductRequestDomainModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Quantity { get; set; }
        public string CategoryId { get; set; }
        public string SizeId { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
