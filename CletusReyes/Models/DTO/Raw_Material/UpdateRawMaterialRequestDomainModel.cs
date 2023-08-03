namespace CletusReyes.Models.DTO.Raw_Material
{
    public class UpdateRawMaterialRequestDomainModel
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public Guid ProviderId { get; set; }
        public Guid UnitMeasureId { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float Quantity { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
