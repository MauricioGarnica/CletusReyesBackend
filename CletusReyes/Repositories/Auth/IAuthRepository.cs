using CletusReyes.Models.Domain_Model.Auth;

namespace CletusReyes.Repositories.Auth
{
    public interface IAuthRepository
    {
        public Task<bool> AddUserToRoles(string userId, List<string> roles);
        public Task<List<string?>> GetRoles(string userId);
    }
}
