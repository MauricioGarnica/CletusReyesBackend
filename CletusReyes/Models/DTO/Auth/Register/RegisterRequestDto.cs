using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.DTO.Auth.Register
{
    public class RegisterRequestDto
    {
        [Required]
        [DataType(DataType.Text)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public List<string?> Roles { get; set; }
    }
}
