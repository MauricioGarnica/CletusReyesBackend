using CletusReyes.Models.Domain_Model.Provider;
using CletusReyes.Models.Domain_Model.Unit_Measure;

namespace CletusReyes.Models.Domain_Model.Raw_Material
{
    public class TblRawMaterial
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public Guid ProviderId { get; set; }
        public Guid UnitMeasureId { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float Quantity { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }

        public TblProvider Provider { get; set; }
        public TblUnitMeasure UnitMeasure { get; set; }
    }
}
