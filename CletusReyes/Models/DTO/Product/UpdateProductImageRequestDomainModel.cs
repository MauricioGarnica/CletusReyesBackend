using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Product
{
    public class UpdateProductImageRequestDomainModel
    {
        [Required]
        public IFormFile File { get; set; }

        [Required]
        public string FileName { get; set; }

        public string? FileDescription { get; set; }
    }
}
