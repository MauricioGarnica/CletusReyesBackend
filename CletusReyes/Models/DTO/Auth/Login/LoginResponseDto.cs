using Microsoft.AspNetCore.Identity;

namespace CletusReyes.Models.DTO.Auth.Login
{
    public class LoginResponseDto
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string JwtToken { get; set; }
        public IList<string> Roles { get; set; }
    }
}
