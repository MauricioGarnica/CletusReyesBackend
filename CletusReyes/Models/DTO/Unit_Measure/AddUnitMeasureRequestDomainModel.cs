using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Unit_Measure
{
    public class AddUnitMeasureRequestDomainModel
    {
        [Required]
        public string Name { get; set; }
        
        public string? Description { get; set; }

        public string? UserIdCreated { get; set; }
    }
}
