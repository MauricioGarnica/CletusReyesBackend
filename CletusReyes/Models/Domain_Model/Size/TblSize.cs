using Microsoft.AspNetCore.Identity;

namespace CletusReyes.Models.Domain_Model.Size
{
    public class TblSize
    {
        public Guid Id { get; set; }
        public string Size { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
