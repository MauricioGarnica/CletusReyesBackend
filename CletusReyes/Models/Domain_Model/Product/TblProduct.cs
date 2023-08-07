using CletusReyes.Models.Domain_Model.Category;
using CletusReyes.Models.Domain_Model.Size;
using System.ComponentModel.DataAnnotations.Schema;

namespace CletusReyes.Models.Domain_Model.Product
{
    public class TblProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Quantity { get; set; }
        public Guid CategoryId { get; set; }
        public Guid SizeId { get; set; }

        [NotMapped]
        public IFormFile File { get; set; }

        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FileExtension { get; set; }
        public long FileSizeInBytes { get; set; }
        public string FilePath { get; set; }
        public bool Status { get; set; }
        public string? Created_at { get; set; }
        public string? UserIdCreated { get; set; }
        public string? Updated_at { get; set; }
        public string? UserIdUpdated { get; set; }

        public TblCategory Category { get; set; }
        public TblSize Size { get; set; }
    }
}
