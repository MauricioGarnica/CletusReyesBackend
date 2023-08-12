using Microsoft.AspNetCore.Identity;

namespace CletusReyes.Models.Domain_Model.Auth
{
    public class TblRoles : IdentityRole
    {
        public ICollection<TblUserRoles> UserRoles { get; set; }
    }
}
