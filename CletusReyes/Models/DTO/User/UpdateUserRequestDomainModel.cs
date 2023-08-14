using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.User
{
    public class UpdateUserRequestDomainModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [MaxLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Birthday { get; set; }
    }
}
