using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Product
{
    public class UpdateProductImageRequestDomainModel
    {
        public IFormFile File { get; set; }

        public string FileName { get; set; }

        public string? FileDescription { get; set; }
    }
}
