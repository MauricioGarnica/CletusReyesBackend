namespace CletusReyes.Models.DTO.Product
{
    public class AddProductRequestDomainModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Quantity { get; set; }
        public string? UserIdCreated { get; set; }
    }
}
