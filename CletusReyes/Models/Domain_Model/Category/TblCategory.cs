namespace CletusReyes.Models.Domain_Model.Category
{
    public class TblCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
