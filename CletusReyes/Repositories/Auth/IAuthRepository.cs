using CletusReyes.Models.Domain_Model.Auth;
using CletusReyes.Models.Domain_Model.Person;
using CletusReyes.Models.DTO.User;

namespace CletusReyes.Repositories.Auth
{
    public interface IAuthRepository
    {
        public Task<TblPerson?> GetById(string id);
        public Task<TblPerson?> Update(string id, UpdateUserRequestDomainModel updateUserRequestDomainModel);
        public Task<bool> AddUserToRoles(string userId, List<string> roles);
        public Task<List<string?>> GetRoles(string userId);
    }
}
