using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CletusReyes.Models.Domain_Model.Auth
{
    public class TblUserRoles: IdentityUserRole<string>
    {
        public TblUser User { get; set; }
        public TblRoles Roles { get; set; }
    }
}
