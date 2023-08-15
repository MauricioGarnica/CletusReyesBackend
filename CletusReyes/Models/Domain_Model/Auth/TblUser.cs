using CletusReyes.Models.Domain_Model.Person;
using CletusReyes.Models.Domain_Model.Sale_Order;
using Microsoft.AspNetCore.Identity;

namespace CletusReyes.Models.Domain_Model.Auth
{
    public class TblUser : IdentityUser
    {
        public ICollection<TblUserRoles> UserRoles { get; set; }
    }
}
