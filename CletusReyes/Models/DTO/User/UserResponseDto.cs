using Microsoft.AspNetCore.Identity;

namespace CletusReyes.Models.DTO.User
{
    public class UserResponseDto
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
