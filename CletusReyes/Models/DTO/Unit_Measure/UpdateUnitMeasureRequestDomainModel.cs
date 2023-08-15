using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Unit_Measure
{
    public class UpdateUnitMeasureRequestDomainModel
    {
        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string? UserIdUpdated { get; set; }
    }
}
