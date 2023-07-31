using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.Domain_Model.Unit_Measure
{
    public class TblUnitMeasure
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
