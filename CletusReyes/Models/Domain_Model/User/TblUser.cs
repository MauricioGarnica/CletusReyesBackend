using CletusReyes.Models.Domain_Model.Sale_Order;
using Microsoft.AspNetCore.Identity;

namespace CletusReyes.Models.Domain_Model.User
{
    public class TblUser : IdentityUser
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public TblSaleOrderHeader SaleOrderHeader { get; set; }
    }
}
