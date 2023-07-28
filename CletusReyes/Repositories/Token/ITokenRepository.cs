using Microsoft.AspNetCore.Identity;

namespace CletusReyes.Repositories.Token
{
    public interface ITokenRepository
    {
        string CreateJwt(IdentityUser user, List<string> roles);
    }
}
