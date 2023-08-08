using CletusReyes.Models.DTO.Provider;
using CletusReyes.Models.DTO.Unit_Measure;

namespace CletusReyes.Models.DTO.Raw_Material
{
    public class RawMaterialResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float Quantity { get; set; }

        public ProviderResponseDto Provider { get; set; }
        public UnitMeasureResponseDto UnitMeasure { get; set; }

    }
}
