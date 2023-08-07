using System.ComponentModel.DataAnnotations.Schema;

namespace CletusReyes.Models.Domain_Model.Product
{
    public class ProductImage
    {
        [NotMapped]
        public IFormFile File { get; set; }

        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FileExtension { get; set; }
        public long FileSizeInBytes { get; set; }
        public string FilePath { get; set; }
    }
}
