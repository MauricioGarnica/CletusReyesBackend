using CletusReyes.Models.DTO.Category;
using CletusReyes.Models.DTO.Size;

namespace CletusReyes.Models.DTO.Product
{
    public class ProductResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int Quantity { get; set; }
        public string FilePath { get; set; }

        public CategoryResponseDto Category { get; set; }
        public SizeResponseDto Size { get; set; }
    }
}
