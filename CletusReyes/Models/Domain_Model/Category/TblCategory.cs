namespace CletusReyes.Models.Domain_Model.Category
{
    public class TblCategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public DateTime? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public DateTime? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
