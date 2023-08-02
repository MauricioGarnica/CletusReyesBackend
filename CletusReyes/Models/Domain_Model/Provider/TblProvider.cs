namespace CletusReyes.Models.Domain_Model.Provider
{
    public class TblProvider
    {
        public Guid Id { get; set; }
        public string BusinessName { get; set; }
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }
    }
}
